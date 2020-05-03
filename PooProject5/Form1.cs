using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooProject5
{
    public partial class Form1 : Form
    {
        Image dado;
        string[] ListaDados = new string[6];

        public Form1()
        {
            InitializeComponent();
            //prueba
        }

        private void botonLanzar_Click(object sender, EventArgs e)
        {
            tiradas();
            dado = Image.FromFile("dd1.png");
            pic1.Image = dado;

        }
        private void tiradas()
        {

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(0, 5);

        }
    }
}