namespace Tugas;

public class DictionaryClass
{
    private Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

    public  DictionaryClass()
    {
        AddCase("foo", 3);
        AddCase("bar", 5);
        AddCase("foobar", 15);
    }

    public void AddCase(string value, int key)
    {
        keyValuePairs.Add(key, value);
    }

    public bool ContainsKey(int key)
    {
        return keyValuePairs.ContainsKey(key);
    }

    public string GetValue(int key)
    {
        return keyValuePairs[key];
    }
}
