using System;
using System.Threading;

namespace Dasync.Collections
{

    /// <inheritdoc />
    [Serializable]
    public class OperationCanceledException
        : System.OperationCanceledException
    {

#if NET20 || NET40
        /// <summary>
        /// Gets a token associated with the operation that was canceled.
        /// </summary>
        /// <value>
        /// A token associated with the operation that was canceled, or a default token.
        /// </value>
        public CancellationToken CancellationToken { get; }
#endif

        /// <inheritdoc />
        public OperationCanceledException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the System.OperationCanceledException class with a specified error message, a reference to the inner exception that is the cause of this exception, and a cancellation token.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the innerException parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        /// <param name="token">A cancellation token associated with the operation that was canceled.</param>
        public OperationCanceledException(string message, Exception innerException, CancellationToken token)
#if NET20 || NET40
            : base(message, innerException)
        {
            this.CancellationToken = token;
        }
#else
            :base(message, innerException, token)
        {
        }
#endif

    }

}
