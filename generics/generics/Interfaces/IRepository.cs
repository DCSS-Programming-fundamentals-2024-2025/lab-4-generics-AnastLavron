namespace generics.Interfaces
{
    interface IRepository<TEntity, TKey>
    where TEntity : class, new()
    where TKey : struct
    {
        void Add(TKey id, TEntity entity);
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        void Remove(TKey id);
    }
}
