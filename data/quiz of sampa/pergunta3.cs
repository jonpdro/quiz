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
    public partial class pergunta3 : Form
    {
        Thread p3;

        public pergunta3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p3 = new Thread(pergunta4);
            p3.SetApartmentState(ApartmentState.STA);
            p3.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p3 = new Thread(pergunta4);
            p3.SetApartmentState(ApartmentState.STA);
            p3.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p3 = new Thread(pergunta4);
            p3.SetApartmentState(ApartmentState.STA);
            p3.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p3 = new Thread(pergunta4);
            p3.SetApartmentState(ApartmentState.STA);
            p3.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void pergunta4(object obj)
        {
            Application.Run(new pergunta4());
        }
    }
}
