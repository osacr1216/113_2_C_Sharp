﻿namespace Cell_Phone_Test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputBrandLabel = new System.Windows.Forms.Label();
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.objectPropertiesGroupBox.SuspendLayout();
            this.enterDataGroupBox.SuspendLayout();
            this.SuspendLayout();

            // exitButton
            this.exitButton.Location = new System.Drawing.Point(130, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // createObjectButton
            this.createObjectButton.Location = new System.Drawing.Point(49, 254);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(75, 41);
            this.createObjectButton.TabIndex = 6;
            this.createObjectButton.Text = "建立物件";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);

            // objectPropertiesGroupBox
            this.objectPropertiesGroupBox.Controls.Add(this.priceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.modelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.brandLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputPriceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputModelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputBrandLabel);
            this.objectPropertiesGroupBox.Location = new System.Drawing.Point(34, 118);
            this.objectPropertiesGroupBox.Name = "objectPropertiesGroupBox";
            this.objectPropertiesGroupBox.Size = new System.Drawing.Size(186, 124);
            this.objectPropertiesGroupBox.TabIndex = 5;
            this.objectPropertiesGroupBox.TabStop = false;
            this.objectPropertiesGroupBox.Text = "手機屬性";

            // priceLabel
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(59, 85);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // modelLabel
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Location = new System.Drawing.Point(59, 55);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(100, 23);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // brandLabel
            this.brandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandLabel.Location = new System.Drawing.Point(59, 25);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(100, 23);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // outputPriceLabel
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Location = new System.Drawing.Point(22, 90);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(41, 13);
            this.outputPriceLabel.TabIndex = 5;
            this.outputPriceLabel.Text = "價格：";

            // outputModelLabel
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Location = new System.Drawing.Point(17, 60);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(41, 13);
            this.outputModelLabel.TabIndex = 4;
            this.outputModelLabel.Text = "型號：";

            // outputBrandLabel
            this.outputBrandLabel.AutoSize = true;
            this.outputBrandLabel.Location = new System.Drawing.Point(18, 29);
            this.outputBrandLabel.Name = "outputBrandLabel";
            this.outputBrandLabel.Size = new System.Drawing.Size(41, 13);
            this.outputBrandLabel.TabIndex = 3;
            this.outputBrandLabel.Text = "品牌：";

            // enterDataGroupBox
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Location = new System.Drawing.Point(34, 12);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(186, 100);
            this.enterDataGroupBox.TabIndex = 4;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料";

            // priceTextBox
            this.priceTextBox.Location = new System.Drawing.Point(62, 74);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;

            // modelTextBox
            this.modelTextBox.Location = new System.Drawing.Point(62, 48);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;

            // brandTextBox
            this.brandTextBox.Location = new System.Drawing.Point(62, 22);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 3;

            // promptPriceLabel
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Location = new System.Drawing.Point(22, 77);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(41, 13);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格：";

            // promptModelLabel
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Location = new System.Drawing.Point(17, 52);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(41, 13);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號：";

            // promptBrandLabel
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Location = new System.Drawing.Point(18, 25);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(41, 13);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌：";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 307);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectPropertiesGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Name = "Form1";
            this.Text = "手機測試";
            this.objectPropertiesGroupBox.ResumeLayout(false);
            this.objectPropertiesGroupBox.PerformLayout();
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectPropertiesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label outputPriceLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputBrandLabel;
        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
    }
}


