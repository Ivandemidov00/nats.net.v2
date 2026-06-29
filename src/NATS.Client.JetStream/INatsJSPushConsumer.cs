using NATS.Client.JetStream.Models;

namespace NATS.Client.JetStream;

public interface INatsJSPushConsumer : INatsJSConsumerBase
{
    Task<IPushSubscription> SubscribeAsync<T>(
        string subject,
        EventHandler<NatsJSMsg<T>> handler,
        CancellationToken cancellationToken = default);

    IAsyncEnumerable<NatsJSMsg<T>> SubscribeAsyncEnumerable<T>(
        string subject,
        CancellationToken cancellationToken = default);
}
