namespace Structure_Argument
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button auto1Button;
        private System.Windows.Forms.Button auto2Button;
        private System.Windows.Forms.Button auto3Button;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.auto1Button = new System.Windows.Forms.Button();
            this.auto2Button = new System.Windows.Forms.Button();
            this.auto3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            this.auto1Button.Location = new System.Drawing.Point(24, 18);
            this.auto1Button.Name = "auto1Button";
            this.auto1Button.Size = new System.Drawing.Size(75, 33);
            this.auto1Button.Text = "顯示車輛 #1";
            this.auto1Button.Click += new System.EventHandler(this.auto1Button_Click);
            // 
            this.auto2Button.Location = new System.Drawing.Point(105, 18);
            this.auto2Button.Name = "auto2Button";
            this.auto2Button.Size = new System.Drawing.Size(75, 33);
            this.auto2Button.Text = "顯示車輛 #2";
            this.auto2Button.Click += new System.EventHandler(this.auto2Button_Click);
            // 
            this.auto3Button.Location = new System.Drawing.Point(186, 18);
            this.auto3Button.Name = "auto3Button";
            this.auto3Button.Size = new System.Drawing.Size(75, 33);
            this.auto3Button.Text = "顯示車輛 #3";
            this.auto3Button.Click += new System.EventHandler(this.auto3Button_Click);
            // 
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.auto1Button);
            this.Controls.Add(this.auto2Button);
            this.Controls.Add(this.auto3Button);
            this.Text = "車輛資訊顯示";
            this.ResumeLayout(false);
        }
    }
}

