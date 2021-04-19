using Mercearia_PCSHARP_MZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_IDB_AUX
{
    public partial class Fornecimentos : Form
    {
        public Fornecimentos()
        {
            InitializeComponent();
        }

        private void Fronecimentos_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select   cod_fornecedor,cod_produto,forn_quantidade from fornecimento;", dataGridView1);


        }

        private void Fronecimentos_Shown(object sender, EventArgs e)
        {
            Display();

        }
    }
}
