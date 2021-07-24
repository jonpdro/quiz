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
    public partial class pergunta7 : Form
    {
        Thread p7;

        public pergunta7()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta8(object obj)
        {
            Application.Run(new pergunta8());
        }

        private void pergunta7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            p7 = new Thread(pergunta8);
            p7.SetApartmentState(ApartmentState.STA);
            p7.Start();

            total.Acertos = total.Acertos + 1;
        }
    }
}
