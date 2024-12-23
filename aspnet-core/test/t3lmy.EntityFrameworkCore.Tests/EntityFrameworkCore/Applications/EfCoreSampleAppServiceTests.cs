using t3lmy.Samples;
using Xunit;

namespace t3lmy.EntityFrameworkCore.Applications;

[Collection(t3lmyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<t3lmyEntityFrameworkCoreTestModule>
{

}
