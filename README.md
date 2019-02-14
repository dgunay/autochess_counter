# Auto Chess Counter
![Example](https://i.imgur.com/wdpFXBu.png)

This app simply helps you manually track how many units of a given type are on
the field in Dota 2 Auto Chess.

## Layout Explanation
The units are laid out according to a tier list my friend made, which is ordered:

- **1 Gold**: Bounty Hunter > Axe > Tusk > Clockwerk > Tinker > Orge Magi >  Enchantress > Anti-Mage (situational) > Bat Rider > Shadow Shaman > Drow > Tiny 
- **2 Gold**: Beastmaster > Juggernaut > Timbersaw > Queen of Pain > Treant > Slardar > Luna > Witch Doctor > Puck > Chaos Knight  > Morphing > Furion > Crystal Maiden
- **3 Gold**: Shadow Fiend > Razor > Lycan > Viper > Abaddon > Omniknight > Wind Ranger >  Terrorblade (situational) > Venomancer > Slark > Sand King > Phantom Assassin > Sniper >>> Lina (worst unit in the game)
- **4 Gold**:  Disruptor > Kunkka > Doom > Lone Druid > Medusa > Troll > Alchemist > Templar Assassin > Human DK > Necrophos > Keeper of the Light 
- **5 Gold**:  Tide Hunter > Enigma > Lich > Techies > Gyrocopter

So the rows from top to bottom are 1-5 gold, and left to right is best to worst in class.

I am very inexperienced in GUI applications and threw this together in a few
hours, so rather than express a hero counter abstractly in XAML/C#, I wrote some
Perl to generate the XAML and OnClick() methods of each hero sprite .png in
the Images folder. I would have liked for the user to be able to expand the
program by including more sprites at runtime if Auto Chess is updated with new
heroes.

## Building from source

Use Visual Studio 2017 with C# WPF tools installed.

Hit Build, and you'll find the binary in `WpfApp1/bin/Release`.
