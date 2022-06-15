void CordinatsSearch(int x, int y) {
    if (x == 0 || y == 0) {
        Console.WriteLine("Параметры некоректны");
    } else {
        if (x > 0 && y > 0) {
            Console.WriteLine("1");
        }
        if (x > 0 && y < 0) {
            Console.WriteLine("4");
        }
        if (x < 0 && y > 0) {
            Console.WriteLine("2");
        }
        if (x < 0 && y < 0) {
            Console.WriteLine("3");
        }
    }
}
CordinatsSearch(2,3);