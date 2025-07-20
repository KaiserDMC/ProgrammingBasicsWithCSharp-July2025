// Input data
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());

// Template data
double result = 0;
string isEven = "odd"; // isEven = "" -> има нужда от още един else!

if (op == '+' || op == '-' || op == '*')
{
    switch (op)
    {
        case '+':
            result = n1 + n2;
            break;
        case '-':
            result = n1 - n2;
            break;
        case '*':
            result = n1 * n2;
            break;
    }

    if (result % 2 == 0) // Четен или не?
    {
        isEven = "even";
    }

    Console.WriteLine($"{n1} {op} {n2} = {result} - {isEven}");
}
else if (op == '/')
{
    if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero");
    }
    else
    {
        result = n1 / (double)n2;
        Console.WriteLine($"{n1} {op} {n2} = {result:f2}");
    }
}
else if (op == '%')
{
    if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero");
    }
    else
    {
        result = n1 % n2;
        Console.WriteLine($"{n1} {op} {n2} = {result}");
    }
}