namespace CalculatorEx;

//Creation of delegate.
//public delegate decimal Cal(decimal numOne,decimal numTwo);


// Implementing Interface
public class ImplementInterface : IOperationMethods
{
   


    //Addition
    public decimal Addition()
    {
        decimal count = 0;
        string exp = Console.ReadLine();
        string[] expStr = exp.Split('+');
        for (int i = 0; i<expStr.Length; i++)
        {
          count += Convert.ToDecimal(expStr[i]);
        }
        return count;
        
    }

    //Subtraction  
    public decimal Subtraction()
    { 
        // decimal result = input_1 -  input_2;
        // return result;
        decimal count = 0;
        string exp = Console.ReadLine();
        string[] expStr = exp.Split('-');
        for (int i = expStr.Length; i>0; i--)
        {
            count =  Convert.ToDecimal(expStr[i-1]) - count;
            Console.WriteLine("the array is : "+expStr[i-1]);
        }

        return count;
        
    }
    //Multiplication
    public decimal Multiplication()
    {
        // decimal result = input_1 * input_2;
        // return result;
        decimal count = 1;
        string exp = Console.ReadLine();
        string[] expStr = exp.Split('*');
        
        for (int i = 0; i<expStr.Length; i++)
        {
            count *= Convert.ToDecimal(expStr[i]);
        }
        return count;
    }
    
    //Division  
    public  decimal Division()
    {
        // decimal result = (input_1) / (input_2);
        // return result;
        decimal count = 1;
        string exp = Console.ReadLine();
        string[] expStr = exp.Split('/');

        for (int i = expStr.Length; i>0; i--)
        {
            count = Convert.ToDecimal(expStr[i-1]) / count;
        }
        return count;
    }
    
    //power
   
    public  decimal Power()
    {
        
        decimal pow = 1;
        string exp = Console.ReadLine();
        string[] expStr = exp.Split('^');
        decimal secondNum = Convert.ToDecimal(expStr[1]);
        // Console.WriteLine(secondNum);
        for (int i = 0; i < expStr.Length; i++)
        {
            while (secondNum != 0)
            {
                pow *= Convert.ToDecimal(expStr[i]);
                secondNum--;
            }
        }
        return pow;
    }

 
}

