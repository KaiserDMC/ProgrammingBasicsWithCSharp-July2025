int chicken = int.Parse(Console.ReadLine()); // 2
int fish = int.Parse(Console.ReadLine()); // 4
int veg = int.Parse(Console.ReadLine()); // 3

double costOfMenus = chicken * 10.35 + fish * 12.40 + veg * 8.15; // 94.75
double costDessert = costOfMenus * 0.2; // 18.95

double totalCost = costOfMenus + costDessert + 2.5;

Console.WriteLine(totalCost); // 116.20