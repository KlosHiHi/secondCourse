using System.Security.Cryptography;
using System.Text;

namespace Task2
{
    public class ProgramManager
    {
        public static string PasswordHasher(string passsword)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(passsword);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            string hash = Convert.ToHexString(hashedBytes);

            return hash;
        }
    }
}
