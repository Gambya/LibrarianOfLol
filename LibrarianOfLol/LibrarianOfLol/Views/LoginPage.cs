using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using RiotSharp;
using RiotSharp.SummonerEndpoint;
using Xamarin.Forms;
using IRiotApi = LibrarianOfLol.Infra.RiotApi.Interfaces.IRiotApi;
using RiotApi = LibrarianOfLol.Infra.RiotApi.Services.RiotApi;

namespace LibrarianOfLol.Views
{
    public class LoginPage : ContentPage
    {
        private readonly IRiotApi api;
        private readonly Picker _picRegion;
        private readonly Entry _etrSummoner;
        public LoginPage()
        {
            Title = "Login";
            //Instancia da Api Riot
            api = new RiotApi();

            //Seleção de Region
            _picRegion = new Picker
            {
                Title = "Select Region",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var listPicRegion = new List<Region>
            {
                Region.br,
                Region.eune,
                Region.euw,
                Region.global,
                Region.kr,
                Region.lan,
                Region.las,
                Region.na,
                Region.oce,
                Region.ru,
                Region.tr
            };
            foreach (var region in listPicRegion)
            {
                _picRegion.Items.Add(region.ToString());
            }
            _picRegion.SelectedIndexChanged += SelectPicker;
            //Entrada de nome do summonner
            _etrSummoner = new Entry
            {
                Placeholder = "Summonner Name",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            Content = new StackLayout
            {
                Children = {
                    _picRegion,
                    _etrSummoner
                }
            };
        }

        private async void SelectPicker(object sender, EventArgs e)
        {
            Summoner summoner = null; //Pesquisa na base local
            if (summoner == null)
            {
                summoner = await api.GetSummonerAsync(_picRegion.Items[_picRegion.SelectedIndex], _etrSummoner.Text);
                //grava em tabela local
            }
        }
    }
}
