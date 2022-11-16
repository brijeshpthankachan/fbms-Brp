
using development_1;
using System.Text.Json;
using System.Text.Json.Serialization;


//Employee brijesh = new Employee()
//{

//    Id = 1,
//    Name = "brijesh",
//    Designation = "Developer",
//    sal = 30000
//};

//Employee Amala = new Employee()
//{

//    Id = 1,
//    Name = "Amala",
//    Designation = "Developer",
//    sal = 30000
//};

//Employee Aiswaraya = new Employee()
//{

//    Id = 1,
//    Name = "Amala",
//    Designation = "Manager",
//    sal = 80000
//};


//var xyz = new Employee()
//{
//    Id = 1,
//    Name = "xyz",
//    Designation = "Trainee",
//    sal = 567
//};

//Console.WriteLine($"{xyz.Id} {xyz.Name}, {xyz.Designation} {xyz.sal}");


////============================================================

//Mobile m1 = new Mobile();
//m1.Set("Poco ", "X3", "Xiomi", 20000);

//Mobile m2 = new Mobile();
//m2.Set("Galaxy", "Note 20", 20000);

//m1.Get();
//m2.Get();

////=============================================================


//Animal Lion = new Animal()
//{
//    Name = "Lion",
//    Food = "Carnivore",
//    MaxLifeTime = 50

//};

//Lion.GetAnimal();

////=============================================================

//Furniture f1 = new Furniture("Cedar","", 100);
//Furniture f2 = new Furniture("Ceder");
//Furniture f3 = new Furniture();

//f1.GetFurnitureInfo();
//f2.GetFurnitureInfo();
//f3.GetFurnitureInfo();

////==============================================================

//Food Burger = new Food()
//{

//    Name = "Burger",
//    Price = 155

//};

//Food Kanji = new Food()
//{
//    Name = "Kanji",
//    Price = 140
//};

//Burger.GetFoodInfo();
//Kanji.GetFoodInfo();

////==============================================================

//Cloath Silk = new Cloath()
//{
//    Catogory = "silk",
//    Stock = "old",
//    Price = 150,
//};

//Cloath Cotton = new Cloath()
//{
//    Catogory = "Cotton",
//    Stock = "new",
//    Price = 1500,
//};

//Silk.GetCloathInfo();
//Cotton.GetCloathInfo();

////==============================================================

//Child P1 = new Child();
//P1.Set( 20, "Brijesh", "Generation X");
//P1.GetFamilyInfo();

////==============================================================

//Emp emp1 = new Emp();
//emp1.Set("Samsung", "Large", "Brijesh", "General Manager");
//emp1.GetEmployeeInfo();

////==============================================================

//for(int i = 1; i <= 50; i++)
//{
//    if(i%3==0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }

//}

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



//--------------------------------------------------------------------------


//List<Istudent> Ls = new List<Istudent>() { 

//    new SchoolStudent(){ M1=10,M2=20},
//    new CollegeStudent(){ M1=10,M2=20}
//};

//foreach(var i in Ls)
//{
//    Console.WriteLine(i.Total());
//}




//if (false)
//    new GmailSender().SendEmail("hi");
//else
//    new OutLookSender().SendEmail("ho");


//---------------------------------------------------------------

//SuperCar Lamborgini = new SuperCar(800000, "Sedan", 300);

//Console.WriteLine($"{Lamborgini.Price}  {Lamborgini.Type}  {Lamborgini.Bhp} ");



//Json Serialization

//var obj = new
//{
//    Name = "Brijesh P Thankachan",
//    Email = "brijeshpthankachan@gmail.com"
//};

//var Json = JsonSerializer.Serialize(obj);

//Console.WriteLine(Json);

//var ob1 = new MyClass();

//var Json2 = JsonSerializer.Serialize(ob1);
//Console.WriteLine(Json2);

//string Str = " {\"Name\":\"Brijesh P Thankachan\",\"Email\":\"brijeshpthankachan@gmail.com\"} ";

//Console.WriteLine(Str);

//var obx = JsonSerializer.Deserialize<MyClass>(Str);


//Console.WriteLine(obx.name);

//class MyClass
//{
//    [JsonPropertyName("Employee Id")]
//    public int ID { get; set; }
//    public string name { get; set; } = "Brijesh P Thankachan";

//    [JsonIgnore]
//    public int Age { get; set; }

//    private string Designtion { get; set; } = "Student";
//}


//File.WriteAllText("C:\\Users\\brijesh.thankachan\\Documents\\fbms\\C#\\development-1\\development-1\\Brijesh.txt", "I am Brijesh P Thankachan");




List <Abc> abcs  = new List<Abc>()
{

new () { Name = "Amala ", Email = "Amala@gmail.com" },
new () { Name = "Aiswarya ", Email = "Aiswarya@gmail.com" },
new () { Name = "Ashique ", Email = "Ashique@gmail.com" },
new () { Name = "Brijesh ", Email = "brjesh@gmail.com" },


};



var Options = new JsonSerializerOptions()
{

    PropertyNameCaseInsensitive = true,
    IncludeFields = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,  
    WriteIndented = true,
};

var y = JsonSerializer.Serialize(abcs,Options);

File.WriteAllText("C:\\Users\\brijesh.thankachan\\Documents\\fbms\\C#\\development-1\\development-1\\Brijesh.json", y);

class Abc
{
    public string Name { get; set; }
    public string Email { get; set; }
}

