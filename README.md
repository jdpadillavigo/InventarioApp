# Sistema de Gestión de Inventario

Proyecto del curso **Fundamentos de .NET** - Platzi

## Requisitos
- .NET 10 SDK

## Cómo ejecutar
dotnet run

## Estructura del proyecto
```
InventarioApp/
├── Program.cs
├── InventarioApp.csproj
├── .gitignore
├── README.md
└── src/
    ├── Models/
    │   ├── CategoriaProducto.cs  (enum)
    │   ├── EstadoProducto.cs     (enum)
    │   ├── Producto.cs           (class con validación)
    │   └── Proveedor.cs          (record)
    └── Factories/
        └── ProductoFactory.cs    (creación validada)
```

## Progreso del curso
- [x] Módulo 1: El Ecosistema .NET
- [x] Módulo 2: Entradas, Salidas y Tipos
- [x] Módulo 3: Funciones y Modelado de Dominio
- [x] Módulo 4: Colecciones y LINQ
- [x] Módulo 5: Archivos y Procesamiento