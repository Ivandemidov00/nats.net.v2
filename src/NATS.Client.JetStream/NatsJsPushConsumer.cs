using NATS.Client.JetStream.Models;

namespace NATS.Client.JetStream;

public class NatsJsPushConsumer : INatsJSPushConsumer
{
    public ConsumerInfo Info { get; }

    internal NatsJsPushConsumer(NatsJSContext natsJsContext, ConsumerInfo info, PushConsumerOptions options)
    {
        Info = info;
    }

    public Task<IPushSubscription> SubscribeAsync<T>(string subject, EventHandler<NatsJSMsg<T>> handler, CancellationToken cancellationToken = default)
    {

    }

    public IAsyncEnumerable<NatsJSMsg<T>> SubscribeAsyncEnumerable<T>(string subject, CancellationToken cancellationToken = default)
    {

    }
}
