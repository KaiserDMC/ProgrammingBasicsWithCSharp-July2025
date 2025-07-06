int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int litresCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double totalCost = pens * 5.80 + markers * 7.20 + litresCleaner * 1.2;
double percentage = discountPercentage / 100.0;
double costAfterDiscount = (1 - percentage) * totalCost;
//double costAfterDiscount = (1 - (double)discountPercentage / 100) * totalCost;
Console.WriteLine(costAfterDiscount);