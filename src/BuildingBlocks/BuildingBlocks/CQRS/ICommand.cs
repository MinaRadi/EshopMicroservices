using MediatR;

namespace BuildingBlocks.CQRS;

// Icmmand without response
public interface ICommand : ICommand<Unit>
{
}
// Icommand with response
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}

