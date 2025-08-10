// Input data
int n = int.Parse(Console.ReadLine());

// Template data
int counter = 1;

// Calculations

for (int rows = 1; rows <= n; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        Console.Write(counter + " "); // 2 3
        counter++;

        if (counter > n)
        {
            break;
        }
    }
    Console.WriteLine(); // За отпечатване на ред между отделните редове

    if (counter > n)
    {
        break;
    }
}