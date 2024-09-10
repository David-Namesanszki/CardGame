namespace GameUtilities.CardGameUtilities._Services
{
    public interface ICardDiscardService
    {
        void DiscardCard(Card card);
        void DiscardCards(ICollection<Card> cards);
    }
}