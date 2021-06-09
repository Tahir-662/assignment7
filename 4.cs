using system;
namespace CSharpFundamentals
{
    {Static Void Main(String[]args)
     {
        var a =10;
        var b =a;
        b++;
        Console.WriteLine(String.format("a;{0},b;{1}",a,b));
        var array 1= new int[]{1,2,3};
        var array 2= array1;
        array 2[0]=0;
        Console.WriteLine(String.format("array1[0]:{0},array2[0],array2[0]));
     }
    }
}