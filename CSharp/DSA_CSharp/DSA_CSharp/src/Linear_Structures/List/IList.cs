namespace DSA_CSharp.Linear_Structures.List
{
    public interface IList<T>
    {
        T this[int index] { get; set; }

        int Count { get; }

        bool IsFixedSize { get; }

        bool IsReadOnly { get; }

        void Add(T value);

        void Clear();

        bool Contains(T value);

        int IndexOf(T value);

        void Insert(int index, T value);

        void Remove(T value);

        void RemoveAt(int index);
    }
}
