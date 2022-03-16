// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Prime Number !");

{
    int num = 0;
    int temp = 0;
    int remainder = 0;
    int reverse = 0;
    {
        Console.WriteLine("Enter an integer \n");
    }
    num = Convert.ToInt32(Console.ReadLine());

    temp = num;
    while (num > 0)
    {
        remainder = num % 10;
        reverse = reverse * 10 + remainder;
        num /= 10;
    }
    Console.WriteLine("Given number is = {0}", temp);
    Console.WriteLine("Its reverse is = {0}", reverse);
}