// Создать массив из 123 чисел
// Посчитать сколько элементов попадает в отрезок от 10 до 99.

int[] FillArray() {

    int[] array = new int [123];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

int[] arr = FillArray();

void PrintArray(int[] array) {

    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindNumbers(int[] array) {

    int result = 0;
    int a = array[10];
    int b = array[99];
    for (int i = 0; i < array.Length; i++) {
        if (array[i] >= a || array[i] <= b) {
            result = result + 1;
        }
    }
    Console.WriteLine(result);
}

FindNumbers(arr);
Console.WriteLine();
PrintArray(arr);