using System;

namespace CommitArt.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.GitUpdater updater = ConsoleInitGitUpdater();
            updater.CloneRepo();
            Console.WriteLine(updater.GetDataFilePath());
            updater.AppendLine();
            Console.WriteLine("Data file updated");
            Console.ReadLine();
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
    }
}
