using System;
using System.Threading.Tasks;
using System.Linq;
using static System.Console;
using srp.ISP;
using srp.SRPOCP;
using srp.LSP;
using srp.DI;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunLSPExample();
            RunDIExample();
        }

        private static void RunDIExample()
        {
            var manager = new PostManager(new MockPostsService());
            manager.FilterPosts().Wait();
            Read();
        }

        private async static Task testCountries()
        {
            CountriesManager manager = new CountriesManager();
            CountryFormatter formatter = new CountryFormatter();
            var countries = await manager.GetEuropeanCountries();
            countries.ToList()
                      .ForEach(x =>
                      {
                          WriteLine(formatter.Format(x));
                      });
        }

        private static void RunSRPOCPExample()
        {
            testCountries().Wait();
            ReadKey();
        }

        private static void RunLSPExample()
        {
            Quiz quiz = new Quiz();
            quiz.ShowQuestions(quiz.TrueFalseQuestions);
        }
    }
}
