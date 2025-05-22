namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label selectedPhoneDescriptionLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label nameInputLabel;
        private System.Windows.Forms.Label phoneInputLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button addButton;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">是否要釋放 Managed 資源</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// 設計工具支援的方法
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedPhoneDescriptionLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.nameInputLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneInputLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();

            // Form 設定
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.Form1_Load);

            // promptLabel
            this.promptLabel.AutoSize = true;
            this.promptLabel.Text = "請選擇姓名";
            this.promptLabel.Location = new System.Drawing.Point(30, 10);

            // nameListBox
            this.nameListBox.Location = new System.Drawing.Point(20, 30);
            this.nameListBox.Size = new System.Drawing.Size(120, 100);
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);

            // selectedPhoneDescriptionLabel
            this.selectedPhoneDescriptionLabel.AutoSize = true;
            this.selectedPhoneDescriptionLabel.Text = "電話號碼";
            this.selectedPhoneDescriptionLabel.Location = new System.Drawing.Point(160, 40);

            // phoneLabel
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Location = new System.Drawing.Point(160, 60);
            this.phoneLabel.Size = new System.Drawing.Size(120, 23);
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // exitButton
            this.exitButton.Text = "離開";
            this.exitButton.Location = new System.Drawing.Point(100, 150);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // groupBoxAdd
            this.groupBoxAdd.Text = "新增通訊錄";
            this.groupBoxAdd.Location = new System.Drawing.Point(300, 20);
            this.groupBoxAdd.Size = new System.Drawing.Size(160, 130);

            // nameInputLabel
            this.nameInputLabel.Text = "姓名";
            this.nameInputLabel.Location = new System.Drawing.Point(10, 25);
            this.nameInputLabel.AutoSize = true;

            // nameTextBox
            this.nameTextBox.Location = new System.Drawing.Point(50, 20);
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);

            // phoneInputLabel
            this.phoneInputLabel.Text = "電話";
            this.phoneInputLabel.Location = new System.Drawing.Point(10, 55);
            this.phoneInputLabel.AutoSize = true;

            // phoneTextBox
            this.phoneTextBox.Location = new System.Drawing.Point(50, 50);
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);

            // addButton
            this.addButton.Text = "加入";
            this.addButton.Location = new System.Drawing.Point(40, 85);
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // groupBox 加入控制項
            this.groupBoxAdd.Controls.Add(this.nameInputLabel);
            this.groupBoxAdd.Controls.Add(this.nameTextBox);
            this.groupBoxAdd.Controls.Add(this.phoneInputLabel);
            this.groupBoxAdd.Controls.Add(this.phoneTextBox);
            this.groupBoxAdd.Controls.Add(this.addButton);

            // 表單加入所有控制項
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.selectedPhoneDescriptionLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBoxAdd);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
