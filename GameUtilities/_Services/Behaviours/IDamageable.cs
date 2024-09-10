namespace GameUtilities.GameUtilities._Services.Behaviours;

public interface IDamageable
{
	int Health { get; set; }
	void TakeDamage(int amount);
}
