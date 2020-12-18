using System;
using System.Net;
using System.Net.NetworkInformation;

namespace RabbitHacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Login";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Username: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Login();
        }

        static void Login()
        {
            string user = Console.ReadLine();

            if (user == "admin")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Password: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Password();
            }
            else
            {
                Console.WriteLine("Username is incorrect!");
                Login();
            }
        }

        static void Password()
        {

            string password = Console.ReadLine();

            if (password == "P@ssword123")
            {
                Console.Clear();
                Rabbit();
            }
            else
            {
                Console.WriteLine("Password is incorrect!");
                Password();
            }
        }

        static void Rabbit()
        {
            Console.Title = "Rabbit Hacker";
            Console.ForegroundColor = ConsoleColor.Green;
            Hack();
        }

        static void Hack()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   ▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ ░▀░ ▀▀█▀▀ 　 ▒█░▒█ █▀▀█ █▀▀ █░█ █▀▀ █▀▀█ ");
            Console.WriteLine("   ▒█▄▄▀ █▄▄█ █▀▀▄ █▀▀▄ ▀█▀ ░░█░░ 　 ▒█▀▀█ █▄▄█ █░░ █▀▄ █▀▀ █▄▄▀ ");
            Console.WriteLine("   ▒█░▒█ ▀░░▀ ▀▀▀░ ▀▀▀░ ▀▀▀ ░░▀░░ 　 ▒█░▒█ ▀░░▀ ▀▀▀ ▀░▀ ▀▀▀ ▀░▀▀ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please use command: /help for more commands!");
            Console.WriteLine("");
            Commands();
        }

        static void Commands()
        {
            string commands = Console.ReadLine();

            switch (commands)
            {
                case "/help":
                    Help();
                    break;
                case "/clear":
                    Clear();
                    break;
                case "/color":
                    Colors();
                    break;
                case "/exit":
                    Exit();
                    break;
                case "/time":
                    Time();
                    break;
                case "/beep":
                    Beep();
                    break;
                case "/ip":
                    Ip();
                    break;
                case "/ping":
                    Ping();
                    break;
                case "/os":
                    Os();
                    break;
                default:
                    Console.WriteLine("Unknown command!");
                    Commands();
                    break;
            }
        }

        static void Help()
        {
            Console.WriteLine("");
            Console.WriteLine(" _________________________________________________________");
            Console.WriteLine("|                    Available commands:                  |");
            Console.WriteLine("|_________________________________________________________|");
            Console.WriteLine("|   /help  - show all commands                            |");
            Console.WriteLine("|   /clear - clear the command prompt                     |");
            Console.WriteLine("|   /color - change text color                            |");
            Console.WriteLine("|   /time  - show the current time                        |");
            Console.WriteLine("|   /beep  - make a beep                                  |");
            Console.WriteLine("|   /ip    - show your local ip adress                    |");
            Console.WriteLine("|   /ping  - Get reaction time of specific website        |");
            Console.WriteLine("|   /os    - Show operating system informations           |");
            Console.WriteLine("|   /exit  - close command prompt                         |");
            Console.WriteLine("|_________________________________________________________|");
            Console.WriteLine("");
            Commands();
        }

        static void Clear()
        {
            Console.Clear();
            Hack();
        }

        static void Colors()
        {
            Console.WriteLine("Witch color do you want?");
            string color = Console.ReadLine();

            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Clear();
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Clear();
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Clear();
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Clear();
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Clear();
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Clear();
                    break;
                case "pink":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Clear();
                    break;
                case "purple":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Clear();
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Clear();
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Clear();
                    break;
                default:
                    Console.WriteLine("Available colors: green, blue, red, yellow, white, magenta, pink, purple, cyan, gray.");
                    Commands();
                    break;
            }
        }

        static void Exit()
        {
            Environment.Exit(0);
        }

        static void Time()
        {
            Console.WriteLine("");
            string time = DateTime.Now.ToString();
            Console.WriteLine("Your current time is: " + time);
            Console.WriteLine("");
            Commands();
        }

        static void Beep()
        {
            Console.WriteLine("Which frequency of beep do you want?  (Choose number which is more than 100!)");
            string freq = Console.ReadLine();
            try
            {
                int freqn = int.Parse(freq);
                Console.WriteLine("Duration of beep:  (Choose number which is more than 1000!)");
                string dur = Console.ReadLine();
                try
                {
                    int durn = int.Parse(dur);
                    Console.Beep(freqn, durn);
                }
                catch (Exception)
                {
                    Console.WriteLine(dur + " is not a number!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(freq + " is not a number!");
            }
            Commands();
        }

        static void Ip()
        {
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            Console.WriteLine("");
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }
            Console.WriteLine("");
            Commands();
        }

        static void Ping()
        {
            Console.WriteLine("Which website do you want to ping?");
            string web = Console.ReadLine();
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Replay from " + web + ": " + new Ping().Send(web).RoundtripTime.ToString() + "ms");
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Can't receive ping from: " + web);
                Console.WriteLine("");
            }
            Commands();
        }

        static void Os()
        {
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Current OS Information:");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Platform: {0:G}", Environment.OSVersion.Platform);
            Console.WriteLine("Version String: {0}", Environment.OSVersion.VersionString);
            Console.WriteLine("Version Information:");
            Console.WriteLine("   Major: {0}", Environment.OSVersion.Version.Major);
            Console.WriteLine("   Minor: {0}", Environment.OSVersion.Version.Minor);
            Console.WriteLine("Service Pack: '{0}'", Environment.OSVersion.ServicePack);
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            Commands();
        }
    }
}
