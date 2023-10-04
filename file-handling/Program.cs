using System;


class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\temp\names.txt";
        using (StreamReader rd = new StreamReader(path))
        {
            string line;

            while ((line = rd.ReadLine()) != null)
            {
                string[] sp = line.Split(',');
                int month = int.Parse(sp[1].Substring(2, 2));
                switch (month)
                {
                    case 1:
                        Console.WriteLine("{0} Born in January", sp[0]);
                        break;
                    case 2:
                        Console.WriteLine("{0} Born in February", sp[0]);
                        break;
                    case 3:
                        Console.WriteLine("{0} Born in March", sp[0]);
                        break;
                    case 4:
                        Console.WriteLine("{0} Born in April", sp[0]);
                        break;
                    case 5:
                        Console.WriteLine("{0} Born in May", sp[0]);
                        break;
                    case 6:
                        Console.WriteLine("{0} Born in June", sp[0]);
                        break;
                    case 7:
                        Console.WriteLine("{0} Born in July", sp[0]);
                        break;
                    case 8:
                        Console.WriteLine("{0} Born in August", sp[0]);
                        break;
                    case 9:
                        Console.WriteLine("{0} Born in September", sp[0]);
                        break;
                    case 10:
                        Console.WriteLine("{0} Born in October", sp[0]);
                        break;
                    case 11:
                        Console.WriteLine("{0} Born in November", sp[0]);
                        break;
                    case 12:
                        Console.WriteLine("{0} Born in December", sp[0]);
                        break;
                }


            }
        }

    }
}

//inside c put temp and create names.txt file