using GameUtilities.GameUtilities._Services;
using GameUtilities.GameUtilities._Services.Behaviours;

namespace GameUtilities.GameUtilities;

public class Activator : IActivationService
{
    public void Activate(IActivatable playable)
    {
        foreach (Action action in playable.OnActivation)
        {
            action.Invoke();
        }
    }
}
