using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            //try
            //{
                int A = System.Convert.ToInt32(txtA.Text);
                int B = System.Convert.ToInt32(txtB.Text);

                int Res = A + B;

                lblResultado.Text = System.Convert.ToString(Res); //  Res.ToString();
            //}
            //catch (FormatException er)
            //{
            //    lblResultado.Text = "Dato incorrecto, algún sumando no es un número entero";
            //}
            //catch (Exception er)
            //{
            //    lblResultado.Text = er.Message;
            //}
        }
    }
}
