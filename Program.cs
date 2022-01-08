using System;
using System.Text;

namespace RC4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option = DisplayMenu();

                if (option == 1)
                {   
                    Console.Write("Enter Password: ");
                    int ipwd = Convert.ToInt32(Console.ReadLine());
                    byte[] pwd = BitConverter.GetBytes(ipwd);
                    Console.Write("Enter Plaintext: ");
                    int idata = Convert.ToInt32(Console.ReadLine());
                    byte[] data = BitConverter.GetBytes(idata);
                    byte[] result = ED.Encrypt(pwd, data);
                    int iresult = BitConverter.ToInt32(result);
                    Console.WriteLine("CipherText: {0}", iresult);
                }

                else if (option == 2)
                {
                    Console.Write("Enter Password: ");
                    int ipwd = Convert.ToInt32(Console.ReadLine());
                    byte[] pwd = BitConverter.GetBytes(ipwd);
                    Console.Write("Enter Ciphertext: ");
                    int idata = Convert.ToInt32(Console.ReadLine());
                    byte[] data = BitConverter.GetBytes(idata);
                    byte[] result = ED.Encrypt(pwd, data);
                    int iresult = BitConverter.ToInt32(result);
                    Console.WriteLine("Plaintext: {0}", iresult);
                }

                else if (option == 0)
                {
                    Console.WriteLine("Goodbye, have a nice day!");
                    break;
                }
            }
        }

        static int DisplayMenu()
        {
            Console.WriteLine("---------------- M E N U --------------------");
            Console.WriteLine("[1] Encrypt your plain text");
            Console.WriteLine("[2] Decrypt your cipher text");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    }
}
