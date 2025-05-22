using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{
    // 光譜列舉型別
    enum Spectrum
    {
        Red, Orange, Yellow, Green,
        Blue, Indigo, Violet
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 顯示顏色名稱的方法
        private void DisplayColor(Spectrum color)
        {
            // 將列舉轉成文字顯示
            colorLabel.Text = GetColorNameInChinese(color);
        }

        // 轉換為中文顏色名稱
        private string GetColorNameInChinese(Spectrum color)
        {
            switch (color)
            {
                case Spectrum.Red: return "紅色";
                case Spectrum.Orange: return "橘色";
                case Spectrum.Yellow: return "黃色";
                case Spectrum.Green: return "綠色";
                case Spectrum.Blue: return "藍色";
                case Spectrum.Indigo: return "靛色";
                case Spectrum.Violet: return "紫色";
                default: return "未知顏色";
            }
        }

        // 以下為各個標籤點擊事件
        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
