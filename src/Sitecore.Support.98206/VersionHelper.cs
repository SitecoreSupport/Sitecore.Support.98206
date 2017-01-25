namespace Sitecore.Support.ContentTesting.Helpers
{
    using Sitecore;
    using Sitecore.Configuration;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Globalization;

    internal class VersionHelper
    {
        public static int GetLatestPublishedVersion(Item item)
        {
            Assert.ArgumentNotNull(item, "item");
            Database database = Context.ContentDatabase ?? Context.Database;
            int number = -1;
            ID iD = item.ID;
            Language language = item.Language;
            foreach (Database database2 in Factory.GetDatabases())
            {

                if ((database != null) && (database2.Name != database.Name))
                {
                    Item item2 = database2.GetItem(iD, language);
                    if ((item2 != null) && (item2.Version.Number > number))
                    {
                        number = item2.Version.Number;
                    }
                }
            }
            return number;
        }
    }
}
