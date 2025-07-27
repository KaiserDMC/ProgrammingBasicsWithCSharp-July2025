// Input data
int n = int.Parse(Console.ReadLine()); // Брой отворени табове
int salary = int.Parse(Console.ReadLine()); // Стартова заплата

// Template data
int penalty = 0; // Глоби в следствие на отворени забранени сайтове

// Calculations
for (int i = 0; i < n; i++)
{
    string openedWebsite = Console.ReadLine(); // Име на сайта в отверения таб
    switch (openedWebsite)
    {
        case "Facebook":
            penalty += 150;
            break;
        case "Instagram":
            penalty += 100;
            break;
        case "Reddit":
            penalty += 50;
            break;
    }

    if (penalty >= salary)
    {
        Console.WriteLine("You have lost your salary.");
        return; // Приключва цялата програма
    }
}

int difference = salary - penalty; // Остатъчна заплата след глобите

Console.WriteLine(difference);
