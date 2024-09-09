using CardGame.Services;
using CardGameUtilities;

namespace CardGame.CardShufflers;

public class DeterministicCardShuffler : ICardPileShuffler
{
	public void Shuffle(CardPile cardPile)
	{
		if (cardPile.Cards == null)
		{
			throw new ArgumentNullException(nameof(cardPile.Cards), "Card list cannot be null.");
		}

		if (cardPile.Cards.Count == 0)
		{
			return;
		}

		var shuffledList = cardPile.Cards
			.Select((card, index) => new { card, index })
			.OrderBy(x => (x.card.GetHashCode() + x.index) % cardPile.Cards.Count)
			.Select(x => x.card)
			.ToList();

		cardPile.Clear();
		foreach (var item in shuffledList)
		{
			cardPile.AddCard(item);
		}
	}
}
