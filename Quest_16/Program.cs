void arr(int[] array) {
    int Length = array.Length;
    for (int i = 0; i < Length; i++) {
        array[i] = new Random().Next(0,2);
    }
}
void Printarr(int[] array) {
    int Length = array.Length;
    for (int i = 0; i < Length; i++) {
        Console.Write ($"{array[i]}");
    }
}

int[] array = new int[8];
arr(array);
Printarr(array);