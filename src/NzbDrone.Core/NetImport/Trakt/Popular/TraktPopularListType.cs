using System.Runtime.Serialization;

namespace NzbDrone.Core.NetImport.Trakt.Popular
{
    public enum TraktPopularListType
    {
        [EnumMember(Value = "Trending Movies")]
        Trending = 1,
        [EnumMember(Value = "Popular Movies")]
        Popular = 2,
        [EnumMember(Value = "Top Anticipated Movies")]
        Anticipated = 3,
        [EnumMember(Value = "Top Box Office Movies")]
        BoxOffice = 4,

        [EnumMember(Value = "Top Watched Movies By Week")]
        TopWatchedByWeek = 5,
        [EnumMember(Value = "Top Watched Movies By Month")]
        TopWatchedByMonth = 6,
        [EnumMember(Value = "Top Watched Movies By Year")]
        TopWatchedByYear = 7,
        [EnumMember(Value = "Top Watched Movies Of All Time")]
        TopWatchedByAllTime = 8
    }
}
