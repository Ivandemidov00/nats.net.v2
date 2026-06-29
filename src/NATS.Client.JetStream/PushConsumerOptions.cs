namespace NATS.Client.JetStream;

public record PushConsumerOptions : NatsJSConsumeOpts
{
    public string? Durable { get; set; }

    public string? Stream { get; set; }

    public bool AutoAck { get; set; } = true;

    public bool Bind { get; set; } = false;
}
