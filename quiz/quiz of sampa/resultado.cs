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
    public partial class resultado : Form
    {
        Thread resul;

        public resultado()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultado_Load(object sender, EventArgs e)
        {

        }
        private void Resultado_Load(object sender, EventArgs e)
        {
            label1.Text = "Acertos: "+ total.Acertos.ToString();
            label3.Text = "Erros: " + total.Erros.ToString();
        }

    }
}
