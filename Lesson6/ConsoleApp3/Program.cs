/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/* Формула:
f(n) = f(n-1) + f(n-2) */

int[] Febonachi (int size) 
{

int[] Arr = new int[size];
Arr[0] = 0;
Arr[1] = 1;

for (int i = 2; i < size; i++ ) 
{
    
Arr[i] = Arr[i - 1] + Arr[i - 2];

}
return Arr;
}
int [] massive = Febonachi(10);
Console.WriteLine(string.Join(" ,", massive ));