using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using CardGame.Services;
using CardGameUtilities;

namespace CardGame.CardSelectors;

public class TopCardSelector : ICardSelector
{
	public Card SelectCardFromPile(CardPile cardPile)
    {
        if (cardPile.IsEmpty)
        {
            throw new InvalidOperationException("Cannot select a card from an empty pile.");
        }

        return cardPile.Cards.First();
    }

    public ICollection<Card> SelectCardsFromPile(CardPile cardPile, int numberOfCards)
    {
        if (numberOfCards <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfCards), "Number of cards to select must be positive.");
        }

        ICollection<Card> selectedCards = new List<Card>();

        for (int i = 0; i < numberOfCards; i++) // NEW
        {
            Card selectedCard = SelectCardFromPile(cardPile);
            selectedCards.Add(selectedCard);
        }

        return selectedCards;
    }
}
