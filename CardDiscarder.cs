using CardGame.Services;
using CardGameUtilities._Services;

namespace CardGameUtilities;

public class CardDiscarder : ICardDiscarder
{
    private readonly ICardSelector _cardSelector;

    public CardDiscarder(ICardSelector cardSelector)
    {
        _cardSelector = cardSelector;
    }

    public void DiscardCardFromHand(CardPile hand, CardPile discardPile)
    {
        Card card = _cardSelector.SelectCardFromPile(hand);
        hand.RemoveCard(card);
        discardPile.AddCard(card);
    }

    public void DiscardCardFromHand(CardPile hand)
    {
        Card card = _cardSelector.SelectCardFromPile(hand);
        hand.RemoveCard(card);
    }

    public void DiscardCardsFromHand(CardPile hand, CardPile discardPile, int numberOfCards)
    {
        ICollection<Card> cards = _cardSelector.SelectCardsFromPile(hand, numberOfCards);

        foreach (Card card in cards)
        {
            hand.RemoveCard(card);
            discardPile.AddCard(card);
        }
    }

    public void DiscardCardsFromHand(CardPile hand, int numberOfCards)
    {
        ICollection<Card> cards = _cardSelector.SelectCardsFromPile(hand, numberOfCards);

        foreach (Card card in cards)
        {
            hand.RemoveCard(card);
        }
    }
}
