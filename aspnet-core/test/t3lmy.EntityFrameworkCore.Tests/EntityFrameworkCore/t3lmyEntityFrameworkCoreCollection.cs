using Xunit;

namespace t3lmy.EntityFrameworkCore;

[CollectionDefinition(t3lmyTestConsts.CollectionDefinitionName)]
public class t3lmyEntityFrameworkCoreCollection : ICollectionFixture<t3lmyEntityFrameworkCoreFixture>
{

}
