using System.Collections.Generic;
using System.Threading;
using Dasync.Collections;

namespace Dasync.Collections.Internals
{
    internal sealed class EmptyAsyncEnumerable<T> : IAsyncEnumerable<T>, IAsyncEnumerable
    {
        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
            => AsyncEnumerator<T>.Empty;

        IAsyncEnumerator IAsyncEnumerable.GetAsyncEnumerator(CancellationToken cancellationToken)
            => new EmptyAsyncEnumerator();
    }
}
