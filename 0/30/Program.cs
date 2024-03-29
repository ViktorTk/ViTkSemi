﻿//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// Random r = new Random();
// int a = new Random().Next(2, 10)
// int a = r.Next(2, 10);
// int a = r.Next(2);

Console.Clear();
Console.WriteLine("Введите число: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[");
for (int i = 0; i < num - 1; i++){
    Console.Write($"{array[i]}, ");
}Console.WriteLine($"{array[num - 1]}]");


int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}