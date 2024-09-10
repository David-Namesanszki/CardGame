using GameUtilities.GameUtilities._Services.Behaviours;

namespace GameUtilities.GameUtilities._Services;

public interface IDamageService
{
	void DealDamage(int amount, IDamageable target);
}
