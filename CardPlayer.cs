using CardGameUtilities._Services;
using CardGameUtilities.DataTypes;

namespace CardGameUtilities;

public class CardPlayer : ICardPlayer
{
	public void PlayCard(Card card)
	{
		foreach (Action action in card.OnPlayedEffects)
		{
			action.Invoke();
		}
	}
}
