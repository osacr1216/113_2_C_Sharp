using System;
using System.Linq;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber 方法接受一個字串並返回 true，
        // 如果該字串包含 10 個數字，否則返回 false。
        private bool IsValidNumber(string str)
        {
            // 檢查字串是否為 10 個數字
            return str.Length == 10 && str.All(char.IsDigit);
        }

        // TelephoneFormat 方法接受一個字串參數（以引用方式傳遞），
        // 並將其格式化為電話號碼。
        private void TelephoneFormat(ref string str)
        {
            if (str.Length == 10)
            {
                // 格式化為 (XXX) XXX-XXXX
                str = $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6)}";
            }
        }

        // formatButton 的點擊事件處理程式
        private void formatButton_Click(object sender, EventArgs e)
        {
            // 從輸入框中獲取用戶輸入
            string input = resultLabel.Text.Trim();

            // 檢查輸入是否為空
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("請輸入一個 10 位數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查輸入是否有效
            if (IsValidNumber(input))
            {
                // 格式化電話號碼
                TelephoneFormat(ref input);

                // 顯示格式化後的電話號碼
                resultLabel.Text = input;
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入一個有效的 10 位數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // exitButton 的點擊事件處理程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {
            // 此處可根據需要添加功能
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            // 此處可根據需要添加功能
        }
    }
}