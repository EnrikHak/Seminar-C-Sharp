Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b % a == 0) {
    Console.WriteLine("Кратно");
} else {
    Console.WriteLine(b % a);
}