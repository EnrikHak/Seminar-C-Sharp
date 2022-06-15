void quartal (int quart) {
    if (quart < 1 || quart > 4) {
        Console.WriteLine("Wrong!");
    } else if (quart == 1) {
        Console.WriteLine("x > 0, y > 0");
    } else if (quart == 2) {
        Console.WriteLine("x > 0, y < 0");
    } else if (quart == 3) {
        Console.WriteLine("x < 0, y < 0");
    } else if (quart == 4) {
        Console.WriteLine("x < 0, y > 0");
    }
}
quartal(1);
quartal(2);
quartal(3);
quartal(4);
quartal(5);