namespace Student_and_Teacher_Repository_and_IRepository
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey ?Id { get; private set; }
    }

    public class Entity : Entity<long>
    {
    }

    public interface IEntity<TKey>
    {
        TKey ?Id { get; }
    }

    public interface ITenant { }
}
