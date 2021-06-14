using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
             try
             {
                    Console.Write("Please enter num1: ");
                    string num1str = Console.ReadLine();
                    int num1 = int.Parse(num1str);

                    Console.Write("Please enter num2: ");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
             }
             catch(FormatException e)
             {
                    Console.WriteLine("Enter a number!!!");
             }
             catch (OverflowException e)
             {
                    Console.WriteLine("NUMBER TOO BIG!!!");
             }
             catch (DivideByZeroException e)
             {
                    Console.WriteLine("Denominator is 0 !!! BAD");
             }
            catch (Exception e)
             {
                    Console.WriteLine("Error! {0}", e.Message);
                    Console.WriteLine("Exception type: " + e.GetType());
             }
             finally
             {
                Console.WriteLine("This section always excecutes!");
             }
                Console.WriteLine("Good Bye!");
            
        }
    }
}
