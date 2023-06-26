﻿/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/ 


int[] GetRanomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
  for (int i = 0; i < size; i++)
    {
result[i] = new Random().Next(minValue,maxValue+1);
} 
return result;
}
int arrArray = GetRanomArray(4,0,100);
Console.WriteLine(arrArray.Where(i%2==0).Sum());