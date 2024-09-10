namespace GameUtilities.CardGameUtilities;

public abstract class Card
{
    protected Card(string name, string image, string description)
    {
        Name = name;
        Image = image;
        Description = description;
    }

    public string Name { get; private set; }
    public string Image { get; private set; }
    public string Description { get; set; }
}
