/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2
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
    int[] arr = GetRanomArray(3,100,999); 
    int = a;
    int sum = 0;              
             for (; i <= arr.Length; i++)
        {
            if (a%2 == 0)
            {
                sum = sum + 1;
            }
           
           
            Console.Write($"Четных чисел: {sum}");      
    
}