using InventarioApp.Models;
using InventarioApp.Infrastructure;
using InventarioApp.Factories;
using System.Text.Json;

var almacenamiento = new JsonInventarioStorage();

var productos = new List<Producto>
{
    ProductoFactory.Crear(nombre: "Laptop", precio: 1200.00m, cantidad: 3, CategoriaProducto.Electronica),
    ProductoFactory.Crear(nombre: "Camisa", precio: 45.00m, cantidad: 15, CategoriaProducto.Ropa),
    ProductoFactory.Crear(nombre: "Arroz", precio: 12.00m, cantidad: 50, CategoriaProducto.Alimentos),
    ProductoFactory.Crear(nombre: "Lámpara", precio: 35.00m, cantidad: 2, CategoriaProducto.Hogar),
    ProductoFactory.Crear(nombre: "Balón", precio: 25.00m, cantidad: 8, CategoriaProducto.Deportes),
    ProductoFactory.Crear(nombre: "Mesa", precio: 150.00m, cantidad: 4, CategoriaProducto.Muebles)
};

var generador = new GeneradorReportes(productos);

Console.WriteLine(generador.GenerarResumen());
Console.WriteLine("\n");

Console.WriteLine(generador.GenerarReporteStockBajo());
Console.WriteLine("\n");

Console.WriteLine(generador.GenerarTopProductos());
Console.WriteLine("\n");

Console.WriteLine(generador.ExportarCsv());
Console.WriteLine("\n");

Console.WriteLine(generador.ExportarResumenJson());

string ruta = "inventario_test.json";

almacenamiento.CrearBackup(ruta);
almacenamiento.Guardar(productos, ruta);

Console.WriteLine("Inventario guardado correctamente");
Console.WriteLine(JsonSerializer.Serialize(productos, new JsonSerializerOptions { WriteIndented = true }));

var productosCargados = almacenamiento.Cargar(ruta);
Console.WriteLine("Inventario cargado correctamente:");

foreach(var p in productosCargados)
{
    Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Cantidad: {p. Cantidad}, Categoria: {p.Categoria}, Estado: {p.Estado}");
}