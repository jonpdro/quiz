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

namespace quiz_of_sampa
{
    public partial class pergunta2 : Form
    {
        Thread p2;

        public pergunta2()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta2_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p2 = new Thread(pergunta3);
            p2.SetApartmentState(ApartmentState.STA);
            p2.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p2 = new Thread(pergunta3);
            p2.SetApartmentState(ApartmentState.STA);
            p2.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p2 = new Thread(pergunta3);
            p2.SetApartmentState(ApartmentState.STA);
            p2.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p2 = new Thread(pergunta3);
            p2.SetApartmentState(ApartmentState.STA);
            p2.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta3(object obj)
        {
            Application.Run(new pergunta3());
        }
    }
}
