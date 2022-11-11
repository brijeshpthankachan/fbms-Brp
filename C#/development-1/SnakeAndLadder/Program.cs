


Console.WriteLine("Enter First Players's Name");
string firstPlayerName = Console.ReadLine();
Console.WriteLine("Enter Second Players Name");
string secondPlayersName = Console.ReadLine();

Console.WriteLine("-----------------------------------");
Console.WriteLine("Press T to Throw Dice");
Console.WriteLine("Press q to Quit");


int firstPlayerPosition = 0, secondPlayerPosition = 0, play = 2, maxScore = 100;



void Display()
{
    Console.Clear();
    Console.WriteLine($"{firstPlayerName} : {firstPlayerPosition} ");
    Console.WriteLine($"{secondPlayersName} : {secondPlayerPosition}");
}

void HasWon()
{
    if (firstPlayerPosition == maxScore)
    {
        Console.WriteLine($"{firstPlayerName} Won!!");
        Environment.Exit(0);
    }
    else if (secondPlayerPosition == maxScore)
    {
        Console.WriteLine($"{secondPlayersName} Won!!");
        Environment.Exit(0);
    }
}

Dictionary<int, int> laddersIndex = new Dictionary<int, int>() {
    {4,14 },{8,12 },{20,35 },{36,44},{45,52},{ 55,70},{63,75},{ 21,90}

};

Dictionary<int, int> snakesIndex = new Dictionary<int, int>() {
    {15,4 },{13,8 },{36,20 },{45,36},{53,45},{ 71,55},{76,63},{ 91,20}

};

void UpdateScore(ref int x, int score)
{
    if (x + score <= maxScore)
    {
        x += score;
    }
    foreach (var i in laddersIndex.Keys)
    {
        if (x == i)
        {
            Console.WriteLine("yooo hit a ladder!!");
            x += (laddersIndex[i] - x);
        }
    }
    foreach (var i in snakesIndex.Keys)
    {
        if (x == i)
        {
            Console.WriteLine("OOps You got eaten!!");
            x -= (x - snakesIndex[i]);
        }
    }
}

void ShowPlayerNames()
{
    if (play % 2 == 0)
    {
        Console.WriteLine($"{firstPlayerName}'s Draw");
    }
    else
    {
        Console.WriteLine($"{secondPlayersName}'s Draw");
    }

}

while (true)
{

    HasWon();
    ShowPlayerNames();
    string choice = Console.ReadLine();

    if (choice == "t")
    {
        if (play % 2 == 0)
        {
            UpdateScore(ref firstPlayerPosition, new Random().Next(1, 6));
        }
        else
        {
            UpdateScore(ref secondPlayerPosition, new Random().Next(1, 6));
        }
        play++;
        Display();
    }
    else if (choice == "q")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Option");
    }

}



