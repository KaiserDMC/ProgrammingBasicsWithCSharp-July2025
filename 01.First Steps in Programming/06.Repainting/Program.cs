int nylon = int.Parse(Console.ReadLine()); // 10
int paint = int.Parse(Console.ReadLine()); // 11
int bleacher = int.Parse(Console.ReadLine()); // 4
int hours = int.Parse(Console.ReadLine()); // 8

double priceNylon = 1.50;
double pricePaint = 14.50;
double priceBleacher = 5.0;

double sumNylon = (nylon + 2) * priceNylon; // 18
double sumPaint = (paint * 1.1) * pricePaint; // 175.45
double sumBleacher = bleacher * priceBleacher; // 20

double sumBeforeWork = sumNylon + sumPaint + sumBleacher + 0.40; // 213.85

double costWork = (sumBeforeWork * 0.30) * hours; // 513.24

double totalCost = sumBeforeWork + costWork; // 727.09

Console.WriteLine(totalCost);