// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Одномерный массив:");
int[] CreateArray( int l){
    int[]array = new int[l];
    var random = new Random();
    for( int i = 0; i<array.Length; i++){
        array[i]=random.Next();
    }
    return array;
}
void PrintArray(int []array){
    for( int i = 0; i<array.Length; i++){
        System.Console.Write($"{array[i]}, ");
}
System.Console.WriteLine();
}
Int64 GetSumOddi(int []array){
    Int64 sum = 0;
    for( int i = 0; i<array.Length; i++){
        if (i%2==0){ 
            Int64 TempConvert=Convert.ToInt64(array[i]);
            sum = sum + TempConvert;}
    }
    return sum;
}
var TestArray=CreateArray(5);
PrintArray(TestArray);
var SumOddi = GetSumOddi(TestArray);
Console.Write($"{SumOddi} - сумма всех нечетных элементов");



