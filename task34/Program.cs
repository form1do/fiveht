// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Int32[] GenArray ( int lenth){
    int[]arr= new int[lenth];
    var random = new Random();
for (int i=0; i<arr.Length; i++ ){
   arr[i]= random.Next(100, 1000);
}
return arr;
}
void PrintArray( int []arr){
    for(var i=0; i<arr.Length;i++){
        System.Console.Write($"{arr[i]}, ");
    }
    System.Console.WriteLine();
}
int SearchHonest( int[]arr){
    int j=0;
    for(int i=0; i<arr.Length;i++){
        if (arr[i]%2==0){j++;}

    }
return j;
}
var rand = new Random();
int size = Convert.ToInt32(rand.Next(5,100));
var array = GenArray(size);
PrintArray(array);
var NumberofHonest = SearchHonest(array);
System.Console.WriteLine(NumberofHonest);