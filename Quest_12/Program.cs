Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void tabl (int N) {
    for (int i = 0; i <= N; i++) {
        int num = i * i;
        Console.WriteLine($"{num}");
    }
}
tabl(N);