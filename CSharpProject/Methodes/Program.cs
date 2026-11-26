// void SayHello()
// {
//     Console.WriteLine("Hello World");
// }

// SayHello();

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//     Random random = new Random();
//     for (int i = 0 ; i < 5; i++)
//     {
//         Console.Write($"{random.Next(1,100)} ");
//     }
//     Console.WriteLine("");
// }

// //Calcul du temps pour les médicaments
// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// DisplayTimes();

// Console.WriteLine();


// void DisplayTimes()
// {
//     /* Format and display medicine times */
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
//     }
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// string[] ipv4Input = {"107.31.1.5","255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validRange = false;
// bool validZeroes = false;

// ValidateLength();
// ValidateZeroes();
// ValidateRange();

// foreach (string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip}is an invalid IPv4 address");
//     }
// }

// void ValidateLength()
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes()
// {
//     foreach (string number in address)
//     {
//         if(number.Length > 1 && number.StartsWith('0'))
//         {
//             validZeroes = false;
//             return;
//         }
//     }
//     validZeroes = true;
// }

// void ValidateRange()
// {    
//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }
// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     //Calculate the discounted price of the item
//     return items[itemIndex]* (1-discounts[itemIndex]); 
// }

//  bool TotalMeetsMinimum()
// {
//     //Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     //Format the double so only 2 decimal places are displayed
//     return input.ToString().Substring(0, 5);
// }

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
