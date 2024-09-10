using GameUtilities.GameUtilities._Services.Behaviours;

namespace GameUtilities.GameUtilities._Services;

public interface IPurchaseService
{
    bool IsPurchasable(IPurchasable purchasable);
    void Purchase(IPurchasable purchasable);
}
