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
namespace Mercearia_PCSHARP_MZ
{
    public partial class tela_gestao : Form
    {
        Thread t1;
        Produto_Labels tela1;

        public tela_gestao()
        {
            InitializeComponent();
            tela1 = new Produto_Labels(this);
        }

        private void tela_gestao_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto;", dataGridView1);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SGBD_Produto.mostrarEProcurar("select produto_cod,prod_nome, prod_preco_unitario,nome_cat from produto where prod_nome like '%" + txt_search.Text + "%'", dataGridView1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Produto_Labels tela1= new Produto_Labels(this);
            tela1.Cleary();
            tela1.ShowDialog();
            
           // t1 = new Thread(navigateToProduto);
           // t1.SetApartmentState(ApartmentState.MTA);
           // t1.Start();
        }
        private void navigateToProduto(object obj)
        {
            Application.Run(new Produto_Labels(this));
        }

        private void tela_gestao_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == 0)
            //{
            //    //Adicionar
            //    return; 
            //}
            if(e.ColumnIndex == 0)
            {
                //Editar
                tela1.Cleary();
                tela1.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tela1.nome = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tela1.preco = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tela1.editar();
                tela1.ShowDialog();
                Display();

                return;
            }
            if(e.ColumnIndex == 1)
            {
                MessageBox.Show("Dado" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                //Deletar
                if (MessageBox.Show("Deseja Deletar esse produto?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //MessageBox.Show("Dado"+ dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    SGBD_Produto.Deletar(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
