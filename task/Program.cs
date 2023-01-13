// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решение не рекомендуем пользоваться коллекциями, лучше обойтись
// исключительно массивами.


Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string?[] array = new string?[n];
int count = 0;

for (int i = 0; i < array.Length; i++) {
    Console.Write("Введите элемент массива: ");
    array[i] = Console.ReadLine();

    if (array[i]?.Length <= 3) {
        count = count + 1;
    }
}

int j = 0;
string?[] array1 = new string?[count];

for (int i = 0; i < array.Length; i++) {
    if (array[i]?.Length <= 3) {
        array1[j] = array[i];
        j = j + 1;
    }
}

Console.WriteLine($"[{string.Join(", ", array1)}]");



