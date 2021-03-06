using Sitecore.Modules.WeBlog.Caching;

namespace Sitecore.Modules.WeBlog.Pipelines.ProfanityFilter
{
    public class GetProfanityListFromCache : IProfanityFilterProcessor
    {
        public void Process(ProfanityFilterArgs args)
        {
            if (CacheManager.ProfanityFilterCache.WorList != null)
            {
                args.WordList = CacheManager.ProfanityFilterCache.WorList;
            }
        }
    }
}