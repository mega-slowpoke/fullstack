namespace June26.CodingQuestion1;

public interface IStack<T>
{
    int Count();
    T Pop();
    void Push(T item);
}