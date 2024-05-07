using Domain.Model.Aggregate.Events;
using Domain.Model.Aggregate.Values.Example;

namespace Domain.Model.Aggregate;

public class AggregateBehavior : Behavior
{
	public AggregateBehavior( Aggregate aggregate )
	{
		AddExampleCreatedSub( aggregate );
	}

	private void AddExampleCreatedSub( Aggregate aggregate )
	{
		AddSub( ( AggregateCreated domainEvent ) =>
		{
			aggregate.ExampleVO = ExampleVO.Of( domainEvent.Value );
		} );
	}
}
