using CardGameUtilities._Services.Behaviours;

namespace CardGameUtilities;

public abstract class Card
{
	protected Card(string name, string image, ICollection<int> cost, string description, ICollection<Action> onPlayedEffects)
	{
		Name = name;
		Image = image;
		Cost = cost;
		Description = description;
		OnPlayedEffects = onPlayedEffects;
	}

	protected Card(string name, string image, string description)
	{
		Name = name;
		Image = image;
		Cost = new List<int>();
		Description = description;
		OnPlayedEffects = new List<Action>();
	}

	public string Name { get; private set; }
    public string Image { get; private set; }
    public IList<int> Cost { get; set; }
    public string Description { get; set; }
    public ICollection<Action> OnPlayedEffects { get; set; }

	public void AddEffect(Action effect)
	{
		OnPlayedEffects.Add(effect);
	}

	public void RemoveEffect(Action effect)
    {
		OnPlayedEffects.Remove(effect);
    }
}
