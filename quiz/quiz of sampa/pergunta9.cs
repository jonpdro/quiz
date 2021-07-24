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
    public partial class pergunta9 : Form
    {
        Thread p9;

        public pergunta9()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p9 = new Thread(pergunta10);
            p9.SetApartmentState(ApartmentState.STA);
            p9.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p9 = new Thread(pergunta10);
            p9.SetApartmentState(ApartmentState.STA);
            p9.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p9 = new Thread(pergunta10);
            p9.SetApartmentState(ApartmentState.STA);
            p9.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p9 = new Thread(pergunta10);
            p9.SetApartmentState(ApartmentState.STA);
            p9.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta9_Load(object sender, EventArgs e)
        {

        }

        private void pergunta10(object obj)
        {
            Application.Run(new pergunta10());
        }
    }
}
