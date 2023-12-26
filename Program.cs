internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выберете способ заполнения массива: \n" +
                "   1. Ввести c клавиатуры \n" +
                "   2. Использовать заданный на старте");

            int value = int.Parse(Console.ReadLine()!);
            string[] arr;

            if (value == 1)
                arr = Console.ReadLine()!.Split(" ");
            else
                arr = new string[] { "Hello", "2", "world", ":-)"};

            string[] newArr = FilterStrings(arr);
            Console.WriteLine(string.Join(", ", newArr));
    }
    
    static string[] SimpleFilterStrings(string[] arr)
    {
        return arr.Where(s => s.Length <= 3).ToArray();
    }

    static string[] FilterStrings(string[] arr)
    {
        int countElem = 0;
        foreach (string el in arr)
            if (el.Length <= 3)
                countElem++;
        
        string[] newArr = new string[countElem];
        int index = 0;
        foreach (string el in arr)
        {
            if (el.Length <= 3)
            {
                newArr[index] = el;
                index++;
            }
        }

        return newArr;
    }
}