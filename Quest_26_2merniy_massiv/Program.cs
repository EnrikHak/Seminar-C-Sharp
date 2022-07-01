void CreateArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }    
}

void PrintArray(int[,] array) {
    
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = i + j;
        }
    }
}

int[,] arr = new int[3, 4];

CreateArray(arr);
PrintArray(arr);
Console.WriteLine();
CreateArray(arr);