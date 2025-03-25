using System;


class Hello()
{
    static void Main()
    {
        //USER INTERFACE--
        Console.WriteLine("Welcome to the Calculator\nType the digits you wanna calculate\nYou can type \"stop\" to stop this\n(Only with these \"-,+,/,*\")");



        //LOGIC--


        while (true)
        {
            try
            {

                string digit = Console.ReadLine();

                if (digit.Contains("-"))
                {
                    string[] h = digit.Split('-');

                    int dh = Convert.ToInt32(h[0]);
                    int hd = Convert.ToInt32(h[1]);
                    int solution = dh - hd;
                    Console.WriteLine(solution);


                }
                else if (digit.Contains("+"))
                {
                    string[] h = digit.Split('+');

                    int dh = Convert.ToInt32(h[0]);
                    int hd = Convert.ToInt32(h[1]);
                    int solution = dh + hd;
                    Console.WriteLine(solution);


                }
                else if (digit.Contains("-"))
                {
                    string[] h = digit.Split('-');

                    int dh = Convert.ToInt32(h[0]);
                    int hd = Convert.ToInt32(h[1]);
                    int solution = dh - hd;
                    Console.WriteLine(solution);


                }
                else if (digit.Contains("*"))
                {
                    string[] h = digit.Split('*');

                    int dh = Convert.ToInt32(h[0]);
                    int hd = Convert.ToInt32(h[1]);
                    int solution = dh * hd;
                    Console.WriteLine(solution);


                }
                else if (digit.Contains("/"))
                {
                    string[] h = digit.Split('/');

                    double dh = Convert.ToDouble(h[0]);
                    double hd = Convert.ToDouble(h[1]);
                    double solution = dh / hd;
                    Console.WriteLine(solution);



                }
                else if (digit == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("It is not the best calculator so be nice and use simple expressions");
                }

            }
            catch
            {
                Console.WriteLine("Broo this is for fun not a actuall calculator just put simple expressions");
            }



        }








    }
}