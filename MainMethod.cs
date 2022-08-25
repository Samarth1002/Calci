namespace CalculatorEx;

public class MainMethod
{
   
        public static ImplementInterface i = new ImplementInterface();
        
        static void Main(string[] args)
        {
            int action =0;
            while (action != 6)
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Press 5 for Power");
                Console.WriteLine("Press 6 for Exit \n");

                action = Convert.ToInt32(Console.ReadLine());

                int input_1=0;
                int input_2=0;
                
                if (action != 6)
                {
                    Console.WriteLine("Enter 1st input");
                     input_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd input");
                     input_2 = Convert.ToInt32(Console.ReadLine());
                }
               
                int result = 0;
                switch (action)
                {
                    case 1:
                    {
                       // result = i.Addition(input_1, input_2);
                       
                       //Instantiating delegate.
                       Cal add = new Cal(i.Addition);
                       result = add(input_1, input_2);
                      //  result = i.Addition(input_1, input_2);

                        break;
                    }
                    case 2:
                    {
                       // result = i.Subtraction(input_1, input_2);
                       
                       //Instantiating delegate.
                       Cal sub = new Cal(i.Subtraction);
                       result = sub(input_1, input_2);
                       break;
                    }
                    case 3:
                    {
                       // result = InheritedClass.Multiplication(input_1, input_2);
                       
                       //Instantiating delegate.
                       Cal mul = new Cal(InheritedClass.Multiplication);
                       result = mul(input_1, input_2); 
                       break;
                    }
                    case 4:
                    {
                       // result = InheritedClass.Division(input_1, input_2);
                       
                       //Instantiating delegate.
                       Cal div = new Cal(InheritedClass.Division);
                       result = div(input_1, input_2); 
                       break;
                    }
                    case 5:
                    {
                        //result = InheritedClass.power(input_1, input_2);
                        
                        //Instantiating delegate.
                        Cal pow = new Cal(InheritedClass.power);
                        result = pow(input_1, input_2);
                        break;
                    }
                    case 6:
                    {
                        break;
                    }
                    
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }

                Console.WriteLine("The result is {0}", result);
                Console.ReadKey();
            }
        }
    
}