using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Data;
using Control_Importaciones.Models;


namespace Control_Importaciones.Data
{
    public class MaterialService
    {
        private readonly Database _database;

        public MaterialService(Database database)
        {
            _database = database;
        }

        public void Create(Material material)
        {
            string query = "INSERT INTO Material (importacion_id, material_name, descripcion) VALUES (@importacion_id, @material_name, @descripcion)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@importacion_id", material.ImportacionId),
                new SQLiteParameter("@material_name", material.MaterialName), // Cambiado de 'Material' a 'MaterialName'
                new SQLiteParameter("@descripcion", material.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM Material";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(Material material)
        {
            string query = "UPDATE Material SET importacion_id = @importacion_id, material_name = @material_name, descripcion = @descripcion WHERE material_id = @material_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@material_id", material.MaterialId),
                new SQLiteParameter("@importacion_id", material.ImportacionId),
                new SQLiteParameter("@material_name", material.MaterialName), // Cambiado de 'Material' a 'MaterialName'
                new SQLiteParameter("@descripcion", material.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int materialId)
        {
            string query = "DELETE FROM Material WHERE material_id = @material_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@material_id", materialId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
