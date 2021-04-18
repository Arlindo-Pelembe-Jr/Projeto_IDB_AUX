using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Mercearia_PCSHARP_MZ;

namespace Projeto_IDB_AUX
{
    public partial class operacoes : Form
    {
        Thread t1;
        public operacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            t1 = new Thread(navigateToProdutos);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void navigateToProdutos(object obj)
        {
            Application.Run(new tela_gestao());
        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            t1 = new Thread(navigateToFornecedores);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void navigateToFornecedores(object obj)
        {
            Application.Run(new Fornecedores());
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {

            t1 = new Thread(navigateToClientes);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void navigateToClientes(object obj)
        {
            Application.Run(new Cliente());
        }
    }
}
