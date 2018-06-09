using System;
using CommitArt.Core;

namespace CommitArt.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            GitUpdater updater;

            if (args.Length == 4)
            {
                updater = ArgsInitGitUpdater(args);
            }
            else
            {
                updater = ConsoleInitGitUpdater();
            }

            if (!RandomChance())
            {
                Console.WriteLine("No activity");
                return;
            }

            updater.CloneRepo();
            updater.UpdateLocalDataFile();
            Console.WriteLine("Data file updated");
            updater.PushChangesToGithub();
            Console.WriteLine("data file committed to github");
        }

        private static Core.GitUpdater ConsoleInitGitUpdater()
        {
            string remoteUrl = "";
            string username = "";
            string password = "";
            string email = "";

            Console.WriteLine("Lets setup.");
            Console.WriteLine("What is the remote url?");
            remoteUrl = Console.ReadLine();
            Console.WriteLine("What is the username?");
            username = Console.ReadLine();
            Console.WriteLine("What is the password?");
            password = Console.ReadLine();
            Console.WriteLine("What is the associated email address?");
            email = Console.ReadLine();


            Core.GitUpdater updater = new Core.GitUpdater(remoteUrl, username, password, email);
            return updater;
        }

        private static Core.GitUpdater ArgsInitGitUpdater(string[] args)
        {
            Core.GitUpdater updater = new Core.GitUpdater(args[0], args[1], args[2], args[3]);
            return updater;
        }

        private static bool RandomChance()
        {
            // 1 in 10 chance
            Random rnd = new Random();
            int target = 5;
            return rnd.Next(10) == target;
        }
    }
}
