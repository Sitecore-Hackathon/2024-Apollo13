﻿using System;

namespace Winner.Feature.Social.Models
{
    public class FeedItem
    {
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}