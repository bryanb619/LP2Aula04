using System.Collections.Generic;

namespace Coroutine.Assets.Scripts
{
    public interface IBag<T> : IEnumerable<T>
    {
        void Add(T item);

        void Remove(T item);
    }
}