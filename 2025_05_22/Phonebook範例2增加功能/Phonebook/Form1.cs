using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        // 定義聯絡人結構
        struct PhoneBookEntry
        {
            public string name;
            public string phone;
        }

        // 儲存所有聯絡人的清單
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void ReadFile()
        {
            try
            {
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
                MessageBox.Show("讀取檔案失敗：" + ex.Message);
            }
        }

        private void DisplayNames()
        {
            nameListBox.Items.Clear();
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newName = nameTextBox.Text.Trim();
            string newPhone = phoneTextBox.Text.Trim();

            if (newName == "" || newPhone == "")
            {
                MessageBox.Show("請輸入姓名與電話！");
                return;
            }

            PhoneBookEntry newEntry = new PhoneBookEntry { name = newName, phone = newPhone };
            phoneList.Add(newEntry);
            nameListBox.Items.Add(newName);

            nameTextBox.Clear();
            phoneTextBox.Clear();
            nameTextBox.Focus();
        }
    }
}

