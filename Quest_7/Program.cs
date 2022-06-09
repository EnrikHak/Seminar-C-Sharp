Console.WriteLine("Введите число Number: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 7 == 0 && Number % 23 == 0) {
    Console.WriteLine("Yes");
} else { 
    Console.WriteLine("No");
}