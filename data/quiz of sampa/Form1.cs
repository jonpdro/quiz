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
    public partial class Form1 : Form
    {
        Thread inicio;

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            inicio = new Thread(pergunta1);
            inicio.SetApartmentState(ApartmentState.STA);
            inicio.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pergunta1(object obj)
        {
            Application.Run(new pergunta1());
        }
    }
}
