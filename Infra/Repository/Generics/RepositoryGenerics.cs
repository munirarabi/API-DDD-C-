using Domain.Interfaces.Generics;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Infra.Repository.Generics
{
    public class RepositoryGenerics<T> : IGenerics<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public RepositoryGenerics()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }

        public async Task Insert(T Objeto)
        {
            using (var data = new Context(_OptionsBuilder))
            {
                await data.Set<T>().AddAsync(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var data = new Context(_OptionsBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<T> SearhById(int Id)
        {
            using (var data = new Context(_OptionsBuilder))
            {
                return await data.Set<T>().FindAsync(Id);
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var data = new Context(_OptionsBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<List<T>> List()
        {
            using (var data = new Context(_OptionsBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}
