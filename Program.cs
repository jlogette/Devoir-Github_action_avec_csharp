using System;
var accessToken = Environment.GetEnvironmentVariable("ACCESS_TOKEN");
if (accessToken.StartsWith("mo"))
{
    Console.WriteLine("Accès autorisé !");
}
else
{
    Console.WriteLine("Accès refusé");
}