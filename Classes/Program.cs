using System;


namespace Classes
{

    class ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter numerator");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter denominator");
                int den = Convert.ToInt32(Console.ReadLine());

                int result = num / den;
                Console.WriteLine(result);

            }
            catch(FormatException)
            {
                Console.WriteLine("Enter numbers only");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter numbers within the range : {0} to {1}",int.MinValue,int.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide number by zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error occured");
            }

        }
    }

    

}




