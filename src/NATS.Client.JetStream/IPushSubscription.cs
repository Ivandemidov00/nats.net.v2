namespace NATS.Client.JetStream;

public interface IPushSubscription : IAsyncDisposable
{
    CancellationToken Cancellation { get; }
}
