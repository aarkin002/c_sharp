string[] arr = new string[8];
for(int i = 0; i < 8; i++){
    Console.WriteLine("Введите {0} число", i);
    arr[i] = Console.ReadLine();
}
 Console.WriteLine("[{0}]", string.Join(", ", arr));