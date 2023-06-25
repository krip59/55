/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
Console.Clear();
Console.Write ("Введите элементы массива через пробел");
string elements = Console.Readline()!;
int baseArray = GetArrayFromString(elements);
Console.WriteLine(String.Join(" ", ResultArray(baseArray)));
Double[] GetArrayFromString(string stringArray)
{string[] nums = stringArray.Split(" ",StringSplitOptions.RemoveEmptyEntries);
double [] res = new double[nums.Length];
double minValua = nums.Length[0];
double maxValua = nums.Length[0];
double result;
for(double i = 1; i <res.Length+1; i++)
{
    if (resArray[i]<minValua)
   {
    minValua=resArray[i];
   } 
   if(resArray[i]<maxValua)
   {
    result = maxValua=resArray[i];
   }
}
Console.WriteLine("Разница максимального и минимального в массиве: {result}");
 {result}");
}