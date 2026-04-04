// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

if(args.Length > 0)
{
    switch(args[0].ToLower())
    {
        case "--help":
            MostrarAyuda();
            Environment.Exit(0);
            break;
        
        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine($"Error: Comando desconocido '{args[0]}'");
            Console.WriteLine("use --help para ver los comandos disponibles.");
            Environment.Exit(2);
            break;
    }
}

int cantidadProductos = 0;
decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;
string nombreSistema = "Sistema de Gestión de Inventario";
decimal precio = 19.99m;

Console.WriteLine("Estado del sistema: " + (sistemaActivo ? "Activo" : "Inactivo"));
Console.WriteLine($" Nombre: {nombreSistema}");
Console.WriteLine($" Productos registrados: {cantidadProductos}");
Console.WriteLine($" Valor total del inventario: {valorTotalDelInventario:N2}");
Console.WriteLine($" Sistema activo: {(sistemaActivo ? "Sí" : "No")}");

Console.Write("Ingrese una cantidad: ");
string? entradaCantidad = Console.ReadLine();

// Conversión segura TryParse
if(int.TryParse(entradaCantidad, out int cantidad))
{
    Console.Write($"Cantidad validada: {cantidad}\n");
    cantidadProductos = cantidad;
}
else
{
    Console.WriteLine("Error: Debe ingresar un número entero");
}

Console.Write("Ingrese un precio: ");
string? entradaPrecio = Console.ReadLine();

if(decimal.TryParse(entradaPrecio, out decimal precio2))
{
    Console.Write($"Precio validado: {precio2:N2}\n");
    valorTotalDelInventario = cantidadProductos * precio2;
    Console.WriteLine($"Valor total del inventario actualizado: {valorTotalDelInventario:N2}");
}
else
{
    Console.WriteLine("Error: Debe ingresar un número decimal");
}

// MostrarBanner();

// Modo interactivo si no hay argumentos
Console.Write("Ingrese un comando (o 'salir' para terminar): ");
string? entrada = Console.ReadLine(); // STDIN para leer la entrada del usuario

if(string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("¡Hasta luego!"); // STDOut
    Environment.Exit(0);
}

/*Console.WriteLine("Estructura del proyecto:");
Console.WriteLine("  InventarioApp/");
Console.WriteLine("   |-- Program.cs");
Console.WriteLine("   |-- InventarioApp.csproj");
Console.WriteLine("   |-- .gitignore");
Console.WriteLine("   |-- README.md");
Console.WriteLine("   |-- src/");
Console.WriteLine("       |-- Models/ (Próxima clase)");
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Próximo paso: Checkpoint y Entregable");*/

// ============ FUNCIONES ============
void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
    Console.WriteLine();
    Console.WriteLine($"Versión: {version}");
    Console.WriteLine($"Plataforma: {Environment.OSVersion}");
    Console.WriteLine($".NET Versión: {Environment.Version}");
    Console.WriteLine();
}

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h       Muestra esta ayuda");
    Console.WriteLine("  --version, -v    Muestra la versión");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine("  dotnet run -- --help");
    Console.WriteLine("  dotnet run -- --version");
}