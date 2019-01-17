namespace DSA_CSharp.src.Linear_Structures.Stack
{
    public interface IStack<T>
    {
        void push();

        T pop();

        bool isEmpty();
    }
}
