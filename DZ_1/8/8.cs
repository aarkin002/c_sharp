Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные от 1 до {0}: ", n);
for (int i = 1; i <= n; i++ ) {
    if (i % 2 == 0) {
        Console.WriteLine(i);
    }
}
