// string firstName = "Bob";
// int nombreEntier = 3;
// float nbAVirgule = 34.4F;

// Console.WriteLine("Hello, " + firstName + "! You have " + nombreEntier + " messages in your inbox. The temperature is " + nbAVirgule + " celsius");

String firstName = "Bob";
int secondNumber = 7;
Console.WriteLine(firstName + " sold " + (secondNumber + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient} ");

int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);

int fahrenheit = 94;
decimal celsius = (fahrenheit - (decimal)32) * 5m / 9m;
Console.WriteLine($" The temperature is {celsius} Celsius.");