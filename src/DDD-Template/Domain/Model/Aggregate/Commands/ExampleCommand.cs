using Domain.Model.Aggregate.Values.Root;

namespace Domain.Model.Aggregate.Commands;

public class ExampleCommand(
	string aggregateId,
	string value ) : Command<AggregateId>( AggregateId.Of( aggregateId ) )
{
	public string Value { get; set; } = value;
}
