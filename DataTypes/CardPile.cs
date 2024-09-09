using CardGame.Services;

namespace CardGameUtilities;

public class CardPile
{
    public CardPile(IList<Card> cards)
    {
        Cards = cards;
    }

    public CardPile()
    {
        Cards = new List<Card>();
    }

    public bool IsEmpty { get { return !Cards.Any(); } }
    public int CardCount { get { return Cards.Count; } }
    public IList<Card> Cards { get; private set; }

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    public void RemoveCard(Card card)
    {
        Cards.Remove(card);
    }

    public void Clear()
    {
        Cards.Clear();
    }
}
