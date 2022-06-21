// Создать массив
// Определить, есть ли заданное число в  массиве
//
int[] FillArray() {

    int[] array = new int [10];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-99,1000);
    }
    return array;
}

int[] arr = FillArray();

void PrintArray(int[] array) {
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void InputNum(int[] array) {
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int Bool = 0;
    for(int i = 0; i < array.Length; i++) {        
        if (array[i] == number) {
            Console.WriteLine("Yes!");
            Bool = 1;
            break;
        }
    }
    if (Bool != 1) {
            Console.WriteLine("No!");
    }

}

PrintArray(arr);
InputNum(arr);