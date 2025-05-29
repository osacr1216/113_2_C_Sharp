using System;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 這個類別用來表示手機的資料
        class CellPhone
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public decimal Price { get; set; }
        }

        // 取得使用者輸入的資料並指派給 CellPhone 物件
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            // 驗證價格格式
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("請輸入正確的價格格式！");
            }
        }

        // 點擊「建立物件」按鈕時
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            // 從表單取得資料
            GetPhoneData(myPhone);

            // 顯示在標籤上
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C");
        }

        // 點擊「離開」按鈕時
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
