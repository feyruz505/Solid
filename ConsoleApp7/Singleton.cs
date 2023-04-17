public sealed class MySingleton
{
    private static MySingleton instance = null;
    private static readonly object padlock = new object();

    private MySingleton()
    {
    }

    public static MySingleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }
    }
}
