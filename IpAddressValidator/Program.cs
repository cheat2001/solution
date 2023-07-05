
using IpAddressValidator;


Console.Write("Enter an IP address:");
string ipAddress = Console.ReadLine();

IpChecker ipChecker = new IpChecker();

Console.WriteLine(ipChecker.ValidateIPAddress(ipAddress));