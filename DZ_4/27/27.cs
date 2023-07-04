Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
List<int> aList = new List<int>();
while(a > 0)
    {
        aList.Add(a % 10);
        a = a / 10;
    }
int sum = 0;
foreach(int el in aList){
    sum += el;
}
Console.WriteLine("Сумма цифр введенного числа == {0}", sum, a);