using System.Collections.Generic;

namespace YoutubeApi.Models
{
    /// <summary>
    /// Simulates a database where the videos are stored
    /// </summary>
    public static class FakeDb
    {
        public static List<Video> Videos
        {
            get
            {
                return new List<Video>
                {
                    new Video { Id = "jU5i1WjRBhE", Width = "640", Height = "390", Title="Ice Climbing Frozen Niagara Falls - Will Gadd's First Ascent" },
                    new Video { Id = "XdlmoLAbbiQ", Width = "640", Height = "390", Title="This is the most amazing drone we've seen yet" },
                    new Video { Id = "VxNBiAV4UnM", Width = "640", Height = "390", Title="You Don't See in 4K" }
                };
            }
        }
    }
}
