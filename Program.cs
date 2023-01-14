namespace Module_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Сергей", Login = "serg", IsPremium = true };
            User user2 = new User { Name = "Николай", Login = "nik", IsPremium = false };
            User user3 = new User { Name = "Инна", Login = "ina", IsPremium = true };
            User[] arrOfUsers = { user1, user2, user3 };
            foreach (var item in arrOfUsers)
            {
                Console.WriteLine($"Привет, {item.Name}");
                if (!item.IsPremium)
                    ShowAds();
            }
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
    }
}