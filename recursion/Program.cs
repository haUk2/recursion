using recursion;


Demo d = new Demo();
int val = 7;
int res = d.displayFibonacci(val);
Console.WriteLine("{0}th number in fibonacci series = {1}", val, res);
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
long fact = Demo.GetFactorial(number);
Console.WriteLine("{0} factorial is {1}", number, fact);
Console.ReadKey();