using System.Linq;
using System.Threading;
namespace XOProject
{
    public interface ITradeRepository : IGenericRepository<Trade>
    {
        IQueryable<TradeAnalysis> GetTradeAnalysis(string symbol);
       
        

    }
}