using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Models;

namespace Control_Importaciones.Data
{
    public class PresentacionMaterialService
    {
        private readonly Database _database;

        public PresentacionMaterialService(Database database)
        {
            _database = database;
        }

        public void Create(PresentacionMaterial presentacionMaterial)
        {
            string query = "INSERT INTO PresentacionMaterial (material_id, bultos_cajas, descripcion) VALUES (@material_id, @bultos_cajas, @descripcion)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@material_id", presentacionMaterial.MaterialId),
                new SQLiteParameter("@bultos_cajas", presentacionMaterial.BultosCajas),
                new SQLiteParameter("@descripcion", presentacionMaterial.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM PresentacionMaterial";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(PresentacionMaterial presentacionMaterial)
        {
            string query = "UPDATE PresentacionMaterial SET material_id = @material_id, bultos_cajas = @bultos_cajas, descripcion = @descripcion WHERE presentacion_id = @presentacion_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@presentacion_id", presentacionMaterial.PresentacionId),
                new SQLiteParameter("@material_id", presentacionMaterial.MaterialId),
                new SQLiteParameter("@bultos_cajas", presentacionMaterial.BultosCajas),
                new SQLiteParameter("@descripcion", presentacionMaterial.Descripcion)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int presentacionId)
        {
            string query = "DELETE FROM PresentacionMaterial WHERE presentacion_id = @presentacion_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@presentacion_id", presentacionId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
