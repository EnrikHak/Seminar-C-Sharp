int sum (int a) {
    int result = 0;
    for (int i = 0; i <= a; i++) {
        result = result + i;
    }
    return result;
}

Console.WriteLine(sum(53));
Console.WriteLine(sum(10));
Console.WriteLine(sum(34));