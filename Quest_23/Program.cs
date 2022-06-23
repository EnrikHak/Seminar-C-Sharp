Console.WriteLine("Проверим может ли введенные числа быть сторонами треугольника");

Console.WriteLine("Введите число 1: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int third = Convert.ToInt32(Console.ReadLine());

if (first < second + third && second < first + third && third < first + second) {
    Console.Write("Может быть треугольником");
} else {
    Console.WriteLine("Не может быть треугольником");
}
Console.WriteLine();