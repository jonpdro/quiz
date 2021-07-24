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
    public partial class pergunta5 : Form
    {
        Thread p5;

        public pergunta5()      
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void pergunta5_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p5 = new Thread(pergunta6);
            p5.SetApartmentState(ApartmentState.STA);
            p5.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            p5 = new Thread(pergunta6);
            p5.SetApartmentState(ApartmentState.STA);
            p5.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            p5 = new Thread(pergunta6);
            p5.SetApartmentState(ApartmentState.STA);
            p5.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            p5 = new Thread(pergunta6);
            p5.SetApartmentState(ApartmentState.STA);
            p5.Start();
        }

        private void pergunta6(object obj)
        {
            Application.Run(new pergunta6());
        }
    }
}
