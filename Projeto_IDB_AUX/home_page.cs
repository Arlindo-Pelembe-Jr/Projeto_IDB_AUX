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
using Projeto_IDB_AUX;

namespace Mercearia_PCSHARP_MZ
{
    public partial class home_page : Form
    {
        Thread t1;
        public home_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(navigateToReg);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void navigateToReg(object obj)
        {
            Application.Run(new tela_registro());
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(navigateToGestao);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
        }
        private void navigateToGestao(object obj)
        {
            Application.Run(new operacoes());

        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }
    }
}
