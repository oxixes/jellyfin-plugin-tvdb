﻿using System;
using System.Collections.Generic;
using Jellyfin.Plugin.Tvdb.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.Tvdb
{
    /// <summary>
    /// Tvdb Plugin.
    /// </summary>
    public class TvdbPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Gets the provider name.
        /// </summary>
        public const string ProviderName = "TheTVDB";

        /// <summary>
        /// Gets the provider id.
        /// </summary>
        public const string ProviderId = "Tvdb";

        /// <summary>
        /// Initializes a new instance of the <see cref="TvdbPlugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
        /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
        public TvdbPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <summary>
        /// Gets current plugin instance.
        /// </summary>
        public static TvdbPlugin? Instance { get; private set; }

        /// <inheritdoc />
        public override string Name => "TheTVDB (Only upcoming)";

        /// <inheritdoc />
        public override Guid Id => new Guid("3a1bc6f7-9fc1-4a3d-953d-42a53467677f");

        /// <inheritdoc />
        public IEnumerable<PluginPageInfo> GetPages()
        {
            yield return new PluginPageInfo
            {
                Name = Name,
                EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.config.html"
            };
        }
    }
}