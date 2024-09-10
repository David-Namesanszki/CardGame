using GameUtilities.GameUtilities._Services.Behaviours;

namespace GameUtilities.GameUtilities._Services;

public interface IActivationService
{
    void Activate(IActivatable activatable);
}
