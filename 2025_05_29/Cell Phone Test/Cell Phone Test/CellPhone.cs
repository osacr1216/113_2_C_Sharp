using System;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        private string _brand;
        private string _model;
        private decimal _price;  // 改為 decimal 型別，正確表示價格

        // 建構子，初始化欄位
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // 品牌屬性
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // 型號屬性
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // 價格屬性（具有檢查不可為負）
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("價格不能是負數！");
                _price = value;
            }
        }
    }
}



