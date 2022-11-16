//-----------------------------------------------------------------------------------------------------------------
void Asort(dynamic x)
{

   

    for(int i = 0; i < x.Count; i++)
    {
        for(int j = i; j < x.Count; j++)
        {

            if (string.Compare(x[i], x[j])>0)
            {

                string temp = x[i];
                x[i] = x[j];
                x[j]=temp;

            }

        }
    }


    foreach (var item in x)
    {
        Console.WriteLine(item);
    }

}
//-----------------------------------------------------------------------------------------------------------------
void Dsort(dynamic x)
{



    for (int i = 0; i < x.Count; i++)
    {
        for (int j = i; j < x.Count; j++)
        {

            if (string.Compare(x[i], x[j]) < 0)
            {

                string temp = x[i];
                x[i] = x[j];
                x[j] = temp;

            }

        }
    }


    foreach (var item in x)
    {
        Console.WriteLine(item);
    }

}
//-----------------------------------------------------------------------------------------------------------------
void Q1()
{


 

    List<string> Passengers = new List<string>() { "Brijesh P Thankachan", "Brijesh P Thankachan","Amala Thresa","Aiswariya Premkumar","Muhammee Ashique","Jain Varghese"};
    //Console.WriteLine("press Q to Quit");
    //Console.WriteLine("Enter Names");


    Console.WriteLine("\n 1. Insert \n 2. Sort in Ascending order \n 3. Sort in Descending Order \n 4. Search Name \n 5. print name length \n 6. Split Names \n 7. List Duplicates \n\n ----------------------------------\n");




    while (true)
    {
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                  break;
            case 2:
                Console.WriteLine("\nSorted in Ascending Order\n");
                Asort(Passengers);
                break;
            case 3:
                Console.WriteLine("\nSorted in Descending Order \n");
                Dsort(Passengers);
                break ;
            case 4:
                Console.WriteLine("Enter String To Search");
                string name = Console.ReadLine();  
                foreach(string s in Passengers)
                {
                    if (s == name)
                    {
                        Console.WriteLine($"{name} found at position {Passengers.IndexOf(name)}");
                    }
                }
                break;

            case 5:
                Console.WriteLine("Lengeth of Each Names \n ----------------------------\n");
                foreach(string s in Passengers)
                {
                    Console.WriteLine($"{s} : {s.Length}");
                } 
                break;
            case 6:
                Console.WriteLine("Names Splitted at space \n --------------------\n");
                foreach(string s in Passengers)
                {
                    var k = s.Split(" "); 
                    foreach(var i in k)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("\n");
                }   
                break;
            case 7:
                Console.WriteLine("Duplicate Entries are\n------------------------");
                Dictionary<string,int> dic = new Dictionary<string, int>();

                foreach(string s in Passengers)
                {

                    try
                    {
                        dic[s] = dic[s] + 1;
                    }
                    catch (Exception)
                    {

                        dic[s] = 1;
                    }

                }
                foreach(string s in dic.Keys)
                {
                    if(dic[s] > 1)
                    {
                        Console.WriteLine($"{s} Exists {dic[s]} times");
                    }
                }
                break;
            default:
                Environment.Exit(0);
                break;
        }


    }



}
//-----------------------------------------------------------------------------------------------------------------
void Q2()
{

    //Accept a flight fare and booking time(15 min)
    //a.If booking time from 6am to 9am, apply 10 % fare increase and print
    //b.If booking time from 9am to 5pm, apply 20 % fare increase and print
    //c.If booking time from 5pm to 11pm, apply 7 % fare increase and print
    //d.If booking time from 11pm to 6am, apply 5 % fare increase and print


    Console.WriteLine("Enter Flight Ticket Booking Time am");
    string time = Console.ReadLine();
    int numtime = int.Parse(new String(time.Where(Char.IsDigit).ToArray()));
    double fare = 1000;


    if (time.Contains("pm"))
    {
        numtime += 12;
    }



    if (numtime>6 && numtime<9)
    {
        fare += (fare * 0.1);
    }
    else if(numtime>9 && numtime < 17)
    {
        fare += (fare * 0.2);
    }
    else if(numtime>17 && numtime < 13)
    {
        fare += (fare * 0.07);
    }
    else
    {
        fare += (fare * 0.05);
    }

    Console.WriteLine($"Adjusted fare is {fare}");

}
//-----------------------------------------------------------------------------------------------------------------
void Asort_(dynamic x)
{



    for (int i = 0; i < x.Count; i++)
    {
        for (int j = i; j < x.Count; j++)
        {

            if (x[i]> x[j])
            {

                double temp = x[i];
                x[i] = x[j];
                x[j] = temp;

            }

        }
    }


    foreach (var item in x)
    {
        Console.WriteLine(item);
    }

}
//-----------------------------------------------------------------------------------------------------------------
void Dsort_(dynamic x)
{



    for (int i = 0; i < x.Count; i++)
    {
        for (int j = i; j < x.Count; j++)
        {

            if (x[i]< x[j])
            {

                double temp = x[i];
                x[i] = x[j];
                x[j] = temp;

            }

        }
    }


    foreach (var item in x)
    {
        Console.WriteLine(item);
    }

}
//-----------------------------------------------------------------------------------------------------------------
void Q3()
{




    List<double> Fares = new List<double>() {100.0,200.0,30.45,45.6,100.34,789.9,100,100};



    Console.WriteLine("\n 1. Insert \n 2. Sort in Ascending order \n 3. Sort in Descending Order \n 4. Search Fare \n 5. print Max and Min Fares \n 6. List Duplicates \n\n ----------------------------------\n");




    while (true)
    {
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                break;
            case 2:
                Console.WriteLine("\nSorted in Ascending Order\n");
                Asort_(Fares);
                break;
            case 3:
                Console.WriteLine("\nSorted in Descending Order \n");
                Dsort_(Fares);
                break;
            case 4:
                Console.WriteLine("Enter String To Search");
                double Fare = double.Parse(Console.ReadLine());
                foreach (double s in Fares)
                {
                    if (s == Fare)
                    {
                        Console.WriteLine($"{Fare} found at position {Fares.IndexOf(Fare)}");
                    }
                }
                break;

            case 5:
                Console.WriteLine("Max and Min Fares \n ----------------------------\n");
                double max = 0;
                foreach (double s in Fares)
                {
                    if (s > max)
                    {
                        max = s;
                    }
                }
                Console.WriteLine($"Maximum Value : {max}");

                double min = Fares[0];
                foreach (double s in Fares)
                {
                    if (s < min)
                    {
                        min = s;
                    }
                }
                Console.WriteLine($"minimum Value : {min}");
                break;
           
            case 6:
                Console.WriteLine("Duplicate Entries are\n------------------------");
                Dictionary<double, int> dic = new Dictionary<double, int>();

                foreach (double s in Fares)
                {

                    try
                    {
                        dic[s] = dic[s] + 1;
                    }
                    catch (Exception)
                    {

                        dic[s] = 1;
                    }

                }
                foreach (Double s in dic.Keys)
                {
                    if (dic[s] > 1)
                    {
                        Console.WriteLine($"{s} Exists {dic[s]} times");
                    }
                }
                break;
            default:
                Environment.Exit(0);
                break;
        }


    }



}
//-----------------------------------------------------------------------------------------------------------------
void Q4()
{
    //Accept the passenger Date of Birth(15 min)
    //a.Display his/her age in Hours
    //b. Display his/her age in Days
    //c. Display his/her age in weeks
    //d. Display his/her age in Months
    //e. Display his/her age in Years
    //f. Display his/her year of birth is a leap year or not

    Console.WriteLine("Enter Date Of Birth");
    DateTime Date = DateTime.Parse(Console.ReadLine()).Date;
    
    var Cdate = DateTime.UtcNow.Date;

    Console.WriteLine($"Age in Hours {Cdate.Subtract(Date)*24}");
    Console.WriteLine($"Age in Days {Cdate.Subtract(Date).Days}");
    Console.WriteLine($"Age in Weeks {(Cdate.Subtract(Date).Days)/7}");
    Console.WriteLine($"Age in Months {((Cdate.Subtract(Date).Days)/365)*12}");
    Console.WriteLine($"Age in Years {(Cdate.Subtract(Date).Days) / 365 }");





    int year = Date.Year;
    if ((year % 400 == 0) && (year % 100 == 0))
            Console.WriteLine($"{year} is a Leap Year");
    else if((year % 4 == 0) && (year % 100 != 0))
        Console.WriteLine($"{year} is a Leap Year");
    else
        Console.WriteLine($"{year} is a Not Leap Year");

}
//-----------------------------------------------------------------------------------------------------------------
void Q5()
{

    //5.Accept flight fares in decimal format and put it in an array at even or odd positions(15 min)

    List<Double> lis = new List<double>() { 10.5, 20.5, 30.5, 40.2, 50.5, 60.5 };
    double[] Odd = new double[(lis.Count*2)+2];
    double[] Even = new double[(lis.Count * 2) + 2];

    int j = 1;
    foreach (double d in lis)
    {
        Odd[j] = d;
        j += 2;
    }

    j = 2;
    foreach (double d in lis)
    {
        Even[j] = d;
        j += 2;
    }

    Console.WriteLine("Odd Array");
    for(int i = 0; i < Odd.Length; i++)
    {
        Console.Write(Odd[i]+"|");
    }

    Console.WriteLine("Even Array\n\n");
    for (int i = 0; i < Even.Length; i++)
    {
        Console.Write(Even[i] + "|");
    }
}
//-----------------------------------------------------------------------------------------------------------------
void Q6()
{

    //Accept flight destinations, their distance and the fares and store it(Use appropriate types) (1
    //hour)
    //a.Accept a source and destination and Display the shortest path
    //b. Accept a source and destination and Display the longest path
    //c. Accept a source and destination and Display the lowest fare
    //d. Accept a source and destination and Display the highest fare
    //e. Display the shortest route with lowest fare
    //f. Display the shortest route with highest fare
    //g. Display the longest route with highest fare
    //h. Display the longest route with lowest fare

    Console.WriteLine("hi");

    var DistanceInfo = new List<List<string>> ()
    {

        new List<string>(){ "Kochi","Delhi","10000","300" } ,
        new List<string>(){ "Trivandrum","Delhi","2000","200" } ,
        new List<string>(){ "Trivandrum","Delhi","2000","100" } ,
        new List<string>(){ "Kochi","Mumbai","10000","500" },
        new List<string>(){ "Kochi", "Delhi","12000","400" } ,

    };


    while (true)
    {

        Console.WriteLine("1. Display shortest path source-Destination\n2. Display Longest Path Source Destination\n3. Display the lowest fare \n4. Display the Highest fare\n.5. longest route with highest fare\n6. longest route with lowest fare\n7. Shortest Route with higest Fare\n8. Shortest Route with Lowest Fare");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("Enter Source");
                string Source = Console.ReadLine(); 
                Console.WriteLine("Enter Destination");
                string Destination = Console.ReadLine();
                int ShortestPath=99999999;
                foreach(var item in DistanceInfo)
                {
                    if (item[0]==Source && item[1] == Destination)
                    {
                        if (int.Parse(item[2]) < ShortestPath)
                        {
                            ShortestPath = int.Parse(item[2]);
                        }

                    }

                }
                Console.WriteLine(ShortestPath);
                break;
            case 2:
                Console.WriteLine("Enter Soururce");
                string Source_ = Console.ReadLine();
                Console.WriteLine("Enter Soururce");
                string Destination_ = Console.ReadLine();
                int LongestPath = 0;
                foreach (var item in DistanceInfo)
                {
                    if (item[0] == Source_ && item[1] == Destination_)
                    {
                        if (int.Parse(item[2]) > LongestPath)
                        {
                            LongestPath = int.Parse(item[2]);
                        }

                    }

                }
                Console.WriteLine(LongestPath);
                break;
            case 3:

                Console.WriteLine("Enter Soururce");
                string Sour = Console.ReadLine();
                Console.WriteLine("Enter Destination");
                string Dest = Console.ReadLine();
                int LowFare = 9999999;
                foreach (var item in DistanceInfo)
                {
                    if (item[0] == Sour && item[1] == Dest)
                    {
                        if (int.Parse(item[3]) < LowFare)
                        {
                            LowFare = int.Parse(item[3]);
                        }

                    }

                }
                Console.WriteLine(LowFare);

                break;
            case 4:
                Console.WriteLine("Enter Soururce");
                string Sou = Console.ReadLine();
                Console.WriteLine("Enter Soururce");
                string Des = Console.ReadLine();
                int HighFare = 0;
                foreach (var item in DistanceInfo)
                {
                    if (item[0] == Sou && item[1] == Des)
                    {
                        if (int.Parse(item[3]) > HighFare)
                        {
                            HighFare = int.Parse(item[3]);
                        }

                    }

                }
                Console.WriteLine(HighFare);
                break ;
            case 5:
                int dist = 0;
                int fare = 0;
                foreach(var item in DistanceInfo)
                {
                    if ( int.Parse(item[2]) >= dist && int.Parse(item[3]) > fare)
                    {
                        dist = int.Parse(item[2]);
                        fare = int.Parse(item[3]);
                        
                    }
                }
                Console.WriteLine($"Longet Route with highest fair {dist} {fare}");
                break;
            case 6:
                int dis = 0;
                int far = 9999999;
                foreach (var item in DistanceInfo)
                {

                    if (int.Parse(item[2]) >= dis && int.Parse(item[3]) < far)
                    {
                        dis = int.Parse(item[2]);
                        far = int.Parse(item[3]);

                    }
                }
                Console.WriteLine($"Longet Route with Lowest fair {dis} {far}");
                break;
            case 7:
                int di = 9999999;
                int fa = 0;
                foreach (var item in DistanceInfo)
                {

                    if (int.Parse(item[2]) <= di && int.Parse(item[3]) > fa)
                    {
                        di = int.Parse(item[2]);
                        fa = int.Parse(item[3]);

                    }
                }
                Console.WriteLine($"Shortest Route with Highest fair {di} {fa}");
                break;
            case 8:
                int d = 9999999;
                int f = 9999999;
                foreach (var item in DistanceInfo)
                {

                    if (int.Parse(item[2]) <= d && int.Parse(item[3]) < f)
                    {
                        d = int.Parse(item[2]);
                        f = int.Parse(item[3]);

                    }
                }
                Console.WriteLine($"Shotest Route with Highest fair {d} {f}");
                break;
            default:
                break;
        }


    }


}
//-----------------------------------------------------------------------------------------------------------------
void Q7()
{

    //Accept passenger name and total miles travelled(15 min)
    //a.If miles > 10,000, award 10 frequent flyer points to the passenger and display
    //b.If miles > 20,000, award 20 frequent flyer points to the passenger and display
    //c.If miles > 50,000, award 30 frequent flyer points to the passenger and display
    //d.If miles > 100,000, award 50 frequent flyer points to the passenger and display


    Console.WriteLine("Enter Passenger Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Miles Traveled");
    int miles = int.Parse(Console.ReadLine());

    int ffp = 0;
    if(miles > 10000)
    {
        ffp = 10;
    }
    else if(miles > 20000)
    {
        ffp = 30;
    }
    else if (miles > 50000)
    {
        ffp = 40;
    }
    else if (miles > 100000)
    {
        ffp = 50;
    }

    Console.WriteLine($"{name} {ffp}");



}
//-----------------------------------------------------------------------------------------------------------------
void Q8()
{

    //Accept the flight fares in decimal into an array. Accept destinations in to another array.
    //Accept the nth number from keyboard and display that destination and fare(15 min)

    int[] fares = new int[] { 10,15,30,40,60,80,90,100};
    string[] destinations = new string[] { "kochi", "Kozikkode", "Delhi", "Trivandrum" };
    Console.WriteLine($"Enter Index less than {destinations.Length}");
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"{fares[index]} {destinations[index]}");
}
//-----------------------------------------------------------------------------------------------------------------
void Q9()
{



    //    a.Age < 10, print as Kid
    //b.Age > 10 and age<30 print as Youth
    //c.Age > 30 and age<60 print Adult
    //d.Age > 60 print Older
    //Console.WriteLine("Enter Date of Birth");
    string[] x = new string[] { "09-03-1999", "09-03-1998", "09-03-1990", "09-03-1989", "09-03-2009", "09-03-1999", "09-03-2002", "09-03-2000" };

    foreach (var item in x)
    {
        string catgogory = "";
        int age = (DateTime.UtcNow.Year) - (DateTime.Parse(item).Year);
        if (age < 10)
        {
            catgogory = "kid";
        }
        else if (age > 10 && age < 30)
        {
            catgogory = "youth";
        }
        else if (age > 30 && age < 60)
        {
            catgogory = "adult";
        }
        else if (age > 60)
        {

            catgogory = "older";

        }

        Console.WriteLine($"{age} {catgogory}");
    }
}
//-----------------------------------------------------------------------------------------------------------------
void Q10()
{

    List<int> boarding = new List<int>() { 10, 20, 30, 40, 50, 60 };

    Queue<int> c1 = new Queue<int>();
    Queue<int> c2 = new Queue<int>();
    Queue<int> c3 = new Queue<int>();
    while (true)
    {
        Console.WriteLine("1.Insert into quue \n2. board\n");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                if (c1.Count<=3 && boarding.Count>0)
                {
                    c1.Enqueue(boarding[boarding.Count-1] );
                    Console.WriteLine($"{boarding[boarding.Count - 1]} Moved to c1");
                    boarding.RemoveAt(boarding.Count-1);
                }
                else if(c2.Count<=3 && boarding.Count > 0)
                {
                    c2.Enqueue(boarding[boarding.Count - 1]);
                    Console.WriteLine($"{boarding[boarding.Count - 1]} Moved to c2");

                    boarding.RemoveAt(boarding.Count - 1);
                }
                else if(c3.Count<=3 && boarding.Count > 0)
                {
                    c3.Enqueue(boarding[boarding.Count - 1]);
                    Console.WriteLine($"{boarding[boarding.Count - 1]} Moved to c3");
                    boarding.RemoveAt(boarding.Count - 1);
                }
                else
                {
                    Console.Write("All Queues are Full");
                }
                break;
            case 2:
                if (c3.Count>0)
                {
                    int iteam = c3.Dequeue();
                    Console.WriteLine($"{iteam} is boarded");
                }
                else if (c2.Count>0)
                {
                    int iteam = c2.Dequeue();
                    Console.WriteLine($"{iteam} is boarded");
                }
                else if (c1.Count > 0)
                {
                    int iteam = c1.Dequeue();
                    Console.WriteLine($"{iteam} is boarded");
                }
                else
                {
                    Console.WriteLine($"All Counters are Empty");

                }
                break;
            default:
                break;
        }

    }

}
//-----------------------------------------------------------------------------------------------------------------
void Q11()
{

    string Alphabet = "A";

    Console.WriteLine("\nOdd Number Range\n");
    for (int i = 101; i < 110; i += 2)
    {
        Console.Write(Alphabet + i + "  ");
    }

    Console.WriteLine("\n\nEven Number Range");

    for (int i = 100; i <= 110; i += 2)
    {
        Console.Write(Alphabet + i + "  ");
    }
    Console.WriteLine(Environment.NewLine);



    Fibonacci();

}
//-----------------------------------------------------------------------------------------------------------------
void Fibonacci()
{

    int a=0,b=1,c=0;
    Console.Write("Q"+a + " " + "Q"+b + " ");
    for (int i = 0; i < 8; i++)
    {
        c = a + b;
        a = b;
        b = c;
        Console.Write("Q"+c+" ");
    }
    Console.WriteLine(Environment.NewLine);

}
//-----------------------------------------------------------------------------------------------------------------
void Q12()
{
    string[] pass = new string[] { "Brijesh", "amala ", "Aiswarya" };
    string[] dest = new string[] { "Kochi", "Mysore", "Bangalore" };
    string[] res = new string[pass.Length+dest.Length+2];
    int j = 0;
    for(;j<pass.Length ; j++)
    {
        res[j] = pass[j];
    }

    for (int i=0; i< dest.Length; i++)
    {
        res[j++] = dest[i];
    }

    Console.WriteLine("Merged Array\n");

    foreach(string s in res)
    {
        Console.Write(s + " ");
    }   
}
//-----------------------------------------------------------------------------------------------------------------
void Q15()
{
    Dictionary<string, int[]> WeightInfo = new Dictionary<string, int[]>()
    {

        {"Brijesh",new int[2]{25,0} },
        {"Amala",new int[2]{28,0} },
        {"Aiswarya",new int[2]{150,0} },
        {"Ashique",new int[2]{20,0} },

    };


    foreach(string s in WeightInfo.Keys)
    {
        if (WeightInfo[s][0] > 23)
        {
            WeightInfo[s][1] = (WeightInfo[s][0]-23)*15;
        }
    }

    foreach(string s in WeightInfo.Keys)
    {
        Console.WriteLine($"{s} {WeightInfo[s][0]} {WeightInfo[s][1]}");
    }

    Console.WriteLine("Sorted Dictionary");


    foreach (KeyValuePair<string, int[]> i in WeightInfo.OrderByDescending(key => key.Value[1]))
    {
        Console.WriteLine($"\n\n{i.Key}  {i.Value[0]} {i.Value[1]}");
    }
}
//-----------------------------------------------------------------------------------------------------------------
while (true)
{
    Console.WriteLine("Enter Questionn Number");
    int QuesNo;
    try
    {
        QuesNo = int.Parse(Console.ReadLine());

    }
    catch (Exception)
    {

        continue;
    }

    switch (QuesNo)
    {
        case 1:
            Q1();
            break;
        case 2:
            Q2();
            break;
        case 3:
            Q3();
            break;
        case 4:
            Q4();
            break;
        case 5:
            Q5();
            break;
        case 6:
            Q6();
            break;
        case 7:
            Q7();
            break;
        case 8:
            Q8();
            break;
        case 9:
            Q9();
            break;
        case 10:
            Q10();
            break;
        case 11:
            Q11();
            break;
        case 12:
            Q12();
            break;
        case 15:
            Q15();
            break;
        default :
            Console.WriteLine("Inavlid Choice");
            break;

    }
}
//-----------------------------------------------------------------------------------------------------------------