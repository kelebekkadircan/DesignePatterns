namespace IteratorDP.IteratorPattern
{
    public interface Iterator<T> 
    {
        T CurrentItem { get; }
        bool HasNext();


    }
}
