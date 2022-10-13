class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 63
        //**Задача 63:**Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
        //N = 5-> "1, 2, 3, 4, 5"
        //N = 6-> "1, 2, 3, 4, 5, 6"

        //int.TryParse(Console.ReadLine(), out int result);
        //PrintEnumN(result);

        #endregion

        #region Задача 67
        //**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
        //453-> 12
        //45-> 9

        //Console.Write("Введите число: ");
        //int.TryParse(Console.ReadLine(), out int result);
        //Console.WriteLine(NumberSum(result));

        #endregion

        #region Задача 69
        //* *Задача 69:** Напишите программу, которая на вход принимает два числа A и B,
        //и возводит число А в целую степень B с помощью рекурсии.
        //A = 3; B = 5-> 243(3⁵)
        //A = 2; B = 3-> 8

        //Console.Write("Введите число которое будем возводить в степень: ");
        //int.TryParse(Console.ReadLine(), out var number);
        //Console.Write("Введите степень: ");
        //int.TryParse(Console.ReadLine(), out var pow);
        //Console.WriteLine($"{number} в степени {pow} = {NumberPow(number, pow)}");

        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 64
        //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
        //N = 5-> "5, 4, 3, 2, 1"
        //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

        //Console.Write("Введите число до которого вывести перечисление: ");
        //int.TryParse(Console.ReadLine(), out var result);
        //PrintReverseEnumN(result);

        #endregion

        #region Задача 66
        //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15-> 120
        //M = 4; N = 8. -> 30

        //Console.WriteLine("Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
        //Console.Write("Введите Мinimal: ");
        //int.TryParse(Console.ReadLine(), out var minimum);
        //Console.Write("Введите Maximum: ");
        //int.TryParse(Console.ReadLine(), out var maximum);
        //Console.WriteLine(SumEnumNumbers(minimum, maximum));

        #endregion

        #region Задача 68
        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        //m = 2, n = 3->A(m, n) = 9
        //m = 3, n = 2->A(m, n) = 29

        //Console.Write("Введите неотрицательное число m для функции Аккермана: ");
        //int.TryParse(Console.ReadLine(), out var m);
        //Console.Write("Введите неотрицательное число n для функции Аккермана: ");
        //int.TryParse(Console.ReadLine(), out var n);
        //if (m >= 0 && n >= 0)
        //{
        //    Console.WriteLine($"A({m}, {n}) = {AccermanFuncion(m, n)}");
        //}
        //else
        //{
        //    Console.WriteLine("Числа должны быть больше 0");
        //}
        #endregion

        #endregion
    }
    static int NumberPow(int number, int Pow, int result = 1)
    {
        if (Pow == 1)
        {
            return result *= number;
        }
        result *= number;
        return NumberPow(number, Pow - 1, result);
    }
    static int NumberSum(int number, int sum = 0)
    {
        if (number < 10)
        {
            return sum + number;
        }
        sum += number % 10;
        return NumberSum(number / 10, sum);
    }
    static void PrintEnumN(int number)
    {
        if (number == 1)
        {
            Console.Write(1 + "\t");
            return;
        }
        PrintEnumN(number - 1);
        Console.Write(number + "\t");
    }
    static void PrintReverseEnumN(int number, int counter = 1)
    {
        if (counter == number)
        {
            Console.Write(counter + "\t");
            return;
        }
        PrintReverseEnumN(number, counter + 1);
        Console.Write(counter++ + "\t");
    }
    static int SumEnumNumbers(int minimal, int maximum, int sum = 0)
    {
        if (minimal == maximum)
        {
            return sum += maximum;
        }
        sum += minimal;
        return SumEnumNumbers(minimal + 1, maximum, sum);
    }
    static int AccermanFuncion(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if ((m != 0) && (n == 0))
        {
            return AccermanFuncion(m - 1, 1);
        }
        else
        {
            return AccermanFuncion(m - 1, AccermanFuncion(m, n - 1));
        }
    }
}