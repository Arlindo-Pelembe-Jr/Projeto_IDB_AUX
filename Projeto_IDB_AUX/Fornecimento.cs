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
    public partial class Fornecimento : Form
    {
        public Fornecimento(string forn_id, string forn_nome)
        {
            InitializeComponent();
            txt_id_forn.Text = forn_id;
            txt_nome_forn.Text = forn_nome;
        }

        private void Fornecimento_Load(object sender, EventArgs e)
        {
            Display();

        }
        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto;", dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Adicionar

                txt_prod_id.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_prod_nome.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto where prod_nome like '%" + txt_search.Text + "%'", dataGridView2);

        }

        private void Fornecimento_Shown(object sender, EventArgs e)
        {
            Display();

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Fornecimento_Model fornecimento = new Fornecimento_Model(txt_id_forn.Text, txt_prod_id.Text, txt_qtd.Text);
            SGBD_Produto.AddFornecimento(fornecimento);
            //Cleary();
        }
        public void Cleary()
        {
            txt_prod_nome.Text = txt_prod_id.Text = txt_id_forn.Text = txt_nome_forn.Text = txt_qtd.Text = txt_search.Text = string.Empty;
        }
    }
}
