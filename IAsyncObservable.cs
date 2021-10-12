using System;
using System.Threading.Tasks;

namespace DiegoG.IAsyncObserver
{ 
    /// <summary>
    /// Defines a provider for asynchronous push-based notifications
    /// </summary>
    /// <typeparam name="T">The object that provides notification information</typeparam>
    public interface IAsyncObservable<out T>
    {
        /// <summary>
        /// Notifies the provider that an observer is to receive notifications asynchronously.
        /// </summary>
        /// <param name="observer">The object that is to receive notifications.</param>
        /// <returns>A reference to an interface that allows observers to stop receiving notifications before the provider has finished sending them</returns>
        Task<IAsyncDisposable> Subscribe(IAsyncObserver<T> observer);
    }
}
