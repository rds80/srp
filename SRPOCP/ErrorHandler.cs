using System.Net;
using static System.Console;

namespace srp.SRPOCP
{
    public static class ErrorHandler
    {
        public static bool HandleResponse(HttpStatusCode code)
        {
            if (code == HttpStatusCode.OK)
            {
                return true;
            }
            else if (code == HttpStatusCode.NotFound)
            {
                WriteLine("Countries API is momentarily unavailable");
                return false;
            }
            else if (code == HttpStatusCode.InternalServerError)
            {
                WriteLine("Countries API encountered an error, please try again");
                return false;
            }
            else
            {
                WriteLine("An error has occured while fetching the countries");
                return false;
            }
        }
    }
}