int[] FillArray(int Length) {

    int[] array = new int[Length];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

int [] CreateArrayRevers(int[] array) {

    int[] number = new int[array.Length];
    int Length = array.Length;

    for (int i = 0; i < array.Length; i++) {
        number[i] = array[Length - 1];
        Length = Length - 1;
    }
    return number;
}

void PrintArray(int[] array) {

    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");       
    }
}

Console.WriteLine("Введите длину массива: ");
int LengthArray = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(LengthArray);
int[] number = CreateArrayRevers(arr);

PrintArray(arr);
Console.WriteLine();
PrintArray(number);