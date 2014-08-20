namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Detach(IObserver observer);
    }
}