using System;
using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.SummonerEndpoint;
using IRiotApi = LibrarianOfLol.Infra.RiotApi.Interfaces.IRiotApi;

namespace LibrarianOfLol.Infra.RiotApi.Services
{
    public class RiotApi : IRiotApi
    {
        public const string Key = "224c0662-1cb7-4372-b6c9-ad2170dd62c4";
        public async Task<Summoner> GetSummonerAsync(string region, string nameSummoner)
        {
            var api = RiotSharp.RiotApi.GetInstance(Key);
            Region riotRegion;
            Enum.TryParse<Region>(region, out riotRegion);
            var summoner = await api.GetSummonerAsync(riotRegion, nameSummoner);
            return summoner;
        }
    }
}