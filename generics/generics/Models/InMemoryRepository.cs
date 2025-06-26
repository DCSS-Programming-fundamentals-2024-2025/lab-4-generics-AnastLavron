using generics.Interfaces;

class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>, IReadOnlyRepository<TEntity, TKey>, IWriteRepository<TEntity, TKey>
    where TEntity : class, new()
    where TKey : struct
{
    private Dictionary<TKey, TEntity> _items = new Dictionary<TKey, TEntity>();

    public void Add(TEntity entity)
    {
        var id = (TKey)typeof(TEntity).GetProperty("Id").GetValue(entity);
        _items[id] = entity;
    }
    public void Add(TKey id, TEntity entity)
    {
        _items[id] = entity;
    }

    public TEntity Get(TKey id)
    {
        return _items[id];
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _items.Values;
    }

    public void Remove(TKey id)
    {
        _items.Remove(id);
    }
}