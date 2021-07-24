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
    public partial class pergunta8 : Form
    {
        Thread p8;

        public pergunta8()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p8 = new Thread(pergunta9);
            p8.SetApartmentState(ApartmentState.STA);
            p8.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p8 = new Thread(pergunta9);
            p8.SetApartmentState(ApartmentState.STA);
            p8.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p8 = new Thread(pergunta9);
            p8.SetApartmentState(ApartmentState.STA);
            p8.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p8 = new Thread(pergunta9);
            p8.SetApartmentState(ApartmentState.STA);
            p8.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void pergunta9(object obj)
        {
            Application.Run(new pergunta9());
        }

    }
}
