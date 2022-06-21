// Создать рандомный массив
// Заменить положительные элементы на отрицательные
// Заменить отрицательные элементы на положительные

int[] FillArray() {

    int[] array = new int [10];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-99,100);
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

void reverth(int[] array) {
    int max = 0;
    int min = 0;
    for(int i = 0; i < array.Length; i++) {
    array[i] = array[i] * (-1);
      
    }
    Console.Write($"{min}  {max}");
}
reverth(arr);
ShowArray(arr);


//              Вариант 2

// int[] CreateFillArray() {
//     Console.Write("Input n: ");
//     int arraySize = Convert.ToInt32(Console.ReadLine());
//     Console.Write(arraySize);
//     int[] array = new int[arraySize];
//     int Length = array.Length;
//     for( int i = 0; i < Length; i++) {
//         array[i] = new Random().Next(-99, 100);
//     }
//     return array;
// } 

// int[] array = CreateFillArray();

// void PrintArray(int[] array) {
//     int Length = array.Length;
//     for(int i = 0; i < Length; i++) {
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine("");
// }

// int[] ConvertArray(int[] array) {
//     int Length = array.Length;
//     for (int i = 0; i < Length; i++) {
//         array[i] = array[i] * (-1);
//     }
//     return array;
// }

// PrintArray(array);
// ConvertArray(array);
// PrintArray(array);