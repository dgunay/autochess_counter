use strict;
use warnings;

# For each hero in images
my @heroes;
for my $uri (glob('../WpfApp1/Images/*.png')) {
	if ($uri =~ /WpfApp1\/Images\/(.+?).png/) {
		my $hero = $1;
		# delete +
		$hero =~ s/\+//g;
		push @heroes, $hero;
	}
}

my $col = 0;
my $row = 0;
for my $hero (@heroes) {
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
	$row++ if $col == 10;

	$col = $col % 10;
}

