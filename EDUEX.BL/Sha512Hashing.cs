using System.Security.Cryptography;
using System.Text;

namespace EDUEX.BL
{
    public class Sha512Hashing : IHashing
    {
        public string GetHash(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
