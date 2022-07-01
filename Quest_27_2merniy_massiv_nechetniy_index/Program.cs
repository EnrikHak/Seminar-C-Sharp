void FillArray(int[,] array) {

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
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void ChangeArray(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (i % 2 == 1 && j % 2 == 1) {
               array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}

int[,] arr = new int[3, 4];


FillArray(arr);
PrintArray(arr);
Console.WriteLine();
FillArray(arr);
ChangeArray(arr);
Console.WriteLine();
FillArray(arr);
PrintArray(arr);



