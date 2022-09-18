// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Массив с вещественными числами");
double[] CreateArray(int Length){
    double []array = new double[Length];
    var random =  new Random();
    for(int i=0; i<array.Length; i++){
        array[i]= random.NextDouble();
    }
    return array;
}
void PrintArray(double []array){
    for(int i=0; i<array.Length; i++){
        System.Console.Write($"|{array[i]}|");
}
System.Console.WriteLine();
}
double FindDiff(double []array ){
     double MinimumNumber = array[0];
     double MaximumNumber = array[0];
    for(int i=0; i<array.Length; i++){
      
        if (array[i] < MinimumNumber) {
             MinimumNumber = array[i];
             }
        if (array[i]>MaximumNumber){
            MaximumNumber=array[i];
        }
    }
    double diff = MaximumNumber - MinimumNumber;
    return diff;  
}
double[] TestArray = CreateArray(7);
PrintArray(TestArray);
System.Console.WriteLine($"{FindDiff(TestArray)} - разница между минимальным и максимальным элементами");  