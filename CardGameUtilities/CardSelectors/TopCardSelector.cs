using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities.CardSelectors;

public class TopCardSelector : ICardSelectorService
{
    private readonly ICollection<Card> _selectables;

    public TopCardSelector(ICollection<Card> selectables)
    {
        _selectables = selectables;
    }

    public Card SelectCard()
    {
        if (_selectables.Count == 0)
        {
            throw new InvalidOperationException("Cannot select a card from an empty pile.");
        }

        return _selectables.First();
    }

    public ICollection<Card> SelectCards(int numberOfCards)
    {
        if (numberOfCards <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfCards), "Number of cards to select must be positive.");
        }

        ICollection<Card> selectedCards = new List<Card>();

        for (int i = 0; i < numberOfCards; i++) // NEW
        {
            Card selectedCard = SelectCard();
            selectedCards.Add(selectedCard);
        }

        return selectedCards;
    }
}
