using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MarvelCards.ViewModels
{
    public class HeroCardsViewModel
    {
        public ObservableCollection<Hero> Heroes { get; set; }

        public HeroCardsViewModel()
        {
            Heroes = new ObservableCollection<Hero>()
            {
                new Hero()
                {
                    HeroName = "spider man",
                    RealName = "peter parker",
                    Image = "spiderman.png",
                    HeroColor = "#C51925",
                    Posters = new List<string>()
                    {
                        "spiderman_1.png",
                        "spiderman_2.png",
                        "spiderman_3.png",
                        "spiderman_4.png",
                    },
                    Bio = "Peter Benjamin Parker nasceu em C.I.A. agentes Richard e Mary Parker, que foram mortos quando Peter era muito jovem. Após a morte de seus pais, Peter foi criado por seu tio Ben e tia May em uma casa modesta em Forest Hills, Nova York."

                },
                new Hero()
                {
                    HeroName = "iron man",
                    RealName = "tony stark",
                    Image = "ironman.png",
                    HeroColor = "#DF8E04",
                    Posters = new List<string>()
                    {
                        "ironman_1.png",
                        "ironman_2.png",
                        "ironman_3.png",
                        "ironman_4.png",
                    },
                    Bio = "Tony Stark é um gênio excêntrico auto-descrito, bilionário, playboy e filantropo e ex-chefe da Stark Industries."
                },
                  new Hero()
                {
                    HeroName =  "    Huck",
                    RealName = "bruce banner",
                    Image = "huck.png",
                    HeroColor = "#15400E",
                    Posters = new List<string>()
                    {
                        "huck_04.png",
                        "huck_02.png",
                        "huck_03.png",
                        "huck_01.png",
                    },
                    Bio = "O Hulk é um poderoso alter ego do Dr. Bruce Banner, um cientista que foi atingido por raios gama enquanto salvava um adolescente durante o teste militar de uma bomba por ele desenvolvida."
                }
            };
        }
    }

    public class Hero
    {
        public string HeroName { get; set; }
        public string RealName { get; set; }
        public string Image { get; set; }
        public string HeroColor { get; set; }
        public string Bio { get; set; }
        public List<string> Posters { get; set; }

    }
}
