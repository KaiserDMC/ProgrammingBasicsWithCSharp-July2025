// Input data
int tournaments = int.Parse(Console.ReadLine()); // Брой участия в турнира
int initialRankingPoints = int.Parse(Console.ReadLine()); // Начален брой точки в класацията

// Template data
int totalPoints = 0;
int counterWins = 0;

// Calculations
for (int i = 0; i < tournaments; i++)
{
    string tournamentResult = Console.ReadLine(); // Място в турнира

    switch (tournamentResult)
    {
        case "W":
            totalPoints += 2000;
            counterWins++;
            break;
        case "F":
            totalPoints += 1200;
            break;
        case "SF":
            totalPoints += 720;
            break;
    }
}

// Averages
double averagePoint = (double)totalPoints / tournaments; // Средно спечелени точки -> Общи делено на брой турнири
double percentageWins = (double)counterWins / tournaments * 100; // Проценти спечелени турнири -> Победи делено на брой турнири в проценти

totalPoints += initialRankingPoints; // Краен брой точки

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoint)}");
Console.WriteLine($"{percentageWins:f2}%");