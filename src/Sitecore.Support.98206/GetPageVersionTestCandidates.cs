using System;
using Sitecore.ContentTesting.Data.Configuration;
using Sitecore.ContentTesting.Pipelines.GetTestCandidates;
using Sitecore.Data;

namespace Sitecore.Support.ContentTesting.Pipelines.GetTestCandidates
{
    using Sitecore.ContentTesting.Helpers;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;


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
