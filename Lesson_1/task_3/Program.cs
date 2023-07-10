Console.WriteLine("Enter first string");
string str1 = Console.ReadLine();
Console.WriteLine("Enter second string");
string str2 = Console.ReadLine();

if (str1.Length > str2.Length)
{
    string result = str1 + " " + str2;
    Console.WriteLine(result);
}

if (str1.Length < str2.Length)
{
    string[] result = str2.Split(str1[0]);
    foreach (string s in result)
    {
        Console.WriteLine(s);
    }
}

if (str1.Length == str2.Length)
{
    Console.WriteLine("Result: ");
}