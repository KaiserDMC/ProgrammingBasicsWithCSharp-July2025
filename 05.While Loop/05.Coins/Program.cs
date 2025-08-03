// Input data
int moneyToReturn = (int)(double.Parse(Console.ReadLine()) * 100); // Ресто за връщане
//double moneyToReturn = double.Parse(Console.ReadLine()) * 100;

// Template data
int coinCounter = 0;

// Calculations
while (moneyToReturn > 0) // Дали има ресто за връщане
{
    if (moneyToReturn >= 200) // Ако може да дадем монета от 2 лв
    {
        moneyToReturn -= 200; // Намаляме рестото с 2 лв
        coinCounter++; // Увеличаваме броя на дадените монети
    }
    else if (moneyToReturn >= 100) // Ако може да дадем монета от 1 лв
    {
        moneyToReturn -= 100; // Намаляме рестото с 1 лв
        coinCounter++;
    }
    else if (moneyToReturn >= 50)
    {
        moneyToReturn -= 50;
        coinCounter++;
    }
    else if (moneyToReturn >= 20)
    {
        moneyToReturn -= 20;
        coinCounter++;
    }
    else if (moneyToReturn >= 10)
    {
        moneyToReturn -= 10;
        coinCounter++;
    }
    else if (moneyToReturn >= 5)
    {
        moneyToReturn -= 5;
        coinCounter++;
    }
    else if (moneyToReturn >= 2)
    {
        moneyToReturn -= 2;
        coinCounter++;
    }
    else if (moneyToReturn >= 1)
    {
        moneyToReturn -= 1;
        coinCounter++;
    }
    //else
    //{
    //    moneyToReturn = 0;
    //}
}

Console.WriteLine(coinCounter); // Брой дадени монети