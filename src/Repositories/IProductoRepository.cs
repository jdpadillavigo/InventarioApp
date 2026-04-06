namespace InventarioApp.Repositories;

using InventarioApp.Models;

/// <summary>
/// Contrato para almacenamiento de productos.
/// Define las operaciones básicas CRUD.
/// </summary>
public interface IProductoRepository
{
    /// <summary>
    /// Agrega un producto al repositorio.
    /// </summary>
    void Agregar(Producto producto);

    /// <summary>
    /// Obtiene un producto por su ID.
    /// Retorna null si no existe.
    /// </summary>
    Producto? ObtenerPorId(int id);

    /// <summary>
    /// Obtiene todos los productos.
    /// </summary>
    IEnumerable<Producto> ObtenerTodos();

    /// <summary>
    /// Actualiza un producto existente.
    /// </summary>
    bool Actualizar(Producto producto);

    /// <summary>
    /// Elimina un producto por su ID.
    /// Retorna true si se eliminó, false si no existía.
    /// </summary>
    bool Eliminar(int id);

    /// <summary>
    /// Cantidad total de productos en el repositorio.
    /// </summary>
    int Cantidad { get; }
}
