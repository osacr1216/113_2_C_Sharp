using System;
using System.IO;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定視窗標題與按鈕文字
            this.Text = "CSV 讀取器";
            getScoresButton.Text = "取得分數";
            exitButton.Text = "離開";
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            averagesListBox.Items.Clear();

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV 檔案 (*.csv)|*.csv";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFile.FileName))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            line = line.Trim();
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            string[] scores = line.Split(',');
                            double total = 0;
                            int validCount = 0;

                            foreach (string scoreStr in scores)
                            {
                                if (int.TryParse(scoreStr.Trim(), out int score))
                                {
                                    total += score;
                                    validCount++;
                                }
                            }

                            if (validCount > 0)
                            {
                                double average = total / validCount;
                                averagesListBox.Items.Add($"平均分數為：{average:F2}");
                            }
                            else
                            {
                                averagesListBox.Items.Add("資料格式錯誤");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
                }
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉表單
        }

        private void averagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 未使用，可保留以供未來擴充
        }
    }
}


