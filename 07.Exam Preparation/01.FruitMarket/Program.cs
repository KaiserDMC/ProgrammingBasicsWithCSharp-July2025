// Input data
double priceStrawberries = double.Parse(Console.ReadLine()); // Цена на ягоди в лв. за кг.
double kilosBananas = double.Parse(Console.ReadLine()); // Количество банани в кг.
double kilosOranges = double.Parse(Console.ReadLine()); // Количество портокали в кг.
double kilosRaspberries = double.Parse(Console.ReadLine()); // Количество малини в кг.
double kilosStrawberries = double.Parse(Console.ReadLine()); // Количество ягоди в кг.

double priceRaspberries = priceStrawberries / 2;
double priceOranges = priceRaspberries * 0.6;
// double priceOranges = priceRaspberries - (priceRaspberries * 0.4);
double priceBananas = priceRaspberries - (priceRaspberries * 0.8);

double totalPrice = kilosStrawberries * priceStrawberries + kilosBananas * priceBananas + kilosOranges * priceOranges + kilosRaspberries * priceRaspberries;

Console.WriteLine($"{totalPrice:f2}");