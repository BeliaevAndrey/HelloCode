double numberA = new Random().Next(1, 100);
Console.WriteLine("Number A = {0}", numberA);
double numberB = new Random().Next(1, 100);
Console.WriteLine("Number B = {0}", numberB);
if(numberA > numberB)
{
Console.WriteLine("B/A = {0}", numberA / numberB);
}
else
{
Console.WriteLine("B/A = {0}", numberB / numberA);
}
