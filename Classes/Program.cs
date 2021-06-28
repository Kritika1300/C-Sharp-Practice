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
                int num;
                bool isConversionSuccessful = Int32.TryParse(Console.ReadLine(),out num);

                if(isConversionSuccessful)
                {
                    Console.WriteLine("Enter denominator");
                    int den;
                    bool isdenConversionSuccessful = Int32.TryParse(Console.ReadLine(), out den);

                    if (isdenConversionSuccessful && den != 0)
                    {
                        int result = num / den;
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine(den);
                        if(den == 0)
                        {
                            Console.WriteLine("Division by zero invalid");
                    
                        }
                        
                        {
                            Console.WriteLine("Enter a NUMBER between {0} to {1}", int.MinValue, int.MaxValue);
                        }
                    }
                      
                }
                else
                {
                    Console.WriteLine("Enter a NUMBER between {0} to {1}",int.MinValue,int.MaxValue);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Error occured");
            }

        }
    }

    

}




