namespace GameUtilities.CardGameUtilities._Services;

public interface ICardShuffleService
{
    void ShuffleCards(ICollection<Card> cards);
}
