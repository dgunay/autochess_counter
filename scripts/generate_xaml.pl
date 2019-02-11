use strict;
use warnings;

use Data::Dumper;

# Gather hero image URIs
my @images = ();
for my $uri (glob('../WpfApp1/Images/*.png')) {
	if ($uri =~ /WpfApp1\/(Images\/.+?.png)/) {
		my $img_uri = $1;
		# delete +
		$img_uri =~ s/\+//g;
		push @images, $img_uri;
	}
}

# Organize heroes by gold value
my @heroes = ();
my $fn = 'heroes_by_gold.txt';
open(my $fh, '<:encoding(UTF-8)', $fn) or die "Could not open file '$fn' $!";

while (my $row = <$fh>) {
  chomp $row;

	my $gold_value = substr($row, 0, 1);
	$row =~ s/\d Gold://g; # Remove it to ease parsing

	my @heroes_in_this_tier = map { $_ = remove_spaces($_) } split(/\>/, $row);

	foreach my $hero (@heroes_in_this_tier) {
		# Find the image
		my $img = grep { /$hero/ } @images or die "No image for $hero";

		$heroes[$gold_value-1] = \@heroes_in_this_tier;
	}
}


my $col = 0;
my $row = 0;
foreach my $tier (@heroes) {
	$col = 0;

	for my $hero (@$tier) {
		print '<Border Name="'.$hero.'Border" BorderBrush="Black" BorderThickness="2" Grid.Column="'.$col.'" Grid.Row="'.$row.'">
		<Grid>
			<!-- Rows -->
			<Grid.RowDefinitions>
				<RowDefinition Height="60*"/>
				<RowDefinition Height="40*"/>
			</Grid.RowDefinitions>
			<!-- Pic of the hero -->
			<Image Source="Images/'.$hero.'.png"/>
			<!-- Another grid containing counter stuff -->
			<Grid Grid.Column="0" Grid.Row="1">
				<Grid.ColumnDefinitions>
					<ColumnDefinition Width="35*"/>
					<ColumnDefinition Width="35*"/>
					<ColumnDefinition Width="30*"/>
				</Grid.ColumnDefinitions>
			
				<Button x:Name="Btn'.$hero.'Plus"  Grid.Column="0" FontSize="20" FontWeight="Bold" Click="Btn'.$hero.'Plus_Click">
					+
				</Button>
				<Button x:Name="Btn'.$hero.'Minus" Grid.Column="1" FontSize="20" FontWeight="Bold" Click="Btn'.$hero.'Minus_Click">
					-
				</Button>
				<TextBox x:Name="Txt'.$hero.'Count" Grid.Column="2" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="20" IsReadOnly="True">
					0
				</TextBox>
			</Grid>
		</Grid>
	</Border>' . "\n\n";

		$col++;
		$col = $col % 14;
	}
	$row++;
}



sub trim {
	my $str = shift;
	$str =~ s/^\s+|\s+$//g;
	return $str;
}

sub remove_spaces {
	my $str = shift;
	$str =~ s/ |-|\n//g;
	return $str;
}

