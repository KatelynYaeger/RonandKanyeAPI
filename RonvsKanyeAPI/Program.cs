using static System.Net.WebRequestMethods;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What questions do you have for Ron and Kanye?");

            bool answer = true;

            while (true)
            {
                var userQuestion = Console.ReadLine();
                Console.WriteLine($"Kanye: {Ron_KanyeAPI.RonvsKanye.KanyeQuote()}");
                Console.WriteLine($"Ron: {Ron_KanyeAPI.RonvsKanye.RonQuote()}");
                Console.WriteLine("Any other questions?");

                var userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == "NO")
                {
                    answer = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Go ahead.");
                }
            }
        }
    }
}
