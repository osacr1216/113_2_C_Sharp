using System;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // 清空舊的結果
            outputListBox.Items.Clear();

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                // 隨機產生 0 或 1，顯示「正面」或「反面」
                string result = rand.Next(2) == 0 ? "正面" : "反面";
                outputListBox.Items.Add($"第 {i + 1} 次：{result}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}

