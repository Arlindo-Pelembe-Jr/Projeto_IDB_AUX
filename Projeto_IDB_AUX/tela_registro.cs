using Projeto_IDB_AUX;
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
    public partial class tela_registro : Form
    {
        public tela_registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (txt_telef.Text.Trim().Length == 0)
            {
                MessageBox.Show("Campo vazio");
                return;

            }
            if (txt_senha.Text.Trim().Length < 8)
            {
                MessageBox.Show("8 carateres nessarios");
                return;

            }
            if (txt_confirm.Text.Trim().Length < 8 && txt_confirm.Text != txt_senha.Text)
            {
                MessageBox.Show("8 carateres nessarios");
                return;

            }
            if (btn_registrar.Text == "Registrar")
            {
                Gerente gere = new Gerente("", txt_email.Text, txt_telef.Text, txt_nome.Text, txt_senha.Text);
                SGBD_Produto.AddGerente(gere);
                //Cleary();

                //this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
