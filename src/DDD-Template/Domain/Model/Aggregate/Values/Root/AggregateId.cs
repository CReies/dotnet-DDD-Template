namespace Domain.Model.Aggregate.Values.Root;

public class AggregateId : Identity
{
	public AggregateId() : base() { }

	private AggregateId( string value ) : base( value ) { }

	public static AggregateId Of( string value ) => new AggregateId( value );
}
