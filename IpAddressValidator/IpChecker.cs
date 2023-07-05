using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressValidator
{
    public class IpChecker
    {
        public bool ValidateIPAddress(string ipAddress)
        {
            string[] parts = ipAddress.Split('.');

            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (string.IsNullOrEmpty(part) || !int.TryParse(part, out int value) || value < 0 || value > 255 || (part.Length > 1 && part[0] == '0') || part.StartsWith(".") || part.EndsWith("."))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
