using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Illimat.Models
{
    public class Deck
    {
        //constructors
        public Deck()
        {
            string[] suitList = new string[]
            {
                "Summer",
                "Winter",
                "Spring",
                "Autumn",
                "Stars"
            };
            string[] valueList = new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
            };
            List<IllimatCard> newDeck = new List<IllimatCard>();
            //create deck
            foreach (var suit in suitList)
            {
                IllimatCard newCard = new IllimatCard();
                foreach (var value in valueList)
                {
                    newCard.Suit = suit;
                    newCard.Value = value;
                    newDeck.Add(newCard);
                }
            }
            List<IllimatCard> shuffledDeck = new List<IllimatCard>();
            int deckCount = newDeck.Count();
            for (int i = 0; i < deckCount; i++)
            {
                Random random = new Random(shuffledDeck.Count());
                int newRandom = Convert.ToInt32(random);
                shuffledDeck.Insert(newRandom, newDeck[i]);
            }

            //set initial property values
            IllimatDeck = shuffledDeck;
            CardCount = shuffledDeck.Count;
        }

        //properties
        public List<IllimatCard> IllimatDeck { get; set; }
        public int CardCount { get; set; }

        //methods

    }
}