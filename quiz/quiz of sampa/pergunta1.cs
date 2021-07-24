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
    public partial class pergunta1 : Form
    {
        Thread p1;

        public pergunta1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p1 = new Thread(pergunta2);
            p1.SetApartmentState(ApartmentState.STA);
            p1.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void pergunta1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p1 = new Thread(pergunta2);
            p1.SetApartmentState(ApartmentState.STA);
            p1.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p1 = new Thread(pergunta2);
            p1.SetApartmentState(ApartmentState.STA);
            p1.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p1 = new Thread(pergunta2);
            p1.SetApartmentState(ApartmentState.STA);
            p1.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta2(object obj)
        {
            Application.Run(new pergunta2());
        }
    }
}
