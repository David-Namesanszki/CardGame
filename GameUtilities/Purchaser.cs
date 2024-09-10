using GameUtilities.GameUtilities._Services;
using GameUtilities.GameUtilities._Services.Behaviours;

namespace GameUtilities.GameUtilities;

public class Purchaser : IPurchaseService
{
    private readonly IList<int> _playerResourceAmounts;

    public Purchaser(IList<int> playerResourceAmounts)
    {
        _playerResourceAmounts = playerResourceAmounts ?? throw new ArgumentNullException(nameof(playerResourceAmounts), "Player resources cannot be null.");
    }

    public bool IsPurchasable(IPurchasable purchasable)
    {
        if (_playerResourceAmounts.Count != _playerResourceAmounts.Count)
        {
            throw new ArgumentException("Player resources and item cost collections must have the same size.");
        }

        for (int i = 0; i < _playerResourceAmounts.Count; i++)
        {
            if (_playerResourceAmounts[i] < purchasable.Cost[i])
            {
                return false;
            }
        }

        return true;
    }

    public void Purchase(IPurchasable purchasable)
    {
        if (IsPurchasable(purchasable))
        {
            for (int i = 0; i < _playerResourceAmounts.Count; i++)
            {
                _playerResourceAmounts[i] -= purchasable.Cost[i];
            }
        }
        else
        {
            throw new InvalidOperationException("Player cannot afford the item.");
        }
    }
}
