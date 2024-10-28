using System;
using System.Data;
using System.Data.SQLite;
using Control_Importaciones.Models;

namespace Control_Importaciones.Data
{
    public class ImportacionService
    {
        private readonly Database _database;

        public ImportacionService(Database database)
        {
            _database = database;
        }

        public void Create(Importacion importacion)
        {
            string query = "INSERT INTO Importacion (proveedor_id, fecha_pago, numero_factura, orden_compra, factura_pdf, packing_list_pdf, guia_pdf) VALUES (@proveedor_id, @fecha_pago, @numero_factura, @orden_compra, @factura_pdf, @packing_list_pdf, @guia_pdf)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@proveedor_id", importacion.ProveedorId),
                new SQLiteParameter("@fecha_pago", importacion.FechaPago),
                new SQLiteParameter("@numero_factura", importacion.NumeroFactura),
                new SQLiteParameter("@orden_compra", importacion.OrdenCompra),
                new SQLiteParameter("@factura_pdf", importacion.FacturaPdf),
                new SQLiteParameter("@packing_list_pdf", importacion.PackingListPdf),
                new SQLiteParameter("@guia_pdf", importacion.GuiaPdf)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public DataTable Read()
        {
            string query = "SELECT * FROM Importacion";
            return _database.ExecuteQuery(query, null);
        }

        public void Update(Importacion importacion)
        {
            string query = "UPDATE Importacion SET proveedor_id = @proveedor_id, fecha_pago = @fecha_pago, numero_factura = @numero_factura, orden_compra = @orden_compra, factura_pdf = @factura_pdf, packing_list_pdf = @packing_list_pdf, guia_pdf = @guia_pdf WHERE importacion_id = @importacion_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@importacion_id", importacion.ImportacionId),
                new SQLiteParameter("@proveedor_id", importacion.ProveedorId),
                new SQLiteParameter("@fecha_pago", importacion.FechaPago),
                new SQLiteParameter("@numero_factura", importacion.NumeroFactura),
                new SQLiteParameter("@orden_compra", importacion.OrdenCompra),
                new SQLiteParameter("@factura_pdf", importacion.FacturaPdf),
                new SQLiteParameter("@packing_list_pdf", importacion.PackingListPdf),
                new SQLiteParameter("@guia_pdf", importacion.GuiaPdf)
            };
            _database.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int importacionId)
        {
            string query = "DELETE FROM Importacion WHERE importacion_id = @importacion_id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@importacion_id", importacionId)
            };
            _database.ExecuteNonQuery(query, parameters);
        }
    }
}
