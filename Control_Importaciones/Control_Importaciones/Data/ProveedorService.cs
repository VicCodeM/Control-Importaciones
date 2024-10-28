using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Models;

namespace Control_Importaciones.Data
{
    public class ProveedorService
    {
        private readonly Database _database;

        public ProveedorService(Database database)
        {
            _database = database;
        }

        public void Create(Proveedor proveedor)
        {
            string query = "INSERT INTO Proveedor (nombre, descripcion) VALUES (@nombre, @descripcion)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@nombre", proveedor.Nombre),
                new SQLiteParameter("@descripcion", proveedor.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM Proveedor";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(Proveedor proveedor)
        {
            string query = "UPDATE Proveedor SET nombre = @nombre, descripcion = @descripcion WHERE proveedor_id = @proveedor_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@proveedor_id", proveedor.ProveedorId),
                new SQLiteParameter("@nombre", proveedor.Nombre),
                new SQLiteParameter("@descripcion", proveedor.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int proveedorId)
        {
            string query = "DELETE FROM Proveedor WHERE proveedor_id = @proveedor_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@proveedor_id", proveedorId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
