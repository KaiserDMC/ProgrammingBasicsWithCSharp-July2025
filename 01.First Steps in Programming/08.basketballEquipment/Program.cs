int costPerYear = int.Parse(Console.ReadLine());

double costShoes = costPerYear * 0.6;
double costOutfit = costShoes * 0.8;
double costBall = costOutfit * 0.25;
double costAccessories = costBall * 0.2;

double totalCost = costPerYear + costShoes + costOutfit + costBall + costAccessories;

Console.WriteLine(totalCost);