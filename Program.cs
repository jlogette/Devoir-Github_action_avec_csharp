using System;
var apiKey = Environment.GetEnvironmentVariable("API_KEY");
if (string.IsNullOrEmpty(apiKey))
{
    Console.WriteLine("Clé API non trouvée !");
}
else
{
    Console.WriteLine("Clé API récupérée avec succès !");
}