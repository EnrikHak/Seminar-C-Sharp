int[] FillArray() {

    int[] array = new int [10];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1,20);
    }
    return array;
}


void PrintArray(int[] array) {

    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Proizv(int[] array) {
    
    int[] newArray = new int [10];
    int Length = array.Length;

    for (int i = 0; i < array.Length/2; i++) {
        newArray[i] = array[i] * array[Length -1];
        Length = Length - 1;
    }
    return newArray;
}

int[] arr = FillArray();
int[] newNamber = Proizv(arr);
PrintArray(arr);
PrintArray(newNamber);