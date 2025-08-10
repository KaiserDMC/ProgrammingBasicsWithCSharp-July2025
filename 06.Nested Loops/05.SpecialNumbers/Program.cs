// Input data
int N = int.Parse(Console.ReadLine());

// Template data
bool special = false;

// Calculations
for (int i = 1111; i <= 9999; i++)
{
    string currentNum = i.ToString(); // Разделяме числото на съставните цифри

    for (int j = 0; j < currentNum.Length; j++)
    {
        int divider = int.Parse(currentNum[j].ToString());

        if (divider == 0)
        {
            special = false;
            break;
        }

        if (N % divider == 0)
        {
            special = true;
        }
        else
        {
            special = false;
            break;
        }
    }

    if (special)
    {
        Console.Write($"{currentNum} ");
    }
}