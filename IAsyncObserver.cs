using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiegoG.IAsyncObserver
{
    /// <summary>
    /// Defines a mechanism for asynchronous push-based notifications
    /// </summary>
    /// <typeparam name="T">The object that provides notification information</typeparam>
    public interface IAsyncObserver<in T>
    {
        /// <summary>
        /// Notifies the observer that the provider has finished sending push-based notifications.
        /// </summary>
        Task OnCompleted();

        /// <summary>
        /// Notifies the observer that the provider has experienced an error condition.
        /// </summary>
        /// <param name="error"></param>
        Task OnError(Exception error);

        /// <summary>
        /// Provides the observer with new data
        /// </summary>
        /// <param name="value">The current notification information.</param>
        Task OnNext(T value);
    }
}
