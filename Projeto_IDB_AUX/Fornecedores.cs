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
    public partial class Fornecedores : Form
    {
        Registro_Fornecedor tela1;

        public Fornecedores()
        {
            InitializeComponent();
            tela1 = new Registro_Fornecedor(this);

        }


        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select fornecedor_cod,forn_nome,forn_bairro,forn_avenida,forn_telefone,forn_email from fornecedor;", dataGridView);

        }
        private void btn_novo_forn_Click(object sender, EventArgs e)
        {
            tela1.Cleary();
            tela1.ShowDialog();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SGBD_Produto.mostrarEProcurar("select fornecedor_cod,forn_nome,forn_bairro,forn_avenida,forn_telefone,forn_email from fornecedor where forn_nome like '%" + txt_search.Text + "%'", dataGridView);

        }

        private void Fornecedores_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Adicionar
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Editar
                tela1.Cleary();
                tela1.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tela1.nome = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                tela1.bairro = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                tela1.avenida = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                tela1.telefone = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                tela1.email = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                tela1.editar();
                tela1.ShowDialog();
                Display();

                return;
            }
            if (e.ColumnIndex == 2)
            {
                MessageBox.Show("Dado" + dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

                //Deletar
                if (MessageBox.Show("Deseja Deletar esse produto?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //MessageBox.Show("Dado"+ dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    SGBD_Produto.Deletar(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
