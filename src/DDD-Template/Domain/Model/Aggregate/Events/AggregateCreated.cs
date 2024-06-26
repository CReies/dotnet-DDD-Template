﻿namespace Domain.Model.Aggregate.Events;

public class AggregateCreated( string aggregateId, string value ) : DomainEvent( EventsEnum.EXAMPLE_CREATED.ToString() )
{
	public new string AggregateId { get; set; } = aggregateId;
	public string Value { get; set; } = value;
}
