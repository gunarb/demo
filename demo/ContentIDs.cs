using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Shell.Feeds.FeedTypes;

namespace demo
{
    public struct ContentIDs
    {
        public struct HasContent
        {
            public static readonly string ID = "{728070E0-57D0-4722-882E-98CE37A40650}";
            public struct Fields
            {
                public static readonly string Title = "{2514CDA6-5867-4151-A5FD-B96B33CC8225}";
                public static readonly string Description = "{82F27516-E5C8-44D6-AC84-EB1B92015426}";
            }
        }

        public struct HasDestination
        {
            public static readonly string ID = "{B9242340-A680-4CBF-A4CF-2C1144A84BB2}";
            public struct Fields
            {
                public static readonly string Destination = "{14E2D05F-A3BD-4613-BBBB-F46443B98B20}";
            }
        }

        public struct HasImage
        {
            public static readonly string ID = "{9E43A519-F46A-4F5C-905F-6D4B7C6A84A3}";
            public struct Fields
            {
                public static readonly string Image = "{58F43E4D-A896-4BAC-9C96-9CA78BB8BBC7}";
            }
        }
    }
}