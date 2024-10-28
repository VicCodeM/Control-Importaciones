using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Importaciones.Data;
using Control_Importaciones.Models;
using DevExpress.XtraWaitForm;

namespace Control_Importaciones.Forms
{
    public partial class LoginForm : Form
    {
        private readonly Data.Database _database;
        public LoginForm(Data.Database database)
        {
            InitializeComponent();
            _database = database;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Implementar la lógica de autenticación
            // Por ejemplo, consultar la base de datos para verificar las credenciales
            return true; // Placeholder
        }
    }
}
