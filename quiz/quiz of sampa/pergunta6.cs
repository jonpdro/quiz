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
    public partial class pergunta6 : Form
    {
        Thread p6;

        public pergunta6()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta6_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p6 = new Thread(pergunta7);
            p6.SetApartmentState(ApartmentState.STA);
            p6.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p6 = new Thread(pergunta7);
            p6.SetApartmentState(ApartmentState.STA);
            p6.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p6 = new Thread(pergunta7);
            p6.SetApartmentState(ApartmentState.STA);
            p6.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p6 = new Thread(pergunta7);
            p6.SetApartmentState(ApartmentState.STA);
            p6.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta7(object obj)
        {
            Application.Run(new pergunta7());
        }
    }
}
