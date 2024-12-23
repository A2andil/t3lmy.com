using Volo.Abp.Modularity;

namespace t3lmy.com;

/* Inherit from this class for your domain layer tests. */
public abstract class comDomainTestBase<TStartupModule> : comTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
