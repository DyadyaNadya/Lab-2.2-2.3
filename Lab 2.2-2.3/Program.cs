public class Program
{
    public static void Main()
    {

        try
        {
            //Конструктор по умолчанию
            RightTriangle triangle1 = new RightTriangle();
            Console.WriteLine("Первый треугольник:");
            Console.WriteLine(triangle1.ToString());

            // Конструктор копирования
            RightTriangle triangle2 = new RightTriangle(triangle1);
            Console.WriteLine("\nКопия первого треугольника:");
            Console.WriteLine(triangle2.ToString());

            // Конструктор с параметрами 
            Console.WriteLine("\nВведите длину катета A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину катета B:");
            double b = Convert.ToDouble(Console.ReadLine());

            RightTriangle userTriangle = new RightTriangle(a, b);
            Console.WriteLine("\nТреугольник, созданный пользователем:");
            Console.WriteLine(userTriangle.ToString());

            // Тестирование унарных операций
            RightTriangle incrementedTriangle = ++triangle1;
            Console.WriteLine("\nТреугольник 1 после увеличения сторон в 2 раза:");
            Console.WriteLine(incrementedTriangle.ToString());

            RightTriangle decrementedTriangle = --triangle2;
            Console.WriteLine("\nТреугольник 2 после уменьшения сторон в 2 раза:");
            Console.WriteLine(decrementedTriangle.ToString());

            // Тестирование приведения типа к double
            double area = (double)triangle1;
            Console.WriteLine($"\nПлощадь первого треугольника: {area}");

            // Тестирование приведения типа к bool
            bool exists = triangle1;
            Console.WriteLine($"\nСуществует ли треугольник, введенный пользователем: {exists}");

            // Тестирование бинарных операций сравнения

            bool isLessOrEqual = triangle1 <= triangle2;
            bool isGreaterOrEqual = triangle1 >= userTriangle;
            Console.WriteLine($"\nПервый треугольник <= Второй треугольник: {isLessOrEqual}");
            Console.WriteLine($"Первый треугольник >= Пользовательский треугольник: {isGreaterOrEqual}");
        }
        catch
        {
            Console.WriteLine("Ошибка: нужно ввести положительное число!");
        }
    }
}

