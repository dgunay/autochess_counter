# Auto Chess Counter
![Example](https://i.imgur.com/wdpFXBu.png)

This app simply helps you manually track how many units of a given type are on
the field in Dota 2 Auto Chess.

I am very inexperienced in GUI applications and threw this together in a few
hours, so rather than express a hero counter abstractly in XAML/C#, I wrote some
Perl to generate the XAML and OnClick() methods of each hero sprite .png in
the Images folder. I would have liked for the user to be able to expand the
program by including more sprites at runtime if Auto Chess is updated with new
heroes.

## Building from source

Use Visual Studio 2017 with C# WPF tools installed.

Build > Release.
