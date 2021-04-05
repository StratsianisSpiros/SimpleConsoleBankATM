using System;
using System.Collections.Generic;
using BankSystem.Models;

namespace BankSystem.Data
{
    class AllData
    {
        private static List<CardHolder> cardHolders = new List<CardHolder>(){
            new CardHolder("Happy", "Botter", 0756787564, new DateTime(1982, 12, 23), "Plastira 5", "Athens"),
            new CardHolder("Peter", "Marker", 0745698324, new DateTime(1980, 2, 3), "Ioanninon 24", "Larisa"),
            new CardHolder("Michael", "Klaxon", 0876598475, new DateTime(1978, 6, 15), "Pylaias 12", "Thessaloniki"),
            new CardHolder("John", "Howler", 0975487612, new DateTime(1985, 11, 21), "Kavals 8", "Volos"),
            new CardHolder("Marc", "Troben", 0568745867, new DateTime(1987, 5, 13), "Omonoias 123", "Athens"),
        };

        private static List<Account> accounts = new List<Account>(){
            new Account(cardHolders[0],"Pireaus", 2000m, 500m),
            new Account(cardHolders[0],"Alpha Bank", 15000m, 5000m),
            new Account(cardHolders[1],"National Bank of Greece", 12000m, 3000m),
            new Account(cardHolders[1],"Pireaus", 1200m, 700m),
            new Account(cardHolders[2],"Attica Bank", 5000m, 1000m),
            new Account(cardHolders[2],"Citibank", 3000m, 800m),
            new Account(cardHolders[3],"National Bank of Greece", 2700m, 5000m),
            new Account(cardHolders[3],"Alpha Bank", 2500m, 4000m),
            new Account(cardHolders[4],"Attica Bank", 1800m, 5000m),
            new Account(cardHolders[4],"Citibank", 30000m, 20000m)
        };

        private List<Card> cards = new List<Card>(){
            new Card( 047548347012, 2, 352, 0789, new DateTime(2022, 5, 23), accounts[0]),
            new Card(456789583242, 1, 154, 6756, new DateTime(2022, 7, 3), accounts[1]),
            new Card(576395823756, 3, 654, 9865, new DateTime(2021, 8, 14), accounts[2]),
            new Card( 987489674960, 2, 768, 4565, new DateTime(2022, 7, 25), accounts[3]),
            new Card(094938764456, 1, 453, 7689, new DateTime(2023, 12, 17), accounts[4]),
            new Card( 385769494532, 3, 211, 3456, new DateTime(2024, 6, 18), accounts[5]),
            new Card( 234657835456, 3, 786, 9895, new DateTime(2023, 11, 28), accounts[6]),
            new Card( 123457789000, 1, 980, 3465, new DateTime(2025, 10, 13),  accounts[7]),
            new Card( 857374969359, 1, 098, 1265, new DateTime(2022, 5, 6), accounts[8]),
            new Card( 847275563758, 2, 476, 2327, new DateTime(2025, 8, 8), accounts[9])
        };

        public List<Card> GetCardList()
        {
            return cards;
        }
    }
}
