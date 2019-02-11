use strict;
use warnings;

# For each hero in images
my @heroes;
for my $uri (glob('../WpfApp1/Images/*.png')) {
	if ($uri =~ /WpfApp1\/Images\/(.+?)\+Dota\+2.png/) {
		my $hero = $1;
		# delete +
		$hero =~ s/\+//g;
		push @heroes, $hero;
	}
}

for my $hero (@heroes) {
	print "private void Btn".$hero."Plus_Click(object sender, RoutedEventArgs e)
{
		int count = Int32.Parse(Txt".$hero."Count.Text);
		if (count < 3) 
				++count;
		Txt".$hero."Count.Text = count.ToString();
}

private void Btn".$hero."Minus_Click(object sender, RoutedEventArgs e)
{
		int count = Int32.Parse(Txt".$hero."Count.Text);
		if (count > 0)
				--count;
		Txt".$hero."Count.Text = count.ToString();
}\n\n";
}
