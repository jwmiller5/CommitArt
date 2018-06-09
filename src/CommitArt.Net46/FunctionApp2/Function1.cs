using System;
using CommitArt.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */2 * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            try
            {
                log.Info($"{DateTime.Now}: Setting up git");
                var updater = AppSettingsInitGitUpdater();
                log.Info($"{DateTime.Now}: Getting git repo {updater.EchoStatus()}");
                updater.CloneRepo();
                updater.UpdateLocalDataFile();
                log.Info($"{DateTime.Now}: Data File updated");
                updater.PushChangesToGithub();
                log.Info($"{DateTime.Now}: GitHub updated");
            }
            catch (Exception e)
            {
                log.Error($"{DateTime.Now}: {e.Message} - {e.StackTrace}");
            }
        }

        private static GitUpdater AppSettingsInitGitUpdater()
        {
            string remoteUrl = Environment.GetEnvironmentVariable("GitRemoteUrl");
            string username = Environment.GetEnvironmentVariable("GitUsername");
            string password = Environment.GetEnvironmentVariable("GitPassword");
            string email = Environment.GetEnvironmentVariable("GitEmail");

            return new GitUpdater(remoteUrl, username, password, email);
        }
    }
}
