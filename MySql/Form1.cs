using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const string servidor = "localhost";
                const string bancoDados = "dbForm";
                const string usuario = "root";
                const string senha = "kiraFE22022006";

                string conexao = $"server={servidor}; user id={usuario};database={bancoDados};password={senha}";

                lbltext.Text = $"A conexão com o banco {bancoDados} deu certo";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }
    }
}
