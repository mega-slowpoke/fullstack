namespace June26.CodingQuestion2;

public interface IMyList<T>
{
    void Add(T element);
    T Remove(int index);
    bool Contains(T element);
    void Clear();
    void InsertAt(T element, int index);
    void DeleteAt(int index);
    T Find(int index);
}