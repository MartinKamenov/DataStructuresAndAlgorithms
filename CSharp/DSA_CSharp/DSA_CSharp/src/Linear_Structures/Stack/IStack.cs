namespace DSA_CSharp.src.Linear_Structures.Stack
{
    public interface IStack<T>
    {
        void Add(T obj);

        T Pop();

        bool IsEmpty();
    }
}
