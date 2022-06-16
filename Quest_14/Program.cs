int cifri (int number) {
    int result = 0;

    char[] num = number.ToString().ToCharArray();
    for (int i = 0; i < num.Length; i++) {
        result = result + 1;
    }
    return result;
}

Console.WriteLine(cifri(1321111));