using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Models;

namespace Control_Importaciones.Data
{
    public class ImpuestosService
    {
        private readonly Database _database;

        public ImpuestosService(Database database)
        {
            _database = database;
        }

        public void Create(Impuestos impuestos)
        {
            string query = "INSERT INTO Impuestos (pedimento_id, valor_dolares, valor_aduana, valor_comercial, tipo_cambio, dta, iva, prevalidacion, iva_prevalidacion, igi) VALUES (@pedimento_id, @valor_dolares, @valor_aduana, @valor_comercial, @tipo_cambio, @dta, @iva, @prevalidacion, @iva_prevalidacion, @igi)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@pedimento_id", impuestos.PedimentoId),
                new SQLiteParameter("@valor_dolares", impuestos.ValorDolares),
                new SQLiteParameter("@valor_aduana", impuestos.ValorAduana),
                new SQLiteParameter("@valor_comercial", impuestos.ValorComercial),
                new SQLiteParameter("@tipo_cambio", impuestos.TipoCambio),
                new SQLiteParameter("@dta", impuestos.Dta),
                new SQLiteParameter("@iva", impuestos.Iva),
                new SQLiteParameter("@prevalidacion", impuestos.Prevalidacion),
                new SQLiteParameter("@iva_prevalidacion", impuestos.IvaPrevalidacion),
                new SQLiteParameter("@igi", impuestos.Igi)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM Impuestos";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(Impuestos impuestos)
        {
            string query = "UPDATE Impuestos SET pedimento_id = @pedimento_id, valor_dolares = @valor_dolares, valor_aduana = @valor_aduana, valor_comercial = @valor_comercial, tipo_cambio = @tipo_cambio, dta = @dta, iva = @iva, prevalidacion = @prevalidacion, iva_prevalidacion = @iva_prevalidacion, igi = @igi WHERE impuestos_id = @impuestos_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@impuestos_id", impuestos.ImpuestosId),
                new SQLiteParameter("@pedimento_id", impuestos.PedimentoId),
                new SQLiteParameter("@valor_dolares", impuestos.ValorDolares),
                new SQLiteParameter("@valor_aduana", impuestos.ValorAduana),
                new SQLiteParameter("@valor_comercial", impuestos.ValorComercial),
                new SQLiteParameter("@tipo_cambio", impuestos.TipoCambio),
                new SQLiteParameter("@dta", impuestos.Dta),
                new SQLiteParameter("@iva", impuestos.Iva),
                new SQLiteParameter("@prevalidacion", impuestos.Prevalidacion),
                new SQLiteParameter("@iva_prevalidacion", impuestos.IvaPrevalidacion),
                new SQLiteParameter("@igi", impuestos.Igi)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int impuestosId)
        {
            string query = "DELETE FROM Impuestos WHERE impuestos_id = @impuestos_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@impuestos_id", impuestosId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
