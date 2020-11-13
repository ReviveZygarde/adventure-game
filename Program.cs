using System.Security.Cryptography.X509Certificates;
using static System.Console;
//Game created by Andrew Peterson -- STARTED on 2020/10/7
//Thanks goes to programmingisfun.com for giving me this wonderful tutorial. (used under CC BY. https://creativecommons.org/licenses/by/4.0/)
//Thanks also go to my online friend Silver for helping me with coding some small parts.
//Credits will be given to parts of the code along the way.
//ALL ASCII art belong to their original creators since most of these were uploaded anonymously.
namespace Adventure_Game
{
    class Program
    {
        static void Main()
        {
            startup Game = new startup();
            ReadKey(true);
        }
    }
}
