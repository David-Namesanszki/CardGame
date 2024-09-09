namespace CardGameUtilities._Services
{
    public interface ICardDrawer
    {
        void DrawCardFromPile(CardPile drawPile);
        void DrawCardFromPile(CardPile drawPile, CardPile hand);
        void DrawCardsFromHand(CardPile drawPile, CardPile hand, int numberOfCards);
        void DrawCardsFromHand(CardPile drawPile, int numberOfCards);
    }
}