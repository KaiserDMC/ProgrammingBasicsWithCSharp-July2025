// Input data
string flowerType = Console.ReadLine();
int numberOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

// Template data
double flowerPrice = 0;

// Calculations & Checks
switch (flowerType)
{
    case "Roses":
        flowerPrice = 5;
        if (numberOfFlowers > 80)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.1);
            //flowerPrice *= 0.9;
        }
        break;
    case "Dahlias":
        flowerPrice = 3.8;
        if (numberOfFlowers > 90)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.15);
            //flowerPrice *= 0.85;
        }
        break;
    case "Tulips":
        flowerPrice = 2.8;
        if (numberOfFlowers > 80)
        {
            flowerPrice = flowerPrice - (flowerPrice * 0.15);
            //flowerPrice *= 0.85;
        }
        break;
    case "Narcissus":
        flowerPrice = 3;
        if (numberOfFlowers < 120)
        {
            flowerPrice = flowerPrice * 1.15;
            //flowerPrice *= 1.15;
        }
        break;
    case "Gladiolus":
        flowerPrice = 2.5;
        if (numberOfFlowers < 80)
        {
            flowerPrice = flowerPrice * 1.20;
            //flowerPrice *= 1.20;
        }
        break;
}

double cost = flowerPrice * numberOfFlowers; // Колко струва да купим всички цветя
double difference = budget - cost; // Разликата между бюджета и цената на всички цветя

if (difference >= 0)
{
    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {difference:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
}