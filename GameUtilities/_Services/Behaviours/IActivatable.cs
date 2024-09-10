namespace GameUtilities.GameUtilities._Services.Behaviours
{
    public interface IActivatable
    {
        public ICollection<Action> OnActivation { get; }
    }
}
