using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities;

public class CardDiscarder : ICardDiscardService
{
    private readonly ICollection<Card> _hand;
    private readonly ICollection<Card> _discardPile;

    public CardDiscarder(ICollection<Card> hand, ICollection<Card> discardPile)
    {
        _hand = hand;
        _discardPile = discardPile;
    }

    public void DiscardCard(Card card)
    {
        _hand.Remove(card);
        _discardPile.Add(card);
    }

    public void DiscardCards(ICollection<Card> cards)
    {
        foreach (Card card in cards)
        {
            DiscardCard(card);
        }
    }
}
