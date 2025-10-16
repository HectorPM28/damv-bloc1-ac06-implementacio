//PRECONDITION: The user is prompted to input two integers.
public class Sum2num
{
    public static void Main()
    {
        const string Msg_input = "Enter the first integer";
        const string Msg_input2 = "Enter the second integer";
        const string Msg_result = "The sum is: ";

        int num1;
        int num2;
        int result;

        Console.WriteLine(Msg_input);
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Msg_input2);
        num2 = Convert.ToInt32(Console.ReadLine());
        result = (num1 + num2);
        Console.WriteLine(Msg_result + result);
    }
}