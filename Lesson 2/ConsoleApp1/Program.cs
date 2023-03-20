using System.Collections.Immutable;
using System.ComponentModel.Design;

public static class Program
{
    public static void Main()
    {
        Console.Write($"Введите количество элементов массива:\t");
        int elem;
        bool result = int.TryParse(Console.ReadLine(), out elem);
        if (result != false)
        {
            if (elem <= 1)
            {
                Console.WriteLine($"ведите значение больше 1");
                return;
            }

            int[] array = new int[elem];

            for (int i = 0; i < elem; i++)
            {
                Console.Write($"Введите {i + 1} значение элемента массива\t");
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Недопустимое значение");
                    return;
                }

            }
            int max = array[0];
            int secondmax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondmax = max;
                    max = array[i];

                }
                else
                      if (array[i] > secondmax && array[i] != max)
                {
                    secondmax = array[i];
                }
            }

            if (secondmax != 0)
            {
                Console.WriteLine($"Второй максимальный элемент: {secondmax}");
            }
            else
            {
                Console.WriteLine("Второго максимального элемента не существует");

            }
        }
        else
        {
            Console.WriteLine("Недопустимо вводить буквы \nlol"); 
            return;
        }
    }
}