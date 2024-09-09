using CardGameUtilities._Services;

namespace CardGameUtilities;

public class CardPurchaser : ICardPurchaser
{
	private readonly IList<int> _playerResourceAmounts;

	public CardPurchaser(IList<int> playerResourceAmounts)
	{
		_playerResourceAmounts = playerResourceAmounts ?? throw new ArgumentNullException(nameof(playerResourceAmounts), "Player resources cannot be null.");
	}

	public bool IsPurchasable(Card card)
	{
		if (_playerResourceAmounts.Count != _playerResourceAmounts.Count)
		{
			throw new ArgumentException("Player resources and card cost collections must have the same size.");
		}

		for (int i = 0; i < _playerResourceAmounts.Count; i++)
		{
			if (_playerResourceAmounts[i] < card.Cost[i])
			{
				return false;
			}
		}

		return true;
	}

	public void Purchase(Card card)
	{
		if(IsPurchasable(card))
		{
			for (int i = 0; i < _playerResourceAmounts.Count; i++)
			{
				_playerResourceAmounts[i] -= card.Cost[i];
			}
		}
		else
		{
			throw new InvalidOperationException("Player cannot afford the card.");
		}
	}
}
