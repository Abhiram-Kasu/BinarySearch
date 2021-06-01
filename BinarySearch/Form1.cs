using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class BinarySearch : Form
    {
        //Method declarations start here
        public int[] generate(int a, int max, int min)
        {
            int[] temp = new int[a];
            Random random = new Random();
            int randominteger;

            for (int i = 0; i < a;) {
                randominteger = random.Next(min, max);
                if (i == 0 || randominteger != temp[i - 1])
                {

                    temp[i] = randominteger;
                    i++;
                }
                else {

                   
                }
            }

            return temp;
        }

        public BinarySearch()
        {
            InitializeComponent();
            arraytextBox.ReadOnly = true;
            updater = this;
            
        }
        public static BinarySearch updater;

        //Derclaring variables
        int[] generatedArray;
        String generatedArrayString = "";


        public void update(String message)
        {
            consoleOutput.Text += message;
        }

        private void arrayInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                generatedArray = generate(int.Parse(arraySize.Text), int.Parse(arrayMax.Text), 0);
            }
            catch (System.FormatException) {
                MessageBox.Show("You didnt enter in the Max and Size of the aray ");
            
            }
            try
            {
                Array.Sort(generatedArray);
            }
            catch (System.ArgumentNullException) {
                MessageBox.Show("You did not enter in values for the Max and Length of the array");
            }
            try
            {
                foreach (int temp in generatedArray)
                {

                    generatedArrayString += temp.ToString();
                    generatedArrayString += " , ";

                }
            }catch (System.NullReferenceException) {

                MessageBox.Show("No values in the Max and Length boxes");
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
            try {
                Searcher searcher = new Searcher(generatedArray, int.Parse(arrayInput.Text));
            
            String Data;
            String found = searcher.returnBoolean().ToString();
            String index = searcher.returnIndex().ToString();
            String runtime = searcher.returnRuntime();

            
            if (!searcher.returnBoolean())
            {
                Data = "Was the Integer found?: " + found;
            }
            else {


                Data = "Was the Integer found?: " + found + "\r\nIndex of target found: " + index + "\r\nRuntime of the search in nanoseconds: " + runtime;
            
            
            }
            //not used anymore
            /*consoleOutput.Text += searcher.returnDebugStatements();*/
            output.Text = Data;
            }
            catch (System.FormatException) {
                
                MessageBox.Show("you didnt enter an item to search");
            
            }




        }

        public void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void downloadArray_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            desktopPath += @"\array.txt";
            try
            {
                
                File.WriteAllText(desktopPath, generatedArrayString);
                Clipboard.SetText(desktopPath);
                MessageBox.Show("File downloaded to: " + desktopPath + "\nThe path is copyed to your clipboard");
            }
            catch (System.IO.IOException) {
                MessageBox.Show("Could not create or write to file for some reasons");
            
            }
        }

        private void arraySize_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }
        //To Look nice
        /*private void generateButton_Hover(object sender, EventArgs e) {

            generateButton.Size.Width(60,70);
        
        }*/

    }
}
