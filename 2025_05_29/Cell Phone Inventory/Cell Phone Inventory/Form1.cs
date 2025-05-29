using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // 將使用者輸入的資料填入 CellPhone 物件中
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("價格格式不正確");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();
            GetPhoneData(phone);

            if (phone.Price > 0)
            {
                phoneList.Add(phone);
                phoneListBox.Items.Add(phone);

                brandTextBox.Clear();
                modelTextBox.Clear();
                priceTextBox.Clear();
                brandTextBox.Focus();
            }
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;
            if (index != -1)
            {
                CellPhone selectedPhone = phoneList[index];
                MessageBox.Show($"品牌：{selectedPhone.Brand}\n型號：{selectedPhone.Model}\n價格：{selectedPhone.Price:C}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

