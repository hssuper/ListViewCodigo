using ListViewCodigo.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewCodigo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            ListView lstview = new ListView();
            lstview.ItemsSource = new List<Time>
            {
                new Time
                {
                    nome = "Flamengo",
                    imagem = "img/flamengo.png",
                    descricao = "A Maior torcida do mundo  O Clube de Regatas do Flamengo(mais conhecido simplesmente como Flamengo, e popularmente pelos apelidos de Mengo, Mengão e Fla) é uma agremiação poliesportiva brasileira com sede na cidade do Rio de Janeiro," +
                    " capital do estado de mesmo nome.Fundado no bairro de mesmo nome[nota 1] para disputas de remo em 17 de novembro de 1895,[2] [11] tornou-se um dos clubes mais bem-sucedidos e populares do esporte brasileiro, especialmente pelo futebol." +
                    "Tem como suas cores tradicionais o vermelho e o preto e como seus maiores rivais esportivos o Vasco da Gama, o Fluminense e o Botafogo.Dentre suas maiores glórias no futebol, destacam-se as conquistas da Copa Intercontinental[nota 2] (único time carioca a ter conquistado um título de dimensão mundial reconhecido pela FIFA)[12] e das Copas Libertadores da América de 1981" +
                    "[nota 3] e de 2019 (único time carioca a ter conquistado por duas vezes a competição, e um dos sete do Brasil a tê-la conquistado mais de uma vez), além de uma Recopa Sul-Americana, uma Copa Mercosul e uma Copa de Ouro Nicolás Leoz, o que lhe confere a quinta posição no ranking de títulos internacionais de clubes brasileiros.Em se tratando de Copa Libertadores da América o Flamengo, juntamente ao Independiente, os dois únicos clubes com 100% de aproveitamento" +
                    " na final da competição, entre os clubes que chegaram em mais de uma final do torneio, o quinto com maior aproveitamento na competição, além de ser o clube com o melhor desempenho considerando apenas duelos entre equipes brasileiras até 2019.Em relação às conquistas a nível nacional o Flamengo é, por decisão judicial, e em seguida, pela CBF, oficialmente detentor de sete títulos do Campeonato Brasileiro (1980, 1982, 1983, 1992, 2009, 2019 e 2020) — além da controversa Copa União de 1987[nota 4] —, três títulos da Copa do Brasil, duas Supercopas do Brasil e uma Copa dos Campeões.Estas quatorze conquistas dão ao clube o segundo lugar no ranking de títulos nacionais, atrás apenas do Palmeiras.[28] Com relação a nível regional e estadual, o clube conquistou um Torneio Rio-São Paulo, uma Taça dos Campeões Estaduais Rio–São Paulo e trinta e sete títulos do Campeonato Carioca, sendo o maior vencedor da competição estadual.Por conta destes resultados, o clube é, desde 2017, o líder nacional do Ranking Folha, que dá uma pontuação para títulos e vice-campeonatos conquistados pelas equipes, [29] sendo, atualmente, um dos clubes brasileiros com mais conquistas no que diz respeito ao somatório de títulos reconhecidos de abrangência nacionais e internacionais," +
                    " [30][31] o quinto clube brasileiro (empatado com o Grêmio) no que diz respeito ao somatório de títulos reconhecidos de abrangência internacional,[32] o segundo em abrangência nacional, e em termos estaduais, é o clube do Estado do Rio de Janeiro com o maior número de títulos oficiais no futebol, considerando títulos de todas as abrangências(internacional, nacional e regional/estadual). Possui o maior número de conquistas do Campeonato Brasileiro considerando a partir de 1971 (quando foi adotado o nome de Campeonato Nacional de Clubes),[33] [34] com 7 títulos[35] (empatado com o Corinthians Paulista); contando a Copa União, já listada pela CBF em meio aos títulos brasileiros de 1983 e 1992 como conquista à parte,[36] seria o maior campeão isoladamente.Também é o time com mais jogos na disputa: 1443 (1971 a 2021).[37] Entre outros feitos, o Flamengo foi eleito o nono maior clube de futebol do Século XX, em levantamento realizado pela FIFA[38]. E em 2019 o Flamengo foi eleito o melhor time da América do Sul[39], e o 4º melhor do mundo, conforme o ranking elaborado pela IFFHS.É um dos três clubes do país, ao lado de Santos e São Paulo, que jamais foram rebaixados para a segunda divisão do campeonato nacional. É, ao lado do Santos, os dois únicos clubes a terem conquistado a Copa Libertadores e o Campeonato Brasileiro numa mesma temporada (feito este alcançado em 2019).[40] É também, ao lado do Atlético Mineiro, Santa Cruz, Arsenal(Inglaterra), e Dublin(Uruguai)," +
                    " um dos cinco únicos clubes do mundo que já venceram a Seleção Brasileira de Futebol.[41] Detém, junto ao Botafogo, a maior sequência invicta do futebol brasileiro com 52 partidas em 1979[42] e foi o primeiro clube do Brasil a atingir a marca de mil jogos na primeira divisão do campeonato nacional, em partida realizada contra o Santos em 27 de julho de 2009.[43]O Flamengo é o clube de futebol mais popular do Brasil,[45] [46] com uma torcida estimada em 40,4 milhões[47] de torcedores espalhados por todas as regiões do Brasil.[48][49] Segundo levantamento conduzido pela agência de marketing desportivo Gerardo Molina-Euroamerica, o Flamengo é, em números absolutos, o clube de futebol com o maior número de seguidores em todo o mundo.[50][51] Em razão da força de sua torcida, é o clube brasileiro que mais recebe valores de direitos de transmissão.[52] Desde 2018, o Flamengo é considerado o clube mais valioso do Brasil, [53] tornando-se em 2019, o time mais valioso da América do Sul, além de ser o 70º time de futebol mais valioso do mundo, avaliado em mais de 145,7 milhões de euros.[54Além do prestígio com o futebol, o Flamengo também se destaca em outras modalidades esportivas coletivas e individuais, notadamente no remo, no polo aquático e no basquetebol. Neste último, é um dos clubes mais tradicionais do país, tendo a sua equipe de basquetebol masculino conquistado quarenta e seis títulos estaduais, sete títulos Brasileiros, um Campeonato Sul-Americano de Clubes Campeões," +
                    " uma Liga Sul-Americana, uma Liga das Américas, uma Champions League Américas e uma Copa Intercontinental FIBA.",
                    tecnico = "Renato Gaúcho",
                    jogador = new string[] {"Diego 1","Gustavo 2", "Rodrigo 3", "jogador 4", "jogador 5", "jogador 6", "jogador 7", "jogador 8", "jogador 9", "jogador 10", "jogador 11" }

                },
                new Time
                {
                    nome = "Fluminense",
                    imagem = "img/fluminense.png",
                    tecnico = "fulano",
                    descricao = "A Maior torcida do mundo",
                    jogador = new string[] {"Diego 1","Gustavo 2", "Rodrigo 3", "jogador 4", "jogador 5", "jogador 6", "jogador 7", "jogador 8", "jogador 9", "jogador 10", "jogador 11" }

                },
                new Time
                {
                    nome = "Botafogo",
                    imagem = "img/botafogo.png",
                    tecnico = "fulano",
                    descricao = "A Maior torcida do mundo",
                    jogador = new string[] {"Diego 1","Gustavo 2", "Rodrigo 3", "jogador 4", "jogador 5", "jogador 6", "jogador 7", "jogador 8", "jogador 9", "jogador 10", "jogador 11" }

                }
           
       
        
        };

            lstview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            lstview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "imagem");
            lstview.ItemTemplate.SetBinding(ImageCell.TextProperty, "nome");
            lstview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "tecnico");
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            lstview.ItemSelected += Lstview_ItemSelected;
            lstview.ItemTapped += Lstview_ItemTapped;

            Content = lstview;
        }

        private void Lstview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }

        private void Lstview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var time = e.SelectedItem as Time;
            Navigation.PushAsync(new Apresentacao(time));
        }
    }
}
