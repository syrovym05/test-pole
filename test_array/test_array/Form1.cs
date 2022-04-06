using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            int[] pole = new int[n];
            int[] pole2 = pole;

            Random rnd = new Random();

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(32, 128);
                char znak = Convert.ToChar(pole[i]);
                listBox1.Items.Add(znak);
                
            }
            int t = 5;
            int prvni, posledni;
            prvni = Array.IndexOf(pole2, 87)+1;
            posledni = Array.LastIndexOf(pole2, 87)+1;
            label4.Text = "Prvni vyskkyt W je na pozici: " + prvni;
            label5.Text = "Posledni vyskkyt W je na pozici: " + posledni;

            for (int i = 0; i < pole2.Length; i++)
            {

                if ((pole2[i] >= 48 && pole2[i] <= 57) || (pole2[i] >= 65 && pole2[i] <= 90) || (pole2[i] >= 97 && pole2[i] <= 122))
                {
                    // textBox1.Lines[i] = znak;   //nefunguje                                               
                }

            }

            int[] pole3 = pole.Distinct().ToArray();
            
            pole3 = Array.Sort(pole3);
            pole3 = pole.Reverse().ToArray();

            for (int i = 0; i < pole3.Length; i++)
            {
                char znak = Convert.ToChar(pole[i]);
                
                listBox2.Items.Add(znak);
            }


        

        }
    }
}
