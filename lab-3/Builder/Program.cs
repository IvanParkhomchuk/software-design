using Builder;

// Directors
CharacterDirector heroDirector = new CharacterDirector(new HeroBuilder());
Character nameless = heroDirector.GetNamelessCharacter();

CharacterDirector enemyDirector = new CharacterDirector(new EnemyBuilder());
Character gomez = enemyDirector.GetGomezCharacter();

// Builder
Character raven = new EnemyBuilder()
    .SetName("Raven")
    .SetFaction("Old Camp")
    .SetGuild("Ore Baron")
    .SetMeleeWeapon("Raven's Right")
    .SetRangeWeapon("None")
    .SetArmor("Heavy Ore Baron's Armor")
    .GetCharacter();


Console.WriteLine("Hero:");
nameless.Display();

Console.WriteLine("\nEnemies:");
gomez.Display();
Console.WriteLine();
raven.Display();
