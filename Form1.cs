using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.Height = pnlFoods.Height;
            //btnFood.Top = pnlFoods.Top;
            pnlFoods.Visible = true;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlAbtUs.Visible = false;
            pnlCart.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //btnDrinks.Height = pnlDrinks.Height;
            //btnDrinks.Top = pnlDrinks.Top;
            pnlFoods.Visible = false;
            pnlDrinks.Visible = true;
            pnlDesserts.Visible = false;
            pnlAbtUs.Visible = false;
            pnlCart.Visible = false;
        }

        private void pnlFoods_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlAbtUs.Visible = false;
            pnlCart.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = true;
            pnlAbtUs.Visible = false;
            pnlCart.Visible = false;
        }

        private void btnABTS_Click(object sender, EventArgs e)
        {
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlAbtUs.Visible = true;
            pnlCart.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
