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
    public partial class pergunta4 : Form
    {
        Thread p4;

        public pergunta4()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p4 = new Thread(pergunta5);
            p4.SetApartmentState(ApartmentState.STA);
            p4.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p4 = new Thread(pergunta5);
            p4.SetApartmentState(ApartmentState.STA);
            p4.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p4 = new Thread(pergunta5);
            p4.SetApartmentState(ApartmentState.STA);
            p4.Start();

            total.Erros = total.Erros + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p4 = new Thread(pergunta5);
            p4.SetApartmentState(ApartmentState.STA);
            p4.Start();

            total.Erros = total.Erros + 1;
        }

        private void pergunta5(object obj)
        {
            Application.Run(new pergunta5());
        }
    }
}
