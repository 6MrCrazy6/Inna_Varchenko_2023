Random rnd = new Random();
List<int> list = new List<int>(20);
for (int i = 0; i <= 10; i++)
{
    list.Add(rnd.Next(0, 10));
}
Console.WriteLine(string.Join(", ", list));

Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < list.Count; i++)
{
    if (list[i] == number)
    {
        list.Insert(i + 1, number);
        i++;
    }

}
Console.WriteLine(string.Join(", ", list));