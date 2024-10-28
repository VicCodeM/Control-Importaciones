using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Models;

namespace Control_Importaciones.Data
{
    public class PedimentoService
    {
        private readonly Database _database;

        public PedimentoService(Database database)
        {
            _database = database;
        }

        public void Create(Pedimento pedimento)
        {
            string query = "INSERT INTO Pedimento (importacion_id, clave_pedimento, numero_pedimento, pedimento_pdf) VALUES (@importacion_id, @clave_pedimento, @numero_pedimento, @pedimento_pdf)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@importacion_id", pedimento.ImportacionId),
                new SQLiteParameter("@clave_pedimento", pedimento.ClavePedimento),
                new SQLiteParameter("@numero_pedimento", pedimento.NumeroPedimento),
                new SQLiteParameter("@pedimento_pdf", pedimento.PedimentoPdf)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM Pedimento";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(Pedimento pedimento)
        {
            string query = "UPDATE Pedimento SET importacion_id = @importacion_id, clave_pedimento = @clave_pedimento, numero_pedimento = @numero_pedimento, pedimento_pdf = @pedimento_pdf WHERE pedimento_id = @pedimento_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@pedimento_id", pedimento.PedimentoId),
                new SQLiteParameter("@importacion_id", pedimento.ImportacionId),
                new SQLiteParameter("@clave_pedimento", pedimento.ClavePedimento),
                new SQLiteParameter("@numero_pedimento", pedimento.NumeroPedimento),
                new SQLiteParameter("@pedimento_pdf", pedimento.PedimentoPdf)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int pedimentoId)
        {
            string query = "DELETE FROM Pedimento WHERE pedimento_id = @pedimento_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@pedimento_id", pedimentoId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
