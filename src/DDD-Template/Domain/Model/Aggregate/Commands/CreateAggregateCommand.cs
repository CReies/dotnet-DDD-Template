namespace Domain.Model.Aggregate.Commands;

public class CreateAggregateCommand( string value ) : InitialCommand
{
	public string Value { get; set; } = value;
}
