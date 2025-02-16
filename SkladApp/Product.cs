
namespace SkladApp
{
    class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;


        public Product()
        {
            Console.WriteLine("Товар створено.");
        }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Назва не може бути порожньою.");
                }
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна не може бути від'ємною.");
                }
                _price = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public decimal TotalValue
        {
            get { return _price * _quantity; }
        }

        public void Restock(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Кількість для поповнення має бути додатною.");
            }
            _quantity += amount;
        }

        public void Sell(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Кількість для продажу має бути додатною.");
            }
            if (amount > _quantity)
            {
                Console.WriteLine("Недостатньо товару на складі!");
                return;
            }
            _quantity -= amount;
        }

        public string GetInfo()
        {
            return $"Товар: {Name}, Ціна: {Price} грн, Кількість: {Quantity}, Загальна вартість: {TotalValue} грн";
        }

    }
}