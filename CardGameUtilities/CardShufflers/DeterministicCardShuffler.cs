using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities.CardShufflers;

public class DeterministicCardShuffler : ICardShuffleService
{
    public void ShuffleCards(ICollection<Card> cards)
    {
        if (cards == null)
        {
            throw new ArgumentNullException(nameof(cards), "Card list cannot be null.");
        }

        if (cards.Count == 0)
        {
            return;
        }

        var shuffledList = cards
            .Select((card, index) => new { card, index })
            .OrderBy(x => (x.card.GetHashCode() + x.index) % cards.Count)
            .Select(x => x.card)
            .ToList();

        cards.Clear();
        foreach (var item in shuffledList)
        {
            cards.Add(item);
        }
    }
}
