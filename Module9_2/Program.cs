namespace Module9_2;
class Program
{
    public delegate void SortEventHandler(int sortOrder);
    public event SortEventHandler SortEvent;

    private List<string> surnames = new List<string> { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов" };

    static void Main(string[] args)
    {
        Program program = new Program();
        program.SortEvent += program.OnSort;

        Console.WriteLine("1 is for ascending order and 2 is for descending one:");
        string input = Console.ReadLine();

        try
        {
            int sortOrder = int.Parse(input);
            program.SortEvent?.Invoke(sortOrder);
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect. Please, insert 1 or 2.");
        }

        foreach (string surname in program.surnames)
        {
            Console.WriteLine(surname);
        }
    }

    private void OnSort(int sortOrder)
    {
        if (sortOrder == 1)
        {
            surnames.Sort();
        }
        else if (sortOrder == 2)
        {
            surnames.Sort();
            surnames.Reverse();
        }
        else
        {
            Console.WriteLine("Incorrect order.");
        }
    }
}

