using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Car_List
{
    // 定義汽車結構
    struct Automobile
    {
        public string make;      // 車款
        public int year;         // 年份
        public double mileage;   // 里程數
    }

    public partial class Form1 : Form
    {
        // 宣告一個車輛清單
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();
        }

        // 取得使用者輸入資料，並賦值給參數物件
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從文字方塊取得資料
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("輸入錯誤：" + ex.Message);
            }
        }

        // 新增按鈕事件：將使用者輸入的汽車加入清單
        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立汽車物件
            Automobile car = new Automobile();

            // 取得使用者輸入
            GetData(ref car);

            // 加入到清單
            carList.Add(car);

            // 清空輸入框
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 將焦點設回車款輸入框
            makeTextBox.Focus();
        }

        // 顯示按鈕事件：將所有汽車顯示在 ListBox
        private void displayButton_Click(object sender, EventArgs e)
        {
            string output; // 宣告輸出文字

            // 清空目前 ListBox 內容
            carListBox.Items.Clear();

            // 將所有汽車資訊顯示出來
            foreach (Automobile aCar in carList)
            {
                output = aCar.year + " 年 " + aCar.make +
                    "，里程數：" + aCar.mileage + " 英里。";

                carListBox.Items.Add(output);
            }
        }
    }
}
