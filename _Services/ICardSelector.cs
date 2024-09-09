using CardGameUtilities;

namespace CardGame.Services;

public interface ICardSelector
{
    Card SelectCardFromPile(CardPile cardPile);
    ICollection<Card> SelectCardsFromPile(CardPile cardPile, int numberOfCards);
}
