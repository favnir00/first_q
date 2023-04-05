string[] check_array(string[] ea)
{
    int k = 0;
    for (int j = 0; j < ea.GetLength(0); j++)
    {
        if (ea[j].Length < 4)
        {
            ea[k] = ea[j];
            k++;
        }
    }
    string[] sea = new string[k];
    for (int i = 0; i < k; i++)
    {
        sea[i] = ea[i];
    }
    return sea;
}

void print_array(string[] sa)
{
    for (int i = 0; i < sa.GetLength(0); i++)
    {
        Console.Write($"{sa[i]} \t");
    }
}

Console.Clear();
Console.WriteLine("Input elements, separated by space");
string[] elements_array = Console.ReadLine().Split(" ");
Console.WriteLine("Less then 3 symbols elements: ");
print_array(check_array(elements_array));
