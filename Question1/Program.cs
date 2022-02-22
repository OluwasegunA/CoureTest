public class Program{
  public Program(){}
  public static int totalScore(int[] arr){
    int result = 0;

    for(int i =0; i< arr.Length; i++){
      result = arr[i] %2 ==0 ? result +1: result+3;
    }

    for(int i =0; i< arr.Length; i++){
      if(arr[i] ==8){
        result = result + 5;
      }
    }

    Console.WriteLine($"Total Score for the array is: {result}");

    return result;
  }

  public static void Main(string[] args){
    int [] arr = {1,2,3,4,5};
    int [] arr1 = {15,25,35};
    int [] arr2 = {8,8};
    var result = Program.totalScore(arr2);

    Console.WriteLine(result);
  }
}
