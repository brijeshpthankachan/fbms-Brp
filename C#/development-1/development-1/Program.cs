
<<<<<<< HEAD
using development_1;


Employee brijesh = new Employee()
{

    Id = 1,
    Name = "brijesh",
    Designation = "Developer",
    sal = 30000
};

Employee Amala = new Employee()
{

    Id = 1,
    Name = "Amala",
    Designation = "Developer",
    sal = 30000
};

Employee Aiswaraya = new Employee()
{

    Id = 1,
    Name = "Amala",
    Designation = "Manager",
    sal = 80000
};


var xyz = new Employee()
{
    Id = 1,
    Name = "xyz",
    Designation = "Trainee",
    sal = 567
};

Console.WriteLine($"{xyz.Id} {xyz.Name}, {xyz.Designation} {xyz.sal}");


//============================================================

Mobile m1 = new Mobile();
m1.Set("Poco ", "X3", "Xiomi", 20000);

Mobile m2 = new Mobile();
m2.Set("Galaxy", "Note 20", 20000);

m1.Get();
m2.Get();

//=============================================================


Animal Lion = new Animal()
{
    Name = "Lion",
    Food = "Carnivore",
    MaxLifeTime = 50

};

Lion.GetAnimal();

//=============================================================

Furniture f1 = new Furniture("Cedar","", 100);
Furniture f2 = new Furniture("Ceder");
Furniture f3 = new Furniture();

f1.GetFurnitureInfo();
f2.GetFurnitureInfo();
f3.GetFurnitureInfo();

//==============================================================

Food Burger = new Food()
{

    Name = "Burger",
    Price = 155

};

Food Kanji = new Food()
{
    Name = "Kanji",
    Price = 140
};

Burger.GetFoodInfo();
Kanji.GetFoodInfo();

//==============================================================

Cloath Silk = new Cloath()
{
    Catogory = "silk",
    Stock = "old",
    Price = 150,
};

Cloath Cotton = new Cloath()
{
    Catogory = "Cotton",
    Stock = "new",
    Price = 1500,
};

Silk.GetCloathInfo();
Cotton.GetCloathInfo();

//==============================================================

Child P1 = new Child();
P1.Set( 20, "Brijesh", "Generation X");
P1.GetFamilyInfo();

//==============================================================

Emp emp1 = new Emp();
emp1.Set("Samsung", "Large", "Brijesh", "General Manager");
emp1.GetEmployeeInfo();

//==============================================================

for(int i = 1; i <= 50; i++)
{
    if(i%3==0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}
=======
//Console.WriteLine(Add(5, 6));
//Console.WriteLine(Add(5, 6, 7, 8));


//int Add(int x, int y, params int[] num) => num.Sum() + x + y;



//Lists



//static void display(dynamic x)
//{

//    foreach (var item in x)
//    {
//        if (item.GetType().Name == "KeyValuePair`2")
//        {
//            Console.Write(item.Key.ToString() + " : ");
//            foreach (var item2 in item.Value)
//            {

//                Console.Write(item2 + " ");
//            }
//            Console.Write(Environment.NewLine);
//        }
//        else
//        {
//            Console.Write(item.ToString() + " ");
//        }
//    }
//    Console.Write("\n");

//}



//var list = new List<int>();

//list.Add(10);
//list.Add(20);
//list.Add(30);
//list.Add(40);
//list.AddRange(new int[] { 1, 2, 3, 4 });

//list.Capacity = 5;


//display(list);


//copying an array   

//int[] arr = new int[] { 1, 2, 3, 4 };
//int[] arr2 = new int[arr.Length];
//Array.Copy(arr, arr2, arr.Length);

//display(arr2);


//empty string 

//string txt = string.Empty;
//if (string.IsNullOrEmpty(txt))
//{
//    display("yes");
//}

//txt = "  ";

//if (string.IsNullOrWhiteSpace(txt))
//{
//    display("only whitespaces");
//}


//Dictionaries

//var dic = new Dictionary<string, List<int>>
//{
//    { "texas", new List<int> { 1, 2, 3, 4 } },
//    { "Milanoplis", new List<int> { 14, 24, 443, 44 } },
//    { "canbera", new List<int> { 10, 20, 30, 40 } }
//};



//display(dic);




//var newDictionary = new Dictionary<string, string>();

//for (int i = 0; i < 10; i++)
//{
//    newDictionary.Add("name " + i.ToString(), "Brijesh" + i.ToString());
//}

//display(newDictionary);

//--------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------


//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 8, 9, 9, 1, 1, 2, 4, 6, 7, 5, 7, 9, 6, 9, 0, 0, 4, 67, 8 };
//var counter = new Dictionary<int, int>();

//foreach (int i in numbers)
//{
//    try
//    {
//        counter[i] += 1;
//    }
//    catch (Exception)
//    {

//        counter[i] = 1;
//    }
//}


//foreach (var item in counter)
//{
//    Console.WriteLine($"{item.Key} Repeats {item.Value} Times");
//}



//var di = new Dictionary< IDictionary<string,string>, newDictionary >();




using development_1;

StudentMarkInformation s1 = new("brijesh", 80, 90);

s1.GetData();



>>>>>>> c8ac1849255a081b168a81d45f5bf3a2de7f3b27
