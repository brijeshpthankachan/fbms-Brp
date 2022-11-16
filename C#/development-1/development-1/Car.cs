
public class Car
{


        public int Price;
        public string Type;

    public Car(int price, string type)
    {
        Price = price;
        Type = type;
    }

    public Car()
    {

    }

}

 


public class SuperCar : Car
{
    public int Bhp;
    public SuperCar(int price, string type, int bhp)
    {
        Price = price;
        Type = type;
        Bhp = bhp;
    }

}



