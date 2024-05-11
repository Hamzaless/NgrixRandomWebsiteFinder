using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgrixRandomWebsiteFinder
{
    public static class RandomURLGenerator
    {


        public static string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomURL(string extension)
        {
            Random random = new Random();
            int randomLength = random.Next(3, 15);
            string randomString = GenerateRandomString(randomLength);
            string randomExtension = extension;
            return randomString + randomExtension;
        }

        public static string GetRandomExtension()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, RWF.domain_extensions.Count);
            return RWF.domain_extensions.Keys.ElementAt(randomIndex);
        }

    }
}
