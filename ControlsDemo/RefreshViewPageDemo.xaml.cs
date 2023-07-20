using System.Collections.ObjectModel;

namespace ControlsDemo;

public partial class RefreshViewPageDemo : ContentPage
{
    ObservableCollection<Animal> animals = new Animals();
    public RefreshViewPageDemo()
	{
		InitializeComponent();

        animalsCollectionVW.ItemsSource = LoadData();
    }

    public ObservableCollection<Animal> LoadData(int currentindex=0)
    {
        int numberOfItemToDisplay = 10;

        Animals animals = new Animals();
        var query = animals
            .Skip(currentindex)
            .Take(numberOfItemToDisplay).ToList();

        
        return new Animals();
    }

    private void animalsCollectionVW_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
        animalsCollectionVW.ItemsSource = LoadData();
    }
}


public class Animals : ObservableCollection<Animal>
{
    public Animals()
    {
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });

        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });

        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });

        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });

        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });

        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
        Add(new Animal
        {
            Name = "American Black Bear",
            Location = "North America",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        });
        Add(new Animal
        {
            Name = "Asian Black Bear",
            Location = "Asia",
            Details = "Details about the bear go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        });

        Add(new Animal
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Add(new Animal
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
        });
        Add(new Animal
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "Details about the monkey go here.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
        });
    }
}