using CardGameUtilities._Services;
using CardGameUtilities.DataTypes;

namespace CardGameUtilities.CardDrawers;

public class RandomCardDrawer : ICardDrawer
{
	private readonly CardPile _drawPile;
	public RandomCardDrawer(CardPile drawPile)
	{
		_drawPile = drawPile;
	}

	public void DrawCardFromPile(CardPile drawPile)
	{
		throw new NotImplementedException();
	}

	public void DrawCardFromPile(CardPile drawPile, CardPile hand)
	{
		throw new NotImplementedException();
	}

	public void DrawCardsFromHand(CardPile drawPile, CardPile hand, int numberOfCards)
	{
		throw new NotImplementedException();
	}

	public void DrawCardsFromHand(CardPile drawPile, int numberOfCards)
	{
		throw new NotImplementedException();
	}
}
