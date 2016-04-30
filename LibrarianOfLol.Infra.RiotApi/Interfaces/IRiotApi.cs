using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.SummonerEndpoint;

namespace LibrarianOfLol.Infra.RiotApi.Interfaces
{
    public interface IRiotApi
    {
        Task<Summoner> GetSummonerAsync(string region, string nameSummoner);
    }
}