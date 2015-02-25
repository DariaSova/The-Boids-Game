using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Program
    {
        public static void Checkelement(ref int[] arrx, ref int[] arry, ref int i)
        {
            int j;
            for (j = i + 1; j <= 4; j++)
            {
                if (arrx[i] == arrx[j] && arry[i] == arry[j])
                { arry[i] += 2; }
                else { }
            }
            for (j = i - 1; j >= 0; j--)
            {
                if (arrx[i] == arrx[j] && arry[i] == arry[j])
                { arry[i] += 2; }
                else { }
            }
        }

        public static void ObjectGeneration(ref string k)
        {
            int i = 0, j = 0;
            int[] arrx = new int[5];           //array х and у 
            int[] arry = new int[5];
            Random rnd = new Random();
            int tempx = 0;
            int tempy = 0;
            int temparrx = 0, temparry = 0;

            for (i = 0; i <= 4; i++)//random generation of 5 first initial objects (points)
            {
                arrx[i] = rnd.Next(-50, 50);
                arry[i] = rnd.Next(-50, 50);
                Checkelement(ref arry, ref arrx, ref i);///check if such a point already exists
                listBox1.Items.Add(k + "x" + (i + 1) + "=" + arrx[i]);
                Console.WriteLine(k + "y" + (i + 1) + "=" + arry[i]);
                Console.WriteLine();

            }
            Console.WriteLine("\n");

            for (i = 0; i <= 0; i++)//first object randomly is sent within radius 10
            {
                tempx = rnd.Next(-10, 10);
                arrx[i] = arrx[i] + tempx;
                Console.WriteLine(k + "x" + (i + 1) + "=" + arrx[i]);
                for (j = 0; j <= 0; j++)
                {
                    tempy = rnd.Next(-10, 10);
                    arry[j] = arry[j] + tempy;
                    Checkelement(ref arry, ref arrx, ref i);//check for existence
                    Console.WriteLine(k + "y" + (j + 1) + "=" + arry[j]);
                }
                Console.WriteLine();
            }

            for (i = 1; i <= 1; i++)
            {
                if (tempx < 0)
                {
                    arrx[i] = arrx[i] + rnd.Next(-10, 0);
                    Console.WriteLine(k + "x" + (i + 1) + "=" + arrx[i]);
                }
                else
                {
                    arrx[i] = arrx[i] + rnd.Next(0, 10);
                    Console.WriteLine(k + "x" + (i + 1) + "=" + arrx[i]);
                }

                if (tempy < 0)
                {
                    arry[i] = arry[i] + rnd.Next(-10, 0);
                    Checkelement(ref arry, ref arrx, ref i);///check for existence
                    Console.WriteLine(k + "y" + (i + 1) + "=" + arry[i]);
                    Console.WriteLine();
                }
                else
                {
                    arry[i] = arry[i] + rnd.Next(0, 10);
                    Checkelement(ref arry, ref arrx, ref i);
                    Console.WriteLine(k + "y" + (i + 1) + "=" + arry[i]);
                    Console.WriteLine();
                }
            }

            for (i = 2; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (j == i)
                    {
                        temparrx = temparrx + 0;
                        temparry = temparry + 0;
                    }
                    else
                    {
                        temparrx = temparrx + (arrx[j] - arrx[i]);
                        temparry = temparry + (arry[j] - arry[i]);
                    }
                }
                arrx[i] = arrx[i] + temparrx / 4;
                arry[i] = arry[i] + temparry / 4;
                Checkelement(ref arry, ref arrx, ref i);
                Console.WriteLine(k + "x" + (i + 1) + "=" + arrx[i]);
                Console.WriteLine(k + "y" + (i + 1) + "=" + arry[i]);
                Console.WriteLine();

            }
        }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
