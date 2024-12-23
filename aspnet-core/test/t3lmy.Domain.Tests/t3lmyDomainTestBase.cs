using Volo.Abp.Modularity;

namespace t3lmy;

/* Inherit from this class for your domain layer tests. */
public abstract class t3lmyDomainTestBase<TStartupModule> : t3lmyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
