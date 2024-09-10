namespace GameUtilities.GameUtilities._Services.Behaviours;

public interface IHealable
{
	int Health { get; set; }

	void Heal(int amount);
}