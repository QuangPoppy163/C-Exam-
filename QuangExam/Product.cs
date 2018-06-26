namespace QuangExam
{
    public class Product
    {
        private string _productName;
        private string _productID;
        private double _price;

        public Product()
        {
        }

        public Product(string productName, string productId, double price)
        {
            _productName = productName;
            _productID = productId;
            _price = price;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public string ProductId
        {
            get => _productID;
            set => _productID = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }
    }
}  