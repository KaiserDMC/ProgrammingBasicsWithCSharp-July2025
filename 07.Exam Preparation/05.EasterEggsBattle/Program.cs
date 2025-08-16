// Input data
int eggsPlayerOne = int.Parse(Console.ReadLine()); // Начален брой яйца на играч 1
int eggsPlayerTwo = int.Parse(Console.ReadLine()); // Начален брой яйца на играч 2

string input = Console.ReadLine(); // Начална команда

// Calculations
while (input != "End")
{
    string battleResult = input; // Придаваме стойност на резултата от битката

    if (battleResult == "one")
        eggsPlayerTwo--;
    else if (battleResult == "two")
        eggsPlayerOne--;
    //eggsPlayerOne -= 1;

    if (eggsPlayerOne == 0)
    {
        Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayerTwo} eggs left.");
        return;
    }

    if (eggsPlayerTwo == 0)
    {
        Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayerOne} eggs left.");
        return;
    }

    input = Console.ReadLine(); // Получаваме нов вход от конзолата
}

Console.WriteLine($"Player one has {eggsPlayerOne} eggs left.");
Console.WriteLine($"Player two has {eggsPlayerTwo} eggs left.");
