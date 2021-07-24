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
    public partial class pergunta10 : Form
    {
        Thread p10;

        public pergunta10()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta10_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p10 = new Thread(resultado);
            p10.SetApartmentState(ApartmentState.STA);
            p10.Start();

            total.Acertos = total.Acertos + 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p10 = new Thread(resultado);
            p10.SetApartmentState(ApartmentState.STA);
            p10.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p10 = new Thread(resultado);
            p10.SetApartmentState(ApartmentState.STA);
            p10.Start();

            total.Erros = total.Erros + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p10 = new Thread(resultado);
            p10.SetApartmentState(ApartmentState.STA);
            p10.Start();

            total.Erros = total.Erros + 1;
        }

        private void resultado(object obj)
        {
            Application.Run(new resultado());
        }
    }
}
