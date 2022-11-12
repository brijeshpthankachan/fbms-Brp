


//create a class cloath with datamembers stock, price, category, sale and pass
//the values at time object creation. The value of stock should be older new.If it
//is old set the value of sale as discount otherwisw normal. And reduce the price
//by 20%

namespace development_1
{
    internal class Cloath
    {

        string _Stock;
        private double _Price;
        public string Catogory;
        private string _Sale;


        public string Stock { get=>_Stock; set { 
            
                if(value =="old" || value == "new")
                {
                    if (value == "old")
                    {
                        _Sale = "discount";
                    }
                    else
                    {
                        _Sale = "Normal";
                    }
                    _Stock = value;

                }
                else
                {
                    return;                }

            } }

        public double Price { get=>_Price; set {

                if (_Sale == "discount")
                {
                    _Price = value - (value * 0.2);
                    return;
                }
                _Price = value;
            
            } }

        public void GetCloathInfo()
        {
            Console.WriteLine($"{Catogory} {_Stock} {_Sale} {_Price} ");
        }
    }
}
