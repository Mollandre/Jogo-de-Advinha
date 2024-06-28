using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Jogo_de_Advinha
{
    public partial class Form1 : Form
    {


        public int n, escolha = 0, cont = 0;
        public int chance = 0;

        Random segredo = new Random();




        int valor = 0;
        Point ponto = new Point(10, 200);

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {





            if (textBox1.Text == n.ToString())
            {

                label2.Text = "Sorteado é " + n;
                label6.Text = "Aperte Sortear para Começar de novo";
                Confirma.Visible = false;
                textBox1.Clear();
            }
            if (cont == chance)
            {
                label1.Text = "Você Perdeu, O numero";
                label2.Text = "Sorteado é " + n;
                label6.Text = "Aperte Sorteio para Começar de novo";
                Confirma.Visible = false;
                textBox1.Clear();
            }



            while (textBox1.Text != n.ToString())
            {



                if (textBox1.Text == "")
                {
                    label1.Text = "Você Ganhou, O numero";
                }
                else
                {

                    if (int.Parse(textBox1.Text) > n)
                    {
                        label1.Text = "Errado. O número é menor.";
                    }

                    if (int.Parse(textBox1.Text) < n)
                    {
                        label1.Text = "Errado. O número é maior.";
                    }
                    textBox1.Clear();
                }

                cont++;
                return;
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Jogo do Adivinha";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            facil.Visible = true;
            medio.Visible = true;
            dificil.Visible = true;
            n = Convert.ToInt32(segredo.Next(1, 10));
            label1.Text = "";
            label2.Text = "";
            label6.Text = "";
            label7.Text = "Escolha um nivel abaixo";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void facil_Click(object sender, EventArgs e)
        {

            chance = 6;
            facil.Visible = false;
            medio.Visible = false;
            medio.Visible = false;
            Confirma.Visible = true;
            label7.Visible = false;
        }

        private void medio_Click(object sender, EventArgs e)
        {
            chance = 4;
            facil.Visible = false;
            medio.Visible = false;
            dificil.Visible = false;
            Confirma.Visible = true;
            label7.Visible = false;
        }

        private void dificil_Click(object sender, EventArgs e)
        {
            chance = 2;
            facil.Visible = false;
            medio.Visible = false;
            dificil.Visible = false;
            Confirma.Visible = true;
            label7.Visible = false;
        }
    }
}
