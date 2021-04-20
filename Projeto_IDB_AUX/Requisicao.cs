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
    public partial class Requisicao : Form
    {
        public Requisicao(string cli_id,string cli_nome)
        {
            InitializeComponent();
            txt_id_cli.Text = cli_id;
            txt_nome_cli.Text = cli_nome;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Adicionar
                
                txt_prod_id.Text= dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prod_nome.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                return;
            }
            //if (e.ColumnIndex == 1)
            //{
            //    //Editar
            //    tela1.Cleary();
            //    tela1.id = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    tela1.nome = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    tela1.preco = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    tela1.editar();
            //    tela1.ShowDialog();
            //    Display();

            //    return;
            //}
            //if (e.ColumnIndex == 2)
            //{
                //MessageBox.Show("Dado" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                ////Deletar
                //if (MessageBox.Show("Deseja Deletar esse produto?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                //{
                //    //int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                //    //MessageBox.Show("Dado"+ dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                //    SGBD_Produto.Deletar(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                //    Display();
                //}
                //return;
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto where prod_nome like '%" + txt_search.Text + "%'", dataGridView2);

        }

        private void Requisicao_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto;", dataGridView2);
        }

        private void Requisicao_Shown(object sender, EventArgs e)
        {
            Display();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            // Produto_Model prd = new Produto_Model("", comboBox1.Text, txt_nome_prod.Text.Trim(), int.Parse(txt_preco_prod.Text.Trim()));
            //  SGBD_Produto.AddProduto(prd);
            requisicao_model req = new requisicao_model("","1",txt_prod_id.Text,"");
            SGBD_Produto.AddRequisicao(req);
            pedido_model ped = new pedido_model("","1",txt_id_cli.Text,"",txt_qtd.Text,txt_data_entrega.Text);
            SGBD_Produto.AddPedido(ped);
            Cleary();
        }
        public void Cleary()
        {
            txt_prod_nome.Text = txt_prod_id.Text = txt_id_cli.Text= txt_nome_cli.Text=txt_qtd.Text=txt_search.Text = string.Empty;
        }

        private void btn_ped_req_Click(object sender, EventArgs e)
        {
            Pedido_e_Requisicao pedido_E_Requisicao = new Pedido_e_Requisicao();
            pedido_E_Requisicao.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

