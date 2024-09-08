using Microsoft.VisualBasic.FileIO;
using System.Text;
using System.Xml.Schema;

namespace C_net
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select an option: ");
            Console.WriteLine("[1] Generate Random number\t[2] Generate Random Password");
            string ans=Console.ReadLine();
            if (ans == "1")
                GenerateRandomNum();
            else if(ans == "2")
                GenerateRandomStr();

        }
        const string Buffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789!@#$%^&*()_+";
        static void GenerateRandomNum()
        {
            var rand=new Random();
            var num=rand.Next(0,100000);
            Console.WriteLine($"Random number: {num}");
        }
        static void GenerateRandomStr()
        {
            var sb=new StringBuilder();
            var rand = new Random();
            while (16 > sb.Length)
            {
                var randomindx = rand.Next(0,Buffer.Length-1);
                sb.Append(Buffer[randomindx]);
                
            }
            Console.WriteLine($"Random String: {sb}");
        }

    }
}

    