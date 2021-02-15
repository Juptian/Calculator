using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You must put spaces between symbols for this to work!\n");
            double result = 0;
            bool goAgain = true;
            while(goAgain)
            {
                string[] arr = Console.ReadLine().Split();
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i == 1)
                    {
                        switch (arr[i])
                        {
                            case "+":
                                result = Convert.ToDouble(arr[i - 1]) + Convert.ToDouble(arr[i + 1]);
                                break;
                            case "-":
                                result = Convert.ToDouble(arr[i - 1]) - Convert.ToDouble(arr[i + 1]);
                                break;
                            case "*":
                                result = Convert.ToDouble(arr[i - 1]) * Convert.ToDouble(arr[i + 1]);
                                break;
                            case "/":
                                result = Convert.ToDouble(arr[i - 1]) / Convert.ToDouble(arr[i + 1]);
                                break;
                            case "^":
                                //MathF.Pow is a float for some reason?
                                result = MathF.Pow((float)Convert.ToDouble(arr[i - 1]), (float)Convert.ToDouble(arr[i + 1]));
                                Console.WriteLine($"{(float)Convert.ToDouble(arr[i - 1])}\n");
                                break;
                            //I gotta figure out how to add priority of operations
                            //Right now it does it left to right
                            //case "(":

                            //case ")":
                            case "%":
                                result = Convert.ToDouble(arr[i - 1]) % Convert.ToDouble(arr[i + 1]);
                                break;
                        }
                    } 
                    else
                    {
                        switch(arr[i])
                        {
                            case "+":
                                result += Convert.ToDouble(arr[i + 1]); 
                                break;
                            case "-":
                                result -= Convert.ToDouble(arr[i + 1]);
                                break;
                            case "*":
                                result *= Convert.ToDouble(arr[i + 1]);
                                break;
                            case "/":
                                result /= Convert.ToDouble(arr[i + 1]);
                                break;
                            case "^":
                                if (result != 0)
                                    result = MathF.Pow((float)result, (float)Convert.ToDouble(arr[i + 1]));
                                else
                                    result = MathF.Pow(1f, (float)Convert.ToDouble(arr[i - 1]));
                                Console.WriteLine($"{(float)Convert.ToDouble(arr[i-1])}\n");
                                break;
                            //case "(":
                        
                            //case ")":
                            case "%":
                                result %= Convert.ToDouble(arr[i + 1]);
                                break;
                        }
                    }
                }
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"Go again? (true for yes, false for no)");
                goAgain = Convert.ToBoolean(Console.ReadLine());
            }
        }
        

    }
}
