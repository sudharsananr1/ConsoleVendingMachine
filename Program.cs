namespace VendingMachine
{
    class PROGRAM
    {
        static void Main(string[] args)
        {
            VENDINGMACHINE item = new VENDINGMACHINE();
            item.login();
            item.product();
        }
    }
    class VENDINGMACHINE : USERPRODUCT
    {
        public void login()
        {
            Console.WriteLine(" WELCOME.........");
            Console.WriteLine(" PLEASE ENTER THE ID NUMBER:");
            while (true)
            {
                string? idnum = Console.ReadLine();
                int num;
                bool result = int.TryParse(idnum, out num);
                if (result)
                {
                    int b = (1234);
                    int c = (12345);
                    int d = (123);
                    if ((num == b) || (num == c) || (num == d))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ENTER THE VALID ID NUMBER");
                    }
                }
            }
        }
    }
    class USERPRODUCT
    {
        public void product()
        {
            Console.WriteLine(" ACCESS GRANTED.........\n");
            Console.WriteLine(".......... THE ITEMS.........");
            Console.WriteLine("1.BISCUIT    RS:40");
            Console.WriteLine("2.CANDY      RS:15");
            Console.WriteLine("3.SODA       RS:20");
            Console.WriteLine("4.CHIPS      Rs:25");
            Console.WriteLine("\n");
            Console.WriteLine("..........ENTER THE ITEM NUMBER TO PURCHASE.........");
            while (true)
            {
                string? idnum = Console.ReadLine();
                int num;
                bool result = int.TryParse(idnum, out num);
                if (result)
                {
                    int b = 1;
                    int ca = 2;
                    int s = 3;
                    int c = 4;
                    if ((num == b))
                    {
                        biscuits bis = new biscuits();
                        bis.biscuit();
                    }
                    if (num == c)
                    {
                        chips Chip = new chips();
                        Chip.CHIP();

                    }
                    if (num == ca)
                    {
                        candys Candy = new candys();
                        Candy.candy();
                    }
                    if (num == s)
                    {
                        sodas Soda = new sodas();
                        Soda.soda();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("please select the product is available");
                }
            }
        }
    }
    class biscuits
    {
        public void biscuit()
        {
            Console.WriteLine("\n");
            Console.WriteLine("YOU WHERE PICKED BISCUIT");
            Console.WriteLine("BISCUIT= RS:40.");
            Console.WriteLine("\n");
            Console.WriteLine("ENTER THE COUNT OF ITEM :");
            string? countbiscuit = Console.ReadLine();
            int numbiscuit;
            bool resultbiscuit = int.TryParse(countbiscuit, out numbiscuit);
            if (numbiscuit < 5)
            {
                Console.WriteLine("COUNT OF BISCUIT:" + numbiscuit);
                int onebiscuit = 40;
                int countbiscuits = onebiscuit * numbiscuit;
                Console.WriteLine("Rs : " + countbiscuits);
                Console.WriteLine("SCAN HERE");
                Console.WriteLine("pay the amount of Rs: " + countbiscuits);
                string? payment = Console.ReadLine();
                int paymentmoney;
                bool paymentresult = int.TryParse(payment, out paymentmoney);
                Console.WriteLine("RS:" + paymentmoney);
                if (paymentresult)
                {
                    if (paymentmoney == countbiscuits)
                    {
                        Console.WriteLine(" your payment is succesufully completed. \n THANK YOU. \n VISIT AGAIN.......... ");
                    }
                    else
                    {
                        Console.WriteLine("Insuffient Payment....... \nPuchase Declined.\nTRY AGAIN.");
                    }
                }
            }
            else
            {
                Console.WriteLine("LIMIT MININUM 5");
            }
        }
    }
    class sodas
    {
        public void soda()
        {
            Console.WriteLine("\n");
            Console.WriteLine("YOU WHERE PICKED SODA");
            Console.WriteLine("chips= RS:20.");
            Console.WriteLine("\n");
            Console.WriteLine("ENTER THE COUNT OF ITEM :");
            string? countsoda = Console.ReadLine();
            int numsoda;
            bool resultsoda = int.TryParse(countsoda, out numsoda);

            if (numsoda < 5)
            {
                Console.WriteLine("LIMIT OF SODA:" + numsoda);
                int onesoda = 20;
                int countsodas = onesoda * numsoda;
                Console.WriteLine("Rs : " + countsodas);
                Console.WriteLine("SCAN HERE");
                Console.WriteLine("pay the amount of Rs: " + countsodas);

                string? payment = Console.ReadLine();
                int paymentmoney;
                bool paymentresult = int.TryParse(payment, out paymentmoney);
                Console.WriteLine("RS:" + paymentmoney);
                if (paymentresult)
                {
                    if (paymentmoney == countsodas)
                    {
                        Console.WriteLine(" your payment is succesufully completed. \n THANK YOU. \n VISIT AGAIN.......... ");
                    }
                    else
                    {
                        Console.WriteLine("Insuffient Payment....... \nPuchase Declined.\nTRY AGAIN.");
                    }
                }
            }
            else
            {
                Console.WriteLine("LIMIT MININUM 5");
            }
        }
    }
    class candys
    {
        public void candy()
        {
            Console.WriteLine("\n");
            Console.WriteLine("YOU WHERE PICKED CANDY");
            Console.WriteLine("chips= RS:15.");
            Console.WriteLine("\n");
            Console.WriteLine("ENTER THE COUNT OF ITEM :");
            string? countcandy = Console.ReadLine();
            int numcandy;
            bool resultcandy = int.TryParse(countcandy, out numcandy);

            if (numcandy < 5)
            {
                Console.WriteLine("COUNT OF CANDY:" + numcandy);
                int onecandy = 15;
                int countcandys = onecandy * numcandy;
                Console.WriteLine("Rs : " + countcandys);
                Console.WriteLine("SCAN HERE");
                Console.WriteLine("pay the amount of Rs: " + countcandys);
                string? paymentcandy = Console.ReadLine();
                int paymentmoney;
                bool paymentresult = int.TryParse(paymentcandy, out paymentmoney);
                Console.WriteLine("RS:" + paymentmoney);
                if (paymentresult)
                {
                    if (paymentmoney == countcandys)
                    {
                        Console.WriteLine(" your payment is succesufully completed. \n THANK YOU. \n VISIT AGAIN.......... ");
                    }
                    else
                    {
                        Console.WriteLine("Insuffient Payment....... \nPuchase Declined.\nTRY AGAIN.");
                    }
                }
            }
            else
            {
                Console.WriteLine("LIMIT MININUM 5");
            }
        }
    }
    class chips
    {
        public void CHIP()
        {
            Console.WriteLine("\n");
            Console.WriteLine("YOU WHERE PICKED CHIPS");
            Console.WriteLine("chips= RS:25.");
            Console.WriteLine("\n");
            Console.WriteLine("ENTER THE COUNT OF ITEM :");
            string? count = Console.ReadLine();
            int nu;
            bool results = int.TryParse(count, out nu);

            if (nu < 5)
            {
                Console.WriteLine("COUNT OF CHIPS:" + nu);
                int onechips = 25;
                int countchips = onechips * nu;
                Console.WriteLine("Rs : " + countchips);
                Console.WriteLine("SCAN HERE");
                Console.WriteLine("pay the amount of Rs: " + countchips);
                string? payment = Console.ReadLine();
                int paymentmoney;
                bool paymentresult = int.TryParse(payment, out paymentmoney);
                Console.WriteLine("RS:" + paymentmoney);
                if (paymentresult)
                {
                    if (paymentmoney == countchips)
                    {
                        Console.WriteLine(" your payment is succesufully completed. \n THANK YOU. \n VISIT AGAIN.......... ");
                    }
                    else
                    {
                        Console.WriteLine("Insuffient Payment....... \nPuchase Declined.\nTRY AGAIN.");
                    }
                }
            }
            else
            {
                Console.WriteLine("LIMIT MININUM 5");
            }
        }
    }
}
