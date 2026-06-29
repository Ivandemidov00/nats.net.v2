using NATS.Client.JetStream.Models;

namespace NATS.Client.JetStream;

public interface INatsJSConsumerBase
{
    /// <summary>
    /// Consumer info object as retrieved from NATS JetStream server at the time this object was created, updated or refreshed.
    /// </summary>
    ConsumerInfo Info { get; }
}
