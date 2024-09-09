namespace CardGameUtilities._Services;

public interface ICardPurchaser
{
	bool IsPurchasable(Card card);
	void Purchase(Card card);
}
