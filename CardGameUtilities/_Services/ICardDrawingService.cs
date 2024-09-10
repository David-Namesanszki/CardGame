namespace GameUtilities.CardGameUtilities._Services
{
    public interface ICardDrawingService
    {
        void DrawCard(Card card);
        void DrawCards(ICollection<Card> cards);
    }
}