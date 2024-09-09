using CardGameUtilities;

namespace CardGame.Services;

public interface ICardPileShuffler
{
    void Shuffle(CardPile cards);
}
