using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
           const int SIZE = 5; 
            int[] lotterynumbers = new int[SIZE];
            Random rand = new Random();

            for (int i = 0; i < lotterynumbers.Length; i++)
            {
               int number;
                do
                {
                    number = rand.Next(1, 43);
                } while (lotterynumbers.Contains(number));
                lotterynumbers[i] = number;
            }

            //將lotterynumbers 陣列中的數字由大到小排序
            Array.Sort(lotterynumbers);

            //firstLabel.Text  = lotterynumbers[0].ToString();
            //secondLabel.Text = lotterynumbers[1].ToString();
            //thirdLabel.Text  = lotterynumbers[2].ToString();
            //fourthLabel.Text = lotterynumbers[3].ToString();
            //fifthLabel.Text  = lotterynumbers[4].ToString();

            Label[] showlabels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < showlabels.Length; i++)
            {
                showlabels[i].Text = lotterynumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
