Console.WriteLine("Введите границу диапазона: ");
int n = Int32.Parse(Console.ReadLine());
for (int x = 2; x < n; x = x + 1)       
if (x % 2 == 0)            
Console.WriteLine(x);