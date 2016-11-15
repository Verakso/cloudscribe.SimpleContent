﻿

namespace cloudscribe.SimpleContent.Models
{
    public class DefaultBlogRoutes : IBlogRoutes
    {
        public string PostWithDateRouteName { get; } = ProjectConstants.PostWithDateRouteName;

        public string PostWithoutDateRouteName { get; } = ProjectConstants.PostWithoutDateRouteName;

        public string MostRecentPostRouteName { get; } = ProjectConstants.MostRecentPostRouteName;

        public string BlogCategoryRouteName
        {
            get { return ProjectConstants.BlogCategoryRouteName; }
        }

        public string BlogArchiveRouteName
        {
            get { return ProjectConstants.BlogArchiveRouteName; }
        }

        public string NewPostRouteName
        {
            get { return ProjectConstants.NewPostRouteName; }
        }

        public string BlogIndexRouteName
        {
            get { return ProjectConstants.BlogIndexRouteName; }
        }

    }
}
