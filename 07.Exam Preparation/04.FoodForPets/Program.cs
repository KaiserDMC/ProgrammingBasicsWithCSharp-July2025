// Input data
int days = int.Parse(Console.ReadLine()); // Брой дни
double totalAmountOfFood = double.Parse(Console.ReadLine()); // Общо налично количество храна

// Temp data
double totalBiscuitAmount = 0;
double totalDogEatenAmount = 0;
double totalCatEatenAmount = 0;
double totalEatenAmount = 0;

// Calculations
for (int i = 1; i <= days; i++)
{
    double dogFoodAmount = double.Parse(Console.ReadLine()); // Количество храна изядена от кучето
    double catFoodAmount = double.Parse(Console.ReadLine()); // Количество храна изядена от котката

    double dailyFoodAmount = dogFoodAmount + catFoodAmount; // Общо изядено количество за деня
    double biscuitAmount = dailyFoodAmount * 0.1; // Количество бисквитки

    if (i % 3 == 0)
        totalBiscuitAmount += biscuitAmount;

    totalDogEatenAmount += dogFoodAmount;
    totalCatEatenAmount += catFoodAmount;
    totalEatenAmount += dailyFoodAmount;
}

Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuitAmount, 0)}gr.");
Console.WriteLine($"{totalEatenAmount / totalAmountOfFood * 100:f2}% of the food has been eaten.");
Console.WriteLine($"{totalDogEatenAmount / totalEatenAmount * 100:f2}% eaten from the dog.");
Console.WriteLine($"{totalCatEatenAmount / totalEatenAmount * 100:f2}% eaten from the cat.");

