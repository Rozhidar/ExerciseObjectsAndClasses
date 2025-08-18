short numberOfMessages = short.Parse(Console.ReadLine());

List<string> phrases = new List<string> { "Excellent product.", "Such a great product.",
    "I always use that product.", "Best product of its category.",
    "Exceptional product.", "I can't live without this product." };

List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.", "I feel great!" };

List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

for  (int i = 0; i < numberOfMessages; i++)
{
    Console.WriteLine($"{GetRandomElement(phrases)} {GetRandomElement(events)} " +
        $"{GetRandomElement(authors)} - {GetRandomElement(cities)}");
}

static string GetRandomElement(List<string> list)
{
    Random random = new Random();
    int index = random.Next(list.Count);
    return list[index];
}