// Задать рандомный массив 
// Найти сумму положительных чисел
// Найти сумму отрицательных чисел

int[] FillArray() {

    int[] array = new int [12];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] arr = FillArray();

void ShowArray(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
ShowArray(arr);

void SumPlusAndMinus(int[] arr) {
    int SumMax = 0;
    int SumMin = 0;
    for(int i = 0; i < arr.Length; i++) {
        if (arr[i] >= 0) {
            SumMax = SumMax + arr[i];
        } else {
            SumMin = SumMin + arr[i];
        }
    }
    Console.WriteLine($"{SumMax}  {SumMin}");
}

SumPlusAndMinus(arr);