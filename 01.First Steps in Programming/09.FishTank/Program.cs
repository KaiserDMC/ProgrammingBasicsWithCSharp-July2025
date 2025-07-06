int length = int.Parse(Console.ReadLine()); // 85 cm
int width = int.Parse(Console.ReadLine()); // 75 cm 
int height = int.Parse(Console.ReadLine()); // 47 cm
double percentage = double.Parse(Console.ReadLine()); // 17

int volume = length * width * height; // Обем на аквариума cm3
double volumeInLitres = volume / 1000.0; // Обем на аквариума dm3 = l

double totalWater = volumeInLitres * (1 - percentage / 100);

Console.WriteLine(totalWater); // 246.68875