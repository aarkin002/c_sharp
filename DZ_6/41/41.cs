Console.WriteLine("Введите кол-во чисел M: ");
int m = int.Parse(Console.ReadLine());
int cnt = 0;
for(int i=0; i < m; i++){
    Console.WriteLine("Введите {0} число: ", i+1);
    int tmp = int.Parse(Console.ReadLine());
    if(tmp>0){
        cnt++;
    }
}
Console.WriteLine("Cколько чисел больше 0:  {0}", cnt);