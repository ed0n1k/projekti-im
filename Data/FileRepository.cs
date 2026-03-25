using System.IO;

public class FileRepository<T> : IRepository<T>
{
    private List<T> items = new List<T>();
    private string filePath;

    public FileRepository(string path)
    {
        filePath = path;
        Load();
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Save()
    {
        File.WriteAllLines(filePath, items.Select(x => x.ToString()));
    }

    private void Load()
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            // këtu mundesh me parsuar CSV sipas modelit
        }
    }
}