using System;

class Program
{
    static void Main()
    {
        // Define the rates for Indonesia and Singapore
        double indonesiaRate1 = 0.60;
        double indonesiaRate2 = 0.50;
        double indonesiaRate3 = 0.40;
        double singaporeRate = 0.60;

        // Prompt the user for the country code
        Console.WriteLine("Please enter country code (N for Indonesia, S for Singapore): ");
        char countryCode = char.ToUpper(Console.ReadKey().KeyChar);

        // Validate the country code
        if (countryCode != 'N' && countryCode != 'S')
        {
            Console.WriteLine("\nInvalid country code. Please enter 'N' for Indonesia or 'S' for Singapore.");
        }
        else
        {
            // Prompt the user for the total minutes
            Console.WriteLine("\nPlease enter time on the call (in minutes): ");
            int totalMinutes;
            if (!int.TryParse(Console.ReadLine(), out totalMinutes))
            {
                Console.WriteLine("Invalid input for minutes. Please enter a valid integer.");
                return;
            }

            // Calculate the total charge
            double totalCharge = 0.0;

            if (countryCode == 'N')
            {
                if (totalMinutes <= 60)
                {
                    totalCharge = totalMinutes * indonesiaRate1;
                }
                else if (totalMinutes <= 90)
                {
                    totalCharge = totalMinutes * indonesiaRate2;
                }
                else
                {
                    totalCharge = totalMinutes * indonesiaRate3;
                }
            }
            else // Singapore
            {
                totalCharge = totalMinutes * singaporeRate;
            }

            // Apply the discount for calls over 60 minutes
            if (totalMinutes > 60)
            {
                double discount = 0.05 * totalCharge;
                totalCharge -= discount;
            }

            // Display the total charge
            Console.WriteLine($"Total charge: RM{totalCharge:F2}");
        }
    }
}
