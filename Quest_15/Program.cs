int sum (int N) {
    int result = 1;
    for (int i = 1; i <= N; i++) {
        result = result * i;
    }
    return result;
}

Console.WriteLine(sum(4));