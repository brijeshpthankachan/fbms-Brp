
//Create a Class food with parametres name, price, discount and pass the
//values from main function . If price>150 set discount 10% and reset value of
//price after deducting 10% from it.


namespace development_1
{
    internal class Food
    {

        public string Name { get; set;}
        private int _Discount { get; set; }

        private double _Price;

        public double Price { get => _Price;  set {

                if (value > 150)
                {
                    _Discount = 10;
                    _Price = value - (value * _Discount/100);
                    return;
                }
                _Discount = 0;
                _Price = value;
            } }

        public void GetFoodInfo()
        {
            Console.WriteLine($" { Name }  {_Discount} {_Price}");
        }

    }
}
