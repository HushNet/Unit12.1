using Unit12._1;


User user1 = new User() {Login = "alex22", Name = "Alex", IsPremium = false};
User user2 = new User() {Login = "bob77", Name = "Bob", IsPremium = true};
User user3 = new User() {Login = "jack11", Name = "Jack", IsPremium = false};

List<User> users = new List<User>() {user1, user2, user3};


for (int i = 0; i < users.Count; i++)
{
    if (!users[i].IsPremium)
    {
        ShowAds();
    }

    Console.WriteLine($"Привет, {users[i].Name}!");
}




static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}