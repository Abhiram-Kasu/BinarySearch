using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        //Method declarations start here
        public int[] generate(int a, int max, int min)
        {
            int[] temp = new int[a];
            Random random = new Random();

            for (int i = 0; i < a; i++) {

                temp[i] = random.Next(min, max);
            
            }

            return temp;
        }

        public Form1()
        {
            InitializeComponent();
            arraytextBox.ReadOnly = true;
        }

       


        private void arrayInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int[] generatedArray = generate(10, 10 ,0 );
            String generatedArrayString = "";
            foreach (int temp in generatedArray) {

                generatedArrayString += temp.ToString();
                generatedArrayString += " , ";
            
            }
            //cleans out the last comma from the string to make it look nice
            generatedArrayString = generatedArrayString.Substring(0, generatedArrayString.Length - 3);
           
            arraytextBox.Text = generatedArrayString;
        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
