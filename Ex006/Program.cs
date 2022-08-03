Console.WriteLine("Print UserName = ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hi Masha, how are you ?");
}
else
{
    Console.Write("Hi ");
    Console.WriteLine(username);
}