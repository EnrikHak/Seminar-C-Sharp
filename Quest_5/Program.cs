int Number = new Random().Next(100, 1000);
Console.WriteLine(Number);

int result = (Number / 100) * 10 + (Number % 10);
Console.WriteLine(result); //542 -> 52