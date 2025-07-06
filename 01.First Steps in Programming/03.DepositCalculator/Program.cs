double depositSum = double.Parse(Console.ReadLine());
int depositLength = int.Parse(Console.ReadLine());
double depositPercentage = double.Parse(Console.ReadLine());

double percentage = depositPercentage / 100;
double tax = depositSum * percentage / 12;
double sum = depositSum + (depositLength * tax);

//double sum = depositSum + depositLength * ((depositSum * depositPercentage / 100) / 12);

Console.WriteLine(sum);
