namespace DSA_CSharp.src.Linear_Structures.Queue
{
    public interface IQueue<T>
    {
        void Add(T value);

        T Remove();
    }
}
