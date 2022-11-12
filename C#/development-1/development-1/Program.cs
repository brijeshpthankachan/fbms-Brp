
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
