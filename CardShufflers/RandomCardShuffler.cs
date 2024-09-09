using CardGame.Services;
using CardGameUtilities;

namespace CardGame.CardShufflers;

public class RandomCardShuffler : ICardPileShuffler
{
	private readonly Random _random;
	public RandomCardShuffler(Random random)
	{
		_random = random ?? throw new ArgumentNullException(nameof(random), "Random instance cannot be null.");
	}

	public void Shuffle(CardPile cardPile)
	{
		if (cardPile.Cards == null)
		{
			throw new ArgumentNullException(nameof(cardPile.Cards), "Card list cannot be null.");
		}

		if (cardPile.CardCount == 0)
		{
			return;
		}

		var shuffledList = new List<Card>(cardPile.Cards);
		int n = shuffledList.Count;

		for (int i = n - 1; i > 0; i--)
		{
			int j = _random.Next(i + 1); // Random index from 0 to i
										 // Swap elements at i and j
			var temp = shuffledList[i];
			shuffledList[i] = shuffledList[j];
			shuffledList[j] = temp;
		}

		cardPile.Clear();
		foreach (var item in shuffledList)
		{
			cardPile.AddCard(item);
		}
	}
}
