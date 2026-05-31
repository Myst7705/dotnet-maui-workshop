using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace MonkeyFinder.Model;

public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string Image { get; set; }
    public int Population { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    [JsonSerializable(typeof(List<Monkey>))]
    internal sealed partial class MonkeyContext : JsonSerializerContext
    {
        public MonkeyContext(JsonSerializerOptions options) : base(options)
        {
        }

        protected override JsonSerializerOptions GeneratedSerializerOptions => throw new NotImplementedException();

        public override JsonTypeInfo GetTypeInfo(Type type)
        {
            throw new NotImplementedException();
        }
    }
}

