int[] arr = new int[8];
Random rnd = new Random();
for(int i = 0; i < 8; i++){
    arr[i] = rnd.Next(100, 999);
}
Console.WriteLine("Массив : [{0}]", string.Join(", ", arr));
int cnt = 0;
foreach(int a in arr){
    if (a%2 == 0){
        cnt += 1;
        }
}
Console.WriteLine("Кол-во четных чисел в массиве ==  {0}", cnt);