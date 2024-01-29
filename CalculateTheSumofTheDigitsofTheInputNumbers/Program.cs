// See https://aka.ms/new-console-template for more information
Console.Write("Enter Number : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if(number.ToString().Length > 4)
{
    Console.WriteLine("Invalid input");
}
else
{
    for(int i = 0; i < 4; i++)
    {
        string n = number.ToString()[i].ToString();
        sum += Convert.ToInt32(n);
    }
}

Console.WriteLine(sum);