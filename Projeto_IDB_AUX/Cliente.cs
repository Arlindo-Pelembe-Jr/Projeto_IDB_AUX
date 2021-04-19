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
    public partial class Cliente : Form
    {
        Registro_Clientes tela1;

        public Cliente()
        {
            InitializeComponent();
            tela1 = new Registro_Clientes(this);

        }

        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select cliente_cod,cli_nome,cli_bairro,cli_avenida,cli_telefone,cli_email from cliente;", dataGridView1);

        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            Display();

        }

        private void btn_novo_cliente_Click(object sender, EventArgs e)
        {
            tela1.Cleary();
            tela1.ShowDialog();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SGBD_Produto.mostrarEProcurar("select cliente_cod,cli_nome,cli_bairro,cli_avenida,cli_telefone,cli_email from cliente where cli_nome like '%" + txt_search.Text + "%'", dataGridView1);

        }

        private void Cliente_Shown(object sender, EventArgs e)
        {
            Display();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Adicionar
                Requisicao requisicao = new Requisicao(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                requisicao.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Editar
                tela1.Cleary();
                tela1.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tela1.nome = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tela1.bairro = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tela1.avenida = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tela1.telefone = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tela1.email = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                tela1.editar();
                tela1.ShowDialog();
                Display();

                return;
            }
            
                return;
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ped_req_Click(object sender, EventArgs e)
        {
            Pedido_e_Requisicao pedido_E_Requisicao = new Pedido_e_Requisicao();
            pedido_E_Requisicao.ShowDialog();
        }
    }
    }

