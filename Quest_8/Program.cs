Console.WriteLine("Введите число num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (((num1*num1) == num2) || ((num2*num2) == num1)) {
//     Console.WriteLine("Yes");
// } else {
//     Console.WriteLine("No");
// }

if ((Math.Pow(num1,2) == num2) || (Math.Pow(num2,2) == num1)) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}