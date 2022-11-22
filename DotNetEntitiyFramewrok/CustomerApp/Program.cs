using ConsoleApp1.Data;

var db = new ApplicationDbContext();

db.Customer.Add(new()
{
    Name = "Amala",
    Email = "Amala@gmail.com",
    PhoneNumber = 1234567,
    Country = "IN"
});


db.SaveChanges();