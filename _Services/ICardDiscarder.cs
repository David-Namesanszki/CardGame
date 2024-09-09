namespace CardGameUtilities._Services
{
    public interface ICardDiscarder
    {
        void DiscardCardFromHand(CardPile hand);
        void DiscardCardFromHand(CardPile hand, CardPile discardPile);
        void DiscardCardsFromHand(CardPile hand, CardPile discardPile, int numberOfCards);
        void DiscardCardsFromHand(CardPile hand, int numberOfCards);
    }
}