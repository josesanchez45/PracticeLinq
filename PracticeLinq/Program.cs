var videoGames = new List<string>();

videoGames.Add("Total War Warhammer");
videoGames.Add("Halo");
videoGames.Add("The Witcher");
videoGames.Add("Mass Effect");
videoGames.Add("Assassin's Creed");

videoGames.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);