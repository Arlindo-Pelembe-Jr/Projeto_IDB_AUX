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
    public partial class Registro_Clientes : Form
    {
        private readonly Cliente _cliente;
        public string id, nome, email, telefone, bairro, avenida;

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
                Cliente_Model clientes = new Cliente_Model("", txt_nome.Text, txt_bairro.Text, txt_avenida.Text, txt_telef.Text, txt_email.Text);
                SGBD_Produto.AddCliente(clientes);
                Cleary();

                //this.Close();
            }
            if (btn_registrar.Text == "Editar")
            {
                Cliente_Model clientes = new Cliente_Model("", txt_nome.Text, txt_bairro.Text, txt_avenida.Text, txt_telef.Text, txt_email.Text);
                SGBD_Produto.ActualizarCliente(clientes, id);
                Cleary();

                //this.Close();
            }
            _cliente.Display();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Cleary();

        }

        public Registro_Clientes(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
        }

        private void Registro_Clientes_Load(object sender, EventArgs e)
        {

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
            txt_nome.Text = txt_email.Text = txt_avenida.Text = txt_bairro.Text = txt_telef.Text = string.Empty;
        }
    }
}
