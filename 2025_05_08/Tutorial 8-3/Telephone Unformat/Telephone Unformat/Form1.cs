using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串參數，
        // 並判斷它是否正確地格式化為美國電話號碼，
        // 格式如下：(XXX)XXX-XXXX
        // 如果參數格式正確，方法返回 true，否則返回 false。
        private bool IsValidFormat(string str)
        {
            // 使用正則表達式檢查格式是否為 (XXX)XXX-XXXX
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"^\(\d{3}\)\d{3}-\d{4}$");
        }

        // Unformat 方法接受一個字串（以參考方式傳遞），
        // 假設該字串包含格式化為 (XXX)XXX-XXXX 的電話號碼。
        // 該方法會移除括號和連字符來取消格式化字串。
        private void Unformat(ref string str)
        {
            // 移除括號和連字符
            str = str.Replace("(", "").Replace(")", "").Replace("-", "");
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            // 獲取使用者輸入的電話號碼
            string phoneNumber = phoneNumberTextBox.Text;

            // 檢查格式是否正確
            if (IsValidFormat(phoneNumber))
            {
                // 如果格式正確，取消格式化
                Unformat(ref phoneNumber);

                // 顯示取消格式化後的結果
                phoneNumberTextBox.Text = $"{phoneNumber}";
            }
            else
            {
                // 如果格式不正確，顯示錯誤訊息
                MessageBox.Show("請輸入正確格式的電話號碼：(XXX)XXX-XXXX", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
