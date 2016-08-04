using System;
using System.Threading.Tasks;
using Abp.TestBase;
using BPE.EntityFrameworkCore;
using BPE.Tests.TestDatas;

namespace BPE.Tests
{
    public class BPETestBase : AbpIntegratedTestBase<BPETestModule>
    {
        public BPETestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BPEDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BPEDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BPEDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BPEDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BPEDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BPEDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BPEDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BPEDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
