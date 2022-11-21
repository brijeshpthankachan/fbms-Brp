
using RMS;


Dictionary<int, FoodClass> FoodList = new Dictionary<int, FoodClass>()
{
    {1000, new (){ FoodId = 1000, FoodName = "Chicken Biriyani", FoodPrice=180 }},
    {1001, new (){ FoodId = 1001, FoodName = "Alpham Qtr", FoodPrice=130 } },
    {1002, new (){ FoodId = 1002, FoodName = "Alpham Half", FoodPrice=250 }},
    {1003, new (){ FoodId = 1003, FoodName = "Mandhi (Chicken)", FoodPrice=180 }}
};


void RestaurantOptions()
{
    Console.WriteLine("1.   View Orders");
    Console.WriteLine("2.   Fill Orders");
    Console.WriteLine("3.   View Menu");
    Console.WriteLine("4.   Update Menu");
    Console.WriteLine("5.   Print Bill");
    Console.WriteLine("----------------------------------");

}

void CustomerOptions()
{
    Console.WriteLine("1.   View Menu");
    Console.WriteLine("2.   Place Order");
    Console.WriteLine("3.   Update Order");
    Console.WriteLine("4.   View Order Status");
    Console.WriteLine("5.   Pay Bill");
    Console.WriteLine("----------------------------------");


}

void Cms()
{
    Console.Clear();
    CustomerOptions();

    int Options = 0;
    try
    {
        Options = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("An Error has Occured Redirecting To Home Screen");
        Thread.Sleep(1000);
        Main();
    }

    switch (Options)
    {
        case 1:
            Cms_PlaceOrders();
            break;
        case 2:
            Rms_FillOrdres();
            break;
        case 3:
            Rms_ViewMenu();
            break;
        case 4:
            Rms_UpdateMenu();
            break;
        case 6:
            Rms_PrintBill();
            break;
        default:
            break;
    }
}

void Cms_PlaceOrders()
{
    Rms_ViewMenu();
    Console.WriteLine("Enter Item Name");
    string FoodName = Console.ReadLine();

}

void Rms()
{

    Console.Clear();
    RestaurantOptions();
    int Options = 0;
    try
    {
        Options = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("An Error has Occured Redirecting To Home Screen");
        Thread.Sleep(1000); 
        Main();
    }

    switch (Options)
    {
        case 1:
            Rms_ViewOrders();
            break;
        case 2:
            Rms_FillOrdres();
            break;
        case 3:
            Rms_ViewMenu();
            break;
        case 4:
            Rms_UpdateMenu();
            break;
        case 6:
            Rms_PrintBill();
            break;
        default:
            break;
    }

}

void Rms_PrintBill()
{
    throw new NotImplementedException();
}

void Rms_UpdateMenu()
{
    int Options = 0;
    Console.Clear();
    Console.WriteLine("1.   Edit Food Name\n2.    Update Price\n3.  Add New Item");  
    try
    {
        Options = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("An Error Has Occured");
        Thread.Sleep(1000);
        Main();
    }

    switch (Options)
    {
        case 1:
            Rms_Update_EditFoodName();
            break;
        case 2:
            Rms_Update_EditPrice();
            break;
        case 3:
            Rms_Update_AddNewItem();
            break;
        default:
            break;
    }


}

void Rms_Update_AddNewItem()
{
    
    Console.WriteLine("Enter ID");
    int Id = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Food Name");
    string FoodName = Console.ReadLine();
    Console.WriteLine("Enter Price");
    int Price = int.Parse(Console.ReadLine());

    FoodList[Id] = new FoodClass()
    {
        FoodId = Id,
        FoodName = FoodName,
        FoodPrice = Price
    };

}

void Rms_Update_EditPrice()
{
    Console.WriteLine("Enter Food  ID");
    int Id = int.Parse(Console.ReadLine());
    FoodList[Id].ChangePrice();
}

void Rms_Update_EditFoodName()
{
    throw new NotImplementedException();
}

void Rms_ViewMenu()
{

    Console.WriteLine("\tID\tNAME\t\t\tPRICE");
    Console.WriteLine("\t----------------------------------------");
    foreach (var item in FoodList.Keys)
    {
        Console.WriteLine($"{FoodList[item].FoodId.ToString().PadLeft(10)}\t{FoodList[item].FoodName.PadRight(20)}\t{FoodList[item].FoodPrice}");
    }

}

void Rms_FillOrdres()
{
    throw new NotImplementedException();
}

void Rms_ViewOrders()
{
    throw new NotImplementedException();
}

void Main()
{

    Console.Clear();
    Console.WriteLine("1. Customer");
    Console.WriteLine("2. Restaurent Admin");


    while (true)
    {
        int Option =0;

        try
        {
            Option = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Input A Number Idiot!!");
            Thread.Sleep(1000);
            Main();
        }
        switch (Option)
        {
            case 2:
                Rms();
                break;
            case 1:
                Cms();
                break;
            default:
                break;
        }

    }

}


Main();