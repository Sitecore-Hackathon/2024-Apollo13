using Winner.Feature.Social.Models;
using System.Collections.Generic;

namespace Winner.Feature.Social.FeedReader
{
    public interface IFeedReader
    {
        public IList<FeedItem> GetFeed(string url);
    }
}
