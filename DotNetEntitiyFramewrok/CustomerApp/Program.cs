using ConsoleApp1.Data;

var db = new ApplicationDbContext();

//db.Customer.Add(new()
//{
//    Name = "Brijesh",
//    Email = "Brijesh@gmail.com",
//    PhoneNumber = 1234567,
//    Country = "IN"
//});

//var Cust = db.Customer.Where(m=>m.Id>1);


//foreach (var i in Cust)
//{
//    Console.Write($"{i.Id} : {i.Name} : {i.Email} : {i.Country}");
//}

//var cust = db.Customer.Find(1);

//cust.Name = "Brijesh The Great";



//db.Customer.Attach(new()
//    {
//        Id = 1,
//        Country = "Aus",
//    }).Property(m=>m.Country).IsModified = true;


db.Address.Add(new Address { AddressType = AddressType.Home,Ad="blablabla",CustomerID=1});

db.SaveChanges();