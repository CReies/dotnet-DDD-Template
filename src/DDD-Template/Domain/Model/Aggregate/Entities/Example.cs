using Domain.Model.Aggregate.Values.Example;

namespace Domain.Model.Aggregate.Entities;

public class Example : Entity<ExampleId>
{
	public ExampleVO ExampleVO { get; set; }

	private Example( ExampleId id, ExampleVO exampleVO ) : base( id )
	{
		ExampleVO = exampleVO;
	}

	private Example( ExampleVO exampleVO ) : base( new ExampleId() )
	{
		ExampleVO = exampleVO;
	}

	public static Example From( string exampleVO ) => new( ExampleVO.Of( exampleVO ) );

	public static Example From( string id, string exampleVO ) => new(
		ExampleId.Of( id ),
		ExampleVO.Of( exampleVO ) );
}
