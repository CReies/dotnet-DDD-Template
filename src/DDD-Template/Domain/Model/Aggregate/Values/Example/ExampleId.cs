namespace Domain.Model.Aggregate.Values.Example;

public class ExampleId : Identity
{
	public ExampleId() : base() { }

	private ExampleId( string value ) : base( value ) { }

	public static ExampleId Of( string value ) => new ExampleId( value );
}
