class Program
{
    static void Main()
    {
        // Вводим значения M и N
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        // Проверяем, чтобы M было не больше N
        if (M > N)
        {
            Console.WriteLine("Ошибка: M не может быть больше N.");
            return;
        }

        // Находим сумму натуральных элементов в промежутке от M до N
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        // Выводим результат
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {sum}");
    }
}
