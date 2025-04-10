namespace ArryEquality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 };

            bool arraysEqua1 = isArraysEqual(array, array2);

            if (arraysEqua1)
            {
                MessageBox.Show("兩個陣列相等");
            }
            else
            {
                MessageBox.Show("兩個陣列不相等");
            }
        }

        private bool isArraysEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}