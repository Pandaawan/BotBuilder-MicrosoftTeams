// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// O365 connector card OpenUri target
    /// </summary>
    public partial class O365ConnectorCardOpenUriTarget
    {
        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardOpenUriTarget
        /// class.
        /// </summary>
        public O365ConnectorCardOpenUriTarget() { }

        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardOpenUriTarget
        /// class.
        /// </summary>
        /// <param name="os">Target operating system. Possible values include:
        /// 'default', 'iOS', 'android', 'windows'</param>
        /// <param name="uri">Target url</param>
        public O365ConnectorCardOpenUriTarget(string os = default(string), string uri = default(string))
        {
            Os = os;
            Uri = uri;
        }

        /// <summary>
        /// Gets or sets target operating system. Possible values include:
        /// 'default', 'iOS', 'android', 'windows'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "os")]
        public string Os { get; set; }

        /// <summary>
        /// Gets or sets target url
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
