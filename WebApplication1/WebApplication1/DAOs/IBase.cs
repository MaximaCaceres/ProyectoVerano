namespace WebApplication1.DAOs
{
    public interface IBase<T, K, M> //interfaz de un CRUD
    {
        Task<List<T>> GetAll(ITransaction<M>? transaccion = null);
        Task<T?> GetByKey(K id, ITransaction<M>? transaccion = null);
        Task<bool> Insert(T nuevo, ITransaction<M>? transaccion = null);
        Task<bool> Update(T actualizar, ITransaction<M>? transaccion = null);
        Task<bool> Delete(K id, ITransaction<M>? transaccion = null);
    }
}
