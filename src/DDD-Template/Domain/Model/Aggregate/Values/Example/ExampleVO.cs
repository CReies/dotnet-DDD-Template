namespace Domain.Model.Aggregate.Values.Example;

public class ExampleVO : IValueObject<string>
{
	public string Value { get; private set; }

	private ExampleVO( string value )
	{
		_ = value.Trim();

		if (string.IsNullOrEmpty( value )) throw new ArgumentException( "Value cannot be null or empty" );

		Value = value;
	}

	public static ExampleVO Of( string value ) => new ExampleVO( value );
}
