
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



Mobile m2 = new Mobile();
m2.Set("Galaxy", "Note 20", 20000);

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



