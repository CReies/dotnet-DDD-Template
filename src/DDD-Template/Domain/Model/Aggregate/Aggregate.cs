using Domain.Model.Aggregate.Events;
using Domain.Model.Aggregate.Values.Example;
using Domain.Model.Aggregate.Values.Root;

namespace Domain.Model.Aggregate;

public class Aggregate : AggregateRoot<AggregateId>
{
	public ExampleVO ExampleVO { get; set; }

	public Aggregate( AggregateId identity ) : base( identity ) { }

	public Aggregate( string exampleVO ) : base( new AggregateId() )
	{
		Subscribe( new AggregateBehavior( this ) );
		ExampleVO = ExampleVO.Of( exampleVO );

		AppendEvent( new AggregateCreated( Id.Value, ExampleVO.Value ) );
	}

	public static Aggregate From( string aggregateId, string exampleVO )
	{
		return new Aggregate( aggregateId )
		{
			ExampleVO = ExampleVO.Of( exampleVO )
		};
	}

	public static Aggregate From( string aggregateId, List<DomainEvent> events )
	{
		var aggregate = new Aggregate( AggregateId.Of( aggregateId ) );
		events.ForEach( aggregate.Apply );

		return aggregate;
	}
}
