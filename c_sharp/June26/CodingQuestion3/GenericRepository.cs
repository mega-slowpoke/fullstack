namespace June26.CodingQuestion3;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private List<T> _fakeDatabase = new List<T>();
    
    public void Add(T item)
    {
        if (GetById(item.id) == null)
        {
            _fakeDatabase.Add(item);
        }
        
    }

    public void Remove(T item)
    {
        if (GetById(item.id) != null)
        {
            _fakeDatabase.Remove(item);
        }
    }

    public void Save()
    {
        string fileName = "filename.txt";
        FileStream fs = File.Open(fileName, FileMode.OpenOrCreate);
        foreach (T item in _fakeDatabase) 
        {
            File.WriteAllText(fileName, item.ToString());
        }
    }

    public IEnumerable<T> GetAll()
    {
        return _fakeDatabase;
    }

    public T GetById(int id)
    {
        foreach (T item in _fakeDatabase) 
        {
            if (item.id == id)
            {
                return item;
            }
        }
        return null;
    }
}