using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_PCSHARP_MZ
{
    public partial class Produto_Labels : Form
    {
        private readonly tela_gestao _gestao;
        public string id, nome, preco, categoria;
        public Produto_Labels(tela_gestao gestao)
        {
            InitializeComponent();
            _gestao = gestao;
        }

        public void editar()
        {
            btn_gravar.Text = "Editar";
            txt_nome_prod.Text = nome;
            txt_preco_prod.Text = preco;
            comboBox1.Text = categoria;
        }
        public void Cleary()
        {
            txt_nome_prod.Text = txt_preco_prod.Text = comboBox1.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_nome_prod.Text.Trim().Length < 4)
            {
                MessageBox.Show("Campo vazio");
                return;
            }
            if (txt_preco_prod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (comboBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (btn_gravar.Text == "Gravar")
            {
                Produto_Model prd = new Produto_Model("", comboBox1.Text, txt_nome_prod.Text.Trim(), int.Parse(txt_preco_prod.Text.Trim()));
                SGBD_Produto.AddProduto(prd);
                Cleary();

                //this.Close();
            }
            if (btn_gravar.Text == "Editar")
            {
                Produto_Model prd = new Produto_Model("", comboBox1.Text, txt_nome_prod.Text.Trim(), int.Parse(txt_preco_prod.Text.Trim()));
                SGBD_Produto.ActualizarProduto(prd,id);
                Cleary();

                //this.Close();
            }
            _gestao.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txt_nome_prod.Clear();
            //txt_preco_prod.Clear();
            Cleary();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Produto_Labels_Load(object sender, EventArgs e)
        {

        }

        private void txt_preco_prod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
