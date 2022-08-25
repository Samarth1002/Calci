
namespace CalculatorEx;

// Creation of delegates.
public delegate int Cal(int numOne, int numTwo);


// Implementing Interface
public class ImplementInterface : IOperationMethods
{
    //Addition
    public int Addition(int input_1, int input_2)
    {
        int result = input_1 + input_2;
        return result;
    }
    
    //Substraction  
        public int Subtraction(int input_1, int input_2)
        {
            int result = input_1 -  input_2;
            return result;
        }

}


//Inheriatance and abstraction
abstract class InheritedClass : ImplementInterface
{
    
    //abstract methods :
    // public abstract void exceptionalMethodOne();
    // public abstract void exceptionalMethodTwo();
    // public abstract void exceptionalMethodThree();
 
    
    //Multiplication  
    public static int Multiplication(int input_1, int input_2)
    {
        int result = input_1 * input_2;
        return result;
    }

    //Division  
    public static int Division(int input_1, int input_2)
    {
        int result = input_1 / input_2;
        return result;
    }
    
    //power
    public static int power(int input_1, int input_2)
    {
        int pow = 1;
        for (int i = 0; i < input_2; i++)
        {
            pow *= input_1;
        }
        return pow;
    }

}

  