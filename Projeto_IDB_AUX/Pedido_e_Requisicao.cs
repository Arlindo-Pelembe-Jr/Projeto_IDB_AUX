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
    public partial class Pedido_e_Requisicao : Form
    {
        public Pedido_e_Requisicao()
        {
            InitializeComponent();
        }

        private void Pedido_e_Requisicao_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select  pedido_cod,cod_cliente,cod_gerente,ped_quantidade,ped_data,ped_dia_de_entrega from pedido;", dataGridView1);

            SGBD_Produto.mostrarEProcurar("select nr_requisicao,cod_gerente,cod_produto,data_requisicao from requisicao;", dataGridView2);

        }

        private void Pedido_e_Requisicao_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
