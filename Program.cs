using System;
bool EstPair(int n) => n % 2 == 0;
if (EstPair(4))
{
    Console.WriteLine("Test 1 OK : 4 est pair");
}
else
{
    Console.WriteLine("Test 1 ÉCHEC");
    Environment.Exit(1);
}
if (!EstPair(5))
{
    Console.WriteLine("Test 2 OK : 5 est impair");
}
else
{
    Console.WriteLine("Test 2 ÉCHEC");
    Environment.Exit(1);
}
Console.WriteLine("Tous les tests sont passés !");