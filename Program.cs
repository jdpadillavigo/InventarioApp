// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.2
// Estado: Estructura profesional configurada
// ============================================================

// Variables

int cantidadProductos = 0;
 decimal valorTotalDelInventario = 0.00m;
bool sistemaActivo = true;

MostrarBanner();

bool continuar = true;

while(continuar)
{
    MostrarMenu();
    string comando = LeerEntrada("inventario");
    Console.WriteLine($"Comando ingresado: {comando}");
    continuar = false;
}

// ============ MÉTODOS ============
bool ProcesarComando(string comando)
{
    switch(comando)
    {
        case "listar":
            ListarProductos();
            return true;
        case "agregar":
            AgregarProducto();
            return true;
        case "buscar":
            BuscarProducto();
            return true;
        case "salir":
            return false;
        default:
            Console.WriteLine($"Comando '{comando}' no válido");
            return true;
    }
}

void ListarProductos()
{
    Console.WriteLine($"Total: {cantidadProductos} productos en el inventario");
    Console.WriteLine($"Valor: ${valorTotalDelInventario}");
}

void AgregarProducto()
{
    Console.WriteLine("Agregar producto (Módulo 3)");
}

void BuscarProducto()
{
    Console.WriteLine("Buscar producto (Módulo 4)");
}

string LeerEntrada(string prompt)
{
    string salida = "\nEl prompt ingresado es: " + prompt;
    return salida;
}

// ============ FUNCIONES ============
void MostrarBanner()
{
    Console.WriteLine("╔══════════════════════════════════════╗");
    Console.WriteLine("║   SISTEMA DE GESTIÓN DE INVENTARIO   ║");
    Console.WriteLine("╚══════════════════════════════════════╝");
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

void MostrarMenu()
{
    Console.WriteLine("\nMENÚ PRINCIPAL");
    Console.WriteLine("1. listar - Ver productos");
    Console.WriteLine("2. agregar - Añadir producto");
    Console.WriteLine("3. buscar - Buscar producto");
    Console.WriteLine("4. salir - Terminar\n");
}