﻿namespace WebApplication1.DAOs
{
    public interface ITransaction<T> : IDisposable
    {
        void Commit();
        void Rollback();

        Task CommitAsync();

        Task RollbackAsync();

        T GetInternalTransaction();

        Task BeginTransaction();
    }
}
