using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // 電話簿資料清單
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // 讀取 PhoneList.txt 並存入 phoneList 清單
        private void ReadFile()
        {
            try
            {
                // 每一行格式：姓名,電話
                foreach (string line in File.ReadLines("PhoneList.txt"))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        PhoneBookEntry entry = new PhoneBookEntry();
                        entry.name = parts[0].Trim();
                        entry.phone = parts[1].Trim();
                        phoneList.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
            }
        }

        // 顯示所有姓名到 ListBox
        private void DisplayNames()
        {
            nameListBox.Items.Clear();
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        // 表單載入時讀檔並顯示清單
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        // 使用者選取姓名時顯示電話
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1)
            {
                phoneLabel.Text = phoneList[index].phone;
            }
            else
            {
                phoneLabel.Text = "無資料";
            }
        }

        // 關閉按鈕
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

