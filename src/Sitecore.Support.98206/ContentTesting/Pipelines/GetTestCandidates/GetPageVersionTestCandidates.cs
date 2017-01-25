using Sitecore.Data.Items;
using Sitecore.Diagnostics;

namespace Sitecore.Support.ContentTesting.Pipelines.GetTestCandidates
{
    public class GetPageVersionTestCandidates :
        Sitecore.ContentTesting.Pipelines.GetTestCandidates.GetPageVersionTestCandidates
    {
        protected override int GetLatestPublishedVersion(Item item)
        {
            Assert.ArgumentNotNull(item, "item");
            return Sitecore.Support.ContentTesting.Helpers.VersionHelper.GetLatestPublishedVersion(item);
        }
    }
}
