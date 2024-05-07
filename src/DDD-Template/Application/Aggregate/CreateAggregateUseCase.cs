using Domain.Generic;
using Domain.Model.Aggregate.Commands;

namespace Application.Aggregate;

public class CreateAggregateUseCase( IEventsRepository repository ) : IInitialCommandUseCase<CreateAggregateCommand>
{
	private readonly IEventsRepository _repository = repository;

	public List<DomainEvent> Execute( CreateAggregateCommand command )
	{
		var aggregate = new Domain.Model.Aggregate.Aggregate( command.Value );
		var domainEvents = aggregate.GetUncommittedChanges();

		domainEvents.ForEach( ( DomainEvent domainEvent ) => { _repository.Save( domainEvent )} );
		aggregate.MarkAsCommitted();
		return domainEvents;
	}
}
