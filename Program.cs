// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input an increment value between 5 and 25.");
//Asking for user input.

double increment = Convert.ToDouble(Console.ReadLine());
double CAD = 0;
double US = 0;

if (increment >= 5 && increment <= 25)
{
    Console.WriteLine("CAD Increment Value == " + increment);
    Console.WriteLine("CAD" + "   " + "US$");
    //Headers
    while (CAD >= 0 && CAD <= 200)
    {
        double conversion = CAD * 0.792367;
        US = conversion;
        Console.WriteLine(CAD + "      " + US.ToString("F"));
        CAD += increment;
    }
}
else
{
    Console.WriteLine("Number input is invalid.");
}