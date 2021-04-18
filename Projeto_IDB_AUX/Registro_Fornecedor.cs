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
    public partial class Registro_Fornecedor : Form
    {
        private readonly Fornecedores _fornecedores;
        public string id, nome, email, telefone,bairro,avenida;

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Cleary();

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim().Length < 4)
            {
                MessageBox.Show("Campo vazio");
                return;
            }
            if (txt_email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (txt_telef.Text.Trim().Length < 1)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (txt_bairro.Text.Trim().Length < 1)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (txt_avenida.Text.Trim().Length < 1)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (btn_registrar.Text == "Registrar")
            {
                Fornecedor_Model fornecedor = new Fornecedor_Model("", txt_nome.Text, txt_bairro.Text, txt_avenida.Text, txt_telef.Text, txt_email.Text);
                SGBD_Produto.AddFornecedor(fornecedor);
                Cleary();

                //this.Close();
            }
            if (btn_registrar.Text == "Editar")
            {
                Fornecedor_Model fornecedor = new Fornecedor_Model("", txt_nome.Text, txt_bairro.Text, txt_avenida.Text, txt_telef.Text, txt_email.Text);
                SGBD_Produto.ActualizarFornecedor(fornecedor, id);
                Cleary();

                //this.Close();
            }
            _fornecedores.Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Registro_Fornecedor(Fornecedores fornecedores)
        {
            InitializeComponent();
            _fornecedores = fornecedores;
        }
        public void editar()
        {
            btn_registrar.Text = "Editar";
            txt_nome.Text = nome;
            txt_email.Text = email;
            txt_avenida.Text = avenida;
            txt_bairro.Text = bairro;
            txt_telef.Text = telefone;
        }
        public void Cleary()
        {
            txt_nome.Text = txt_email.Text = txt_avenida.Text = txt_bairro.Text=txt_telef.Text = string.Empty;
        }
        private void Registro_Fornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
