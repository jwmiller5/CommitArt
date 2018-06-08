using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommitArt.Core
{
    public static class CommitArtDataFile
    {
        public static void AppendLineToDataFile(this string dataFilePath)
        {
                StringBuilder text = new StringBuilder(File.ReadAllText(dataFilePath));
                text.Append(DateTime.UtcNow.ToLongTimeString() + ":");
                text.Append(CreateRandomString() + Environment.NewLine);
                File.WriteAllText(dataFilePath, text.ToString());
        }
        private static string CreateRandomString()
        {
            //TODO: Get creative
            Random random = new Random();
            var builder = new StringBuilder(100);
            for (int i = 0; i < 100; i++)
            {
                builder.Append((char)random.Next(33, 125));
            }

            return builder.ToString();
        }
    }
}
