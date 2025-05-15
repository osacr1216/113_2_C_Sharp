using System;
using System.Windows.Forms;

namespace Structure_Argument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 顯示車輛資訊方法
        private void DisplayAuto(Automobile auto)
        {
            MessageBox.Show(auto.year + " 年 " + auto.make +
                "，里程數：" + auto.mileage + " 英里。");
        }

        private void auto1Button_Click(object sender, EventArgs e)
        {
            Automobile sportsCar = new Automobile { make = "Chevy Corvette", year = 1970, mileage = 50000.0 };
            DisplayAuto(sportsCar);
        }

        private void auto2Button_Click(object sender, EventArgs e)
        {
            Automobile pickupTruck = new Automobile { make = "Ford Ranger", year = 1985, mileage = 75000.0 };
            DisplayAuto(pickupTruck);
        }

        private void auto3Button_Click(object sender, EventArgs e)
        {
            Automobile sedan = new Automobile { make = "Honda Accord", year = 2000, mileage = 80000.0 };
            DisplayAuto(sedan);
        }
    }

    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }
}


