using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            '+' => a + b,
            '-' => a - b,5
            '*' => a * b,
            '/' => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Результат: {result}");
    }



    private void listbox1_SelectedIndexChanged(object sender, EventArgs e)


    {


        


    }
}