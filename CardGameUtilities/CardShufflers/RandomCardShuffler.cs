using GameUtilities.CardGameUtilities._Services;

namespace GameUtilities.CardGameUtilities.CardShufflers;

public class RandomCardShuffler : ICardShuffleService
{
    private readonly Random _random;
    public RandomCardShuffler(Random random)
    {
        _random = random ?? throw new ArgumentNullException(nameof(random), "Random instance cannot be null.");
    }

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

        var shuffledList = new List<Card>(cards);
        int n = shuffledList.Count;

        for (int i = n - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1); // Random index from 0 to i
                                         // Swap elements at i and j
            var temp = shuffledList[i];
            shuffledList[i] = shuffledList[j];
            shuffledList[j] = temp;
        }

        cards.Clear();
        foreach (var item in shuffledList)
        {
            cards.Add(item);
        }
    }
}
