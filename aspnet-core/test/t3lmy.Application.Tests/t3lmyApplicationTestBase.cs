using Volo.Abp.Modularity;

namespace t3lmy;

public abstract class t3lmyApplicationTestBase<TStartupModule> : t3lmyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
