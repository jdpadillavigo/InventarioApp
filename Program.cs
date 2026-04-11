using InventarioApp.Factories;
using InventarioApp.Repositories;
using InventarioApp.Models;

Console.WriteLine("=== InventarioApp ===");

var repositorio = new InMemoryProductoRepository();

var laptop = ProductoFactory. Crear(nombre: "Laptop Dell XPS 13", precio: 1200, cantidad: 5, CategoriaProducto.Electronica);
var mouse  = ProductoFactory. Crear(nombre: "Mouse Logitech MX Master", precio: 99, cantidad: 20, CategoriaProducto. Electronica);
var teclado = ProductoFactory. Crear(nombre: "Teclado Mecánico", precio: 150, cantidad: 3, CategoriaProducto.Electronica);
var silla  = ProductoFactory.Crear(nombre: "Silla Ergonomica Herman Miller", precio: 500, cantidad: 8, CategoriaProducto.Muebles);
var escritorio = ProductoFactory. Crear(nombre: "Escritorio Stand-up", precio: 300, cantidad: 2, CategoriaProducto.Muebles);

repositorio.Agregar(laptop);
repositorio.Agregar(mouse);
repositorio.Agregar(teclado);
repositorio.Agregar(silla);
repositorio.Agregar(escritorio);

Console.WriteLine($"Productos agregados: {repositorio.Cantidad}\n");

// Consultas básicas LINQ

var electronicos = repositorio.BuscarPorCategoria(CategoriaProducto.Electronica);
Console.WriteLine("Productos de electrónica: ");

foreach (var producto in electronicos)
{
    Console.WriteLine($"  {producto.Nombre}: ${producto.Precio}");
}

var conMouse = repositorio.BuscarPorNombre("mouse");
Console.WriteLine("\nProductos con 'mouse' en el nombre: ");
foreach (var producto in conMouse)
{
    Console.WriteLine($"  {producto.Nombre}");
}

var nombres = repositorio.ObtenerNombres();
Console.WriteLine($"\nTodos los nombres {string.Join(", ", nombres)}");

var hayStockBajo = repositorio.HayStockBajo();
Console.WriteLine($"\n¿Hay stock bajo? {hayStockBajo}");