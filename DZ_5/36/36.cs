int[] arr = new int[8];
Random rnd = new Random();
for(int i = 0; i < 8; i++){
    arr[i] = rnd.Next(100, 999);
}
Console.WriteLine("Массив : [{0}]", string.Join(", ", arr));
int sum = 0;
for(int i = 0; i < 8; i++){
    if ((i+1)%2 != 0){
        sum += arr[i];
    }
}
Console.WriteLine("Сумма элементов стоящих на нечётных позициях в массиве ==  {0}", sum);