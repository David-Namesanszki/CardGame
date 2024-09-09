using CardGame.Services;
using CardGameUtilities._Services;

namespace CardGameUtilities;

public class CardDrawer : ICardDrawer
{
    private readonly ICardSelector _cardSelector;

    public CardDrawer(ICardSelector cardSelector)
    {
        _cardSelector = cardSelector;
    }

    public void DrawCardFromPile(CardPile drawPile, CardPile hand)
    {
        Card card = _cardSelector.SelectCardFromPile(drawPile);
        drawPile.RemoveCard(card);
        hand.AddCard(card);
    }

    public void DrawCardFromPile(CardPile drawPile)
    {
        Card card = _cardSelector.SelectCardFromPile(drawPile);
        drawPile.RemoveCard(card);
    }

    public void DrawCardsFromHand(CardPile drawPile, CardPile hand, int numberOfCards)
    {
        ICollection<Card> cards = _cardSelector.SelectCardsFromPile(drawPile, numberOfCards);

        foreach (Card card in cards)
        {
            drawPile.RemoveCard(card);
            hand.AddCard(card);
        }
    }

    public void DrawCardsFromHand(CardPile drawPile, int numberOfCards)
    {
        ICollection<Card> cards = _cardSelector.SelectCardsFromPile(drawPile, numberOfCards);

        foreach (Card card in cards)
        {
            drawPile.RemoveCard(card);
        }
    }
}
