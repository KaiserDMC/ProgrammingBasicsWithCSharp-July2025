// Input data
int age = int.Parse(Console.ReadLine()); // Lily's age
double priceWashingMachine = double.Parse(Console.ReadLine());
int priceSingleToy = int.Parse(Console.ReadLine());

// Template data
int numberToys = 0;
double sum = 0;
double receivedMoney = 0;

// Calculations
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0) // четен РД
    {
        receivedMoney += 10; // 0 -> 10; 10 -> 20; 20 -> 30....
        sum += receivedMoney;
        sum -= 1; // Брат на Лили, взема 1 лв.
    }
    else // нечетен РД
    {
        numberToys++;
    }
}

double moneyToys = numberToys * priceSingleToy; // Брой играчки, умпожени с цена на играчка
double totalMoney = sum + moneyToys; // Сумата на продадените играчки и парите получила на четните РД

double difference = totalMoney - priceWashingMachine; // разлика
if (difference >= 0) // Парите са и стигнали за пералнята
{
    Console.WriteLine($"Yes! {difference:f2}");
}
else
{
    Console.WriteLine($"No! {Math.Abs(difference):f2}");
}