namespace GameUtilities.CardGameUtilities._Services;

public interface ICardSelectorService
{
    Card SelectCard();
    ICollection<Card> SelectCards(int numberOfCards);
}
