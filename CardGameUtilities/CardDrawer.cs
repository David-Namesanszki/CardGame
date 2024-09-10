using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities;

public class CardDrawer : ICardDrawingService
{
    private readonly ICollection<Card> _drawPile;
    private readonly ICollection<Card> _hand;

    public CardDrawer(ICollection<Card> drawPile, ICollection<Card> hand)
    {
        _drawPile = drawPile;
        _hand = hand;
    }

    public void DrawCard(Card card)
    {
        _drawPile.Remove(card);
        _hand.Add(card);
    }

    public void DrawCards(ICollection<Card> cards)
    {
        foreach (Card card in cards)
        {
            DrawCard(card);
        }
    }
}
