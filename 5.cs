using system;
namespace CSharpFundamentals
{
    Public Class Person
    {
        Public int Age;
    }
    Class Program
    {
        Static Void Main(String[]args)
        {
            var number =1;
            Increment(number);
            Console.WriteLine(number);
        }
        Public Static Void Increment (int number)
        {
            number +=10;
        }
        Public Static Void Make Old (Person person)
        {
            Person.Age +=10;
        }
    }
}