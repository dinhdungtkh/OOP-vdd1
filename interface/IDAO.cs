namespace OOP_dung.vd.Interface
{
    public interface IDao<T>
    {
        List<T> Search(string name);
    }
}