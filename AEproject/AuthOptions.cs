using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEproject.Web
{
    using System.Text;
    using Microsoft.IdentityModel.Tokens;

    public class AuthOptions
    {
        public const string ISSUER = "AEproject"; // издатель токена

        // TODO change on real env
        public const string AUDIENCE = "http://localhost/"; // потребитель токена

        const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации

        public const int LIFETIME = 1; // время жизни токена - 1 минута

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
