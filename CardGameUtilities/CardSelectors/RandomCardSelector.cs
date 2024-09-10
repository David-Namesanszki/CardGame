using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities.CardSelectors;

public class RandomCardSelector : ICardSelectorService
{
    private readonly Random _random;
    private readonly ICollection<Card> _selectables;
    public RandomCardSelector(Random random, ICollection<Card> selectables)
    {
        _random = random;
        _selectables = selectables;
    }

    public Card SelectCard()
    {
        if (_selectables.Count == 0)
        {
            throw new InvalidOperationException("Cannot select a card from an empty pile.");
        }

        int randomIndex = _random.Next(_selectables.Count);
        return _selectables.ElementAt(randomIndex);
    }

    public ICollection<Card> SelectCards(int numberOfCards)
    {
        if (numberOfCards <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(numberOfCards), "Number of cards to select must be positive.");
        }

        ICollection<Card> selectedCards = new List<Card>();

        for (int i = 0; i < numberOfCards; i++)
        {
            Card selectedCard = SelectCard();
            selectedCards.Add(selectedCard);
        }

        return selectedCards;
    }
}
