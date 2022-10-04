int value = int.Parse(Console.ReadLine());

bool isGreaterThan10 = false;
Console.WriteLine("===Take 1===");

/*
 * I'm ignoring the "easiest" way to do this:
 *     isGreaterThan10 = (value > 10);
 */

// This is an if statement to decide what to put in a variable called isGreaterThan10.
if (value > 10)
{
	isGreaterThan10 = true;
}
else
{
	isGreaterThan10 = false;
}

Console.WriteLine(isGreaterThan10);

Console.WriteLine();
Console.WriteLine("===Take 2===");

isGreaterThan10 = (value > 10) ? true : false;

Console.WriteLine(isGreaterThan10);

string response = (value > 10) ? "Greater than ten" : "Less than or equal to ten";

Console.WriteLine(response);

Console.WriteLine(value > 10 ? "Greater than ten" : "Less than or equal to ten");


