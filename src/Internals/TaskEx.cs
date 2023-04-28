using System;
using System.Threading;
using System.Threading.Tasks;

#if NET40
using BclTaskEx = System.Threading.Tasks.TaskEx;
#endif

namespace Dasync.Collections.Internals
{
    internal static class InternalTaskEx
    {

        public static readonly Task<bool> True =
#if NET40
            BclTaskEx.FromResult(true);
#else
            Task.FromResult(true);
#endif

        public static readonly Task<bool> False =
#if NET40
            BclTaskEx.FromResult(false);
#else
            Task.FromResult(false);
#endif

        public static readonly Task Completed =
#if NET40
            TaskExEx.CompletedTask;
#else
            Task.CompletedTask;
#endif

        public static Task<T> FromException<T>(Exception ex)
        {
#if NET40
            return TaskExEx.FromException<T>(ex);
#else
            return Task.FromException<T>(ex);
#endif
        }

        public static Task Run(Action action)
        {
#if NET40
            return BclTaskEx.Run(action);
#else
            return Task.Run(action);
#endif
        }

        public static Task Run(Action action, CancellationToken cancellationToken)
        {
#if NET40
            return BclTaskEx.Run(action, cancellationToken);
#else
            return Task.Run(action, cancellationToken);
#endif
        }

        public static Task<T> Run<T>(Func<T> action, CancellationToken cancellationToken)
        {
#if NET40
            return BclTaskEx.Run(action, cancellationToken);
#else
            return Task.Run(action, cancellationToken);
#endif
        }

        public static Task<T> Run<T>(Func<Task<T>> action, CancellationToken cancellationToken)
        {
#if NET40
            return BclTaskEx.Run(action, cancellationToken);
#else
            return Task.Run(action, cancellationToken);
#endif
        }

    }
}