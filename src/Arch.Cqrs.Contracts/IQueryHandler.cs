namespace Arch.Cqrs.Contracts
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery: IQuery<TResult>
    {
        TResult Handle(TQuery query);   
    }
}
