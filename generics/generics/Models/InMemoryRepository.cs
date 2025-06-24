using generics.Interfaces;

class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>,
IReadOnlyRepository<TEntity, TKey>, IWriteRepository<TEntity, TKey>
where TEntity : class, new()
where TKey : struct
{
    private Dictionary<TKey, TEntity> Repo = new();
    public void Add(TKey id, TEntity entity)
    {
        Repo.Add(id, entity);
    }
    public TEntity Get(TKey id)
    {
        return Repo[id];
    }
    public IEnumerable<TEntity> GetAll()
    {
        return Repo.Values;
    }
    public void Remove(TKey id)
    {
        Repo.Remove(id);
    }
}
