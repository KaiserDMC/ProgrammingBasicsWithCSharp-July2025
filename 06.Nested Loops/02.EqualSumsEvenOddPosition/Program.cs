// Input data
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

// Template data
int sumOdd;
int sumEven;

// Calculations
for (int i = firstNum; i <= secondNum; i++)
{
    sumEven = 0;
    sumOdd = 0;

    string currentNum = i.ToString(); // Превръща настоящото число в текст, за да го разделим на отделни цифри в последствие

    for (int j = 1; j <= currentNum.Length; j++) // Вътрешен цикъл до дължитаната на числото
    {
        int k = j - 1;
        if (j % 2 == 0) // Четна позиция
        {
            sumEven += currentNum[k]; // Взема цифрата от позиция j в числото currentNum
            // sumEven += int.Parse(currentNum[k]);
        }
        else
        {
            sumOdd += currentNum[k]; // Взема цифрата от позиция j в числото currentNum
        }
    }

    if (sumEven == sumOdd)
    {
        Console.Write(currentNum + " ");
    }
}
