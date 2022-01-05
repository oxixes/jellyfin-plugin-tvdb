using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Tvdb.Configuration
{
    /// <summary>
    /// Configuration for tvdb.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Gets or sets the tvdb api key.
        /// </summary>
        public string ApiKey { get; set; } = "OG4V3YJ3FAP7FP2K";

        /// <summary>
        /// Gets or sets the days since an episode was released for it to be added.
        /// </summary>
        public int DaysSince { get; set; } = 7;
    }
}