﻿//    Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.

string[] strings = new string[3]{"5", "ggg", "agagagga"};
int sum = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        sum++;
 E   }
}
string[] res = new string[sum];
int ind2 = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        res[ind2] = strings[i];
        ind2++;
    }
}