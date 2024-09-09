using CardGame.Services;
using CardGameUtilities;

namespace CardGame.CardSelectors;

public class RandomCardSelector : ICardSelector
{
    private readonly Random _random;
    public RandomCardSelector(Random random)
    {
        _random = random;
    }

    public Card SelectCardFromPile(CardPile cardPile)
    {
        if (cardPile.IsEmpty)
        {
            throw new InvalidOperationException("Cannot select a card from an empty pile.");
        }

        int randomIndex = _random.Next(cardPile.CardCount);
        return cardPile.Cards[randomIndex];
    }

    public ICollection<Card> SelectCardsFromPile(CardPile cardPile, int numberOfCards)
    {
        if (numberOfCards <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfCards), "Number of cards to select must be positive.");
        }

        ICollection<Card> selectedCards = new List<Card>();

        for (int i = 0; i < numberOfCards; i++)
        {
            Card discardedCard = SelectCardFromPile(cardPile);
            selectedCards.Add(discardedCard);
        }


		return selectedCards;
    }
}
