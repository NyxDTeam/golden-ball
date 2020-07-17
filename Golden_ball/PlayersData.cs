using Golden_Ball.API.Models;
using Golden_Ball.Models;
using System;
using System.Collections.Generic;

namespace Golden_Ball
{
    public class PlayersData
    {
        public static PlayersData Current { get; } = new PlayersData();
        public List<PlayerDto> Players { get; set; }

        public PlayersData()
        {
            Players = new List<PlayerDto>()
            {
                new PlayerDto()
                {
                    Id = 1,
                    Name = "Stanley Matthews",
                    Year = 1956,
                    Club = "Blackpool",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {                 
                            Goals = 3,
                            Assists = 0
                        },
                    }
                                                                                                                    
                },
                new PlayerDto()
                {
                    Id = 2,
                    Name = "Alfredo Di Stéfano",                   
                    Year = 1957,
                    Club = "Real Madrid",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {                            
                            Goals = 43,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 3,
                    Name = "Raymond Kopa",                    
                    Year = 1958,
                    Club = "Real Madrid",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {                            
                            Goals = 11,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 4,
                    Name = "Alfredo Di Stéfano",
                    Year = 1959,
                    Club = "Real Madrid",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 34,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 5,
                    Name = "Luis Suarez",
                    Year = 1960,
                    Club = "Barcelona",
                    Nationality = "Spanish",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 15,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 6,
                    Name = "Omar Sivori",
                    Year = 1961,
                    Club = "Juventus",
                    Nationality = "Italian",
                    PlayerStats = new List<StatOfPlayersDto>
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 15,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 7,
                    Name = "Josef Masopust",
                    Year = 1962,
                    Club = "Dukla Prague",
                    Nationality = "Czech",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 0,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 8,
                    Name = "Lev Yashin",                   
                    Year = 1963,
                    Club = "Dynamo Moscow",
                    Nationality = "Sovietic",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 0,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 9,
                    Name = "Denis Law",
                    Year = 1964,
                    Club = "Manchester United",
                    Nationality = "Scottish",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 46,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 10,
                    Name = "Eusébio",
                    Year = 1965,
                    Club = "Benfica",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 59,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 11,
                    Name = "Bobby Charlton",
                    Year = 1966,
                    Club = "Manchester United",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 18,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 12,
                    Name = "Flórian Albert",
                    Year = 1967,
                    Club = "Ferencv Rosi TC",
                    Nationality = "Hungarian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 28,
                            Assists = 0,
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 13,
                    Name = "George Best",
                    Year = 1968,
                    Club = "Manchester United",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 22,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 14,
                    Name = "Gianni Rivera",
                    Year = 1969,
                    Club = "Milan",
                    Nationality = "Italian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 6,
                            Assists = 2
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 15,
                    Name = "Gerd Muller",
                    Year = 1970,
                    Club = "Bayern Munich",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 39,
                            Assists = 14
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 16,
                    Name = "Johan Cruyff",
                    Year = 1971,
                    Club = "Ajax",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 37,
                            Assists = 6
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 17,
                    Name = "Franz Beckenbaeur",
                    Year = 1972,
                    Club = "Bayern Munich",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 7,
                            Assists = 8
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 18,
                    Name = "Johan Cruyff",
                    Year = 1973,
                    Club = "Ajax",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 23,
                            Assists = 13
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 19,
                    Name = "Johan Cruyff",
                    Year = 1974,
                    Club = "Ajax",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 27,
                            Assists = 1
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 20,
                    Name = "Oleg Blokhin",
                    Year = 1975,
                    Club = "Dynamo kiev",
                    Nationality = "Sovietic",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 23,
                            Assists = 2
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 21,
                    Name = "Franz Beckenbaeur",
                    Year = 1976,
                    Club = "Bayern Munich",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 7,
                            Assists = 5
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 22,
                    Name = "Allan Simonsen",
                    Year = 1977,
                    Club = "Borussia M'nchengladbach",
                    Nationality = "Danish",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 16,
                            Assists = 1
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 23,
                    Name = "Kevin Keegan",
                    Year = 1978,
                    Club = "Hamburger SV",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 12,
                            Assists = 0

                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 24,
                    Name = "Kevin Keegan",
                    Year = 1979,
                    Club = "Hamburger Sv",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 17,
                            Assists = 2
                        },
                    }

                },
                new PlayerDto()
                {
                    Id = 25,
                    Name = "Karl-Heinz Rummenigge",
                    Year = 1980,
                    Club = "Bayern Munich",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 39,
                            Assists = 1
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 26,
                    Name = "Karl-Heinz Rummenigge",
                    Year = 1981,
                    Club = "Bayer Munich",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 27,
                            Assists = 15
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 27,
                    Name = "Paolo Rossi",
                    Year = 1982,
                    Club = "Juventus",
                    Nationality = "Italian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 18,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 28,
                    Name = "Michel Platini",
                    Year = 1983,
                    Club = "Juventus",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 25,
                            Assists = 0
                        }
                    }
                },
                new PlayerDto()
                {
                    Id = 29,
                    Name = "Michel Platini",
                    Year = 1984,
                    Club = "Juventus",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 29,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 30,
                    Name = "Michel Platini",
                    Year = 1985,
                    Club = "Juventus",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 16,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 31,
                    Name = "Igor Belanov",
                    Year = 1986,
                    Club = "Dynamo Kiev",
                    Nationality = "Sovietic",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 14,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 32,
                    Name = "Ruud Gulit",
                    Year = 1987,
                    Club = "PSV",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 24,
                            Assists = 14
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 33,
                    Name = "Marco Van Basten",
                    Year = 1988,
                    Club = "Milan",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 33,
                            Assists = 12
                        },
                    }
                                             
                },
                new PlayerDto()
                {
                    Id = 34,
                    Name = "Marco Van Basten",
                    Year = 1989,
                    Club = "Milan",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 24,
                            Assists = 5
                        },
                    }

                },
                new PlayerDto()
                {
                    Id = 35,
                    Name = "Lothar Matthaus",
                    Year = 1990,
                    Club = "Internazionale",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 23,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 36,
                    Name = "Jean-Pierre Papin",
                    Year = 1991,
                    Club = "Marseille",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 36,
                            Assists = 4
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 37,
                    Name = "Marco Van Basten",
                    Year = 1992,
                    Club = "Milan",
                    Nationality = "Dutch",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 29,
                            Assists = 13
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 38,
                    Name = "Roberto Baggio",
                    Year = 1993,
                    Club = "Juventus",
                    Nationality = "Italian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 23,
                            Assists = 1
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 39,
                    Name = "Hristo Stoichkov",
                    Year = 1994,
                    Club = "Barcelona",
                    Nationality = "Bulgarian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 17,
                            Assists = 1
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 40,
                    Name = "George Weah",
                    Year = 1995,
                    Club = "Milan",
                    Nationality = "Liberian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 15,
                            Assists = 15
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 41,
                    Name = "Matthias Sammer",
                    Year = 1996,
                    Club = "Borussia Dortmund",
                    Nationality = "German",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 0,
                            Assists = 6
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 42,
                    Name = "Ronaldo",
                    Year = 1997,
                    Club = "Internazionale",
                    Nationality = "Brazilian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 34,
                            Assists = 5
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 43,
                    Name = "Zinedine Zidane",
                    Year = 1998,
                    Club = "Juventus",
                    Nationality = "French",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 2,
                            Assists = 5
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 44,
                    Name = "Rivaldo",
                    Year = 1999,
                    Club = "Barcelona",
                    Nationality = "Brazilian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 23,
                            Assists = 3
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 45,
                    Name = "Luis Figo",
                    Year = 2000,
                    Club = "Real Madrid",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 14,
                            Assists = 27
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 46,
                    Name = "Michael Owen",
                    Year = 2001,
                    Club = "Liverpool",
                    Nationality = "English",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 28,
                            Assists = 6
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 47,
                    Name = "Ronaldo",
                    Year = 2002,
                    Club = "Real Madrid",
                    Nationality = "Brazilian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 30,
                            Assists = 8
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 48,
                    Name = "Pavel Nedved",
                    Year = 2003,
                    Club = "Juventus",
                    Nationality = "Czech",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 8,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 49,
                    Name = "Andriy Shevchenko",
                    Year = 2004,
                    Club = "Milan",
                    Nationality = "Ukrainian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 26,
                            Assists = 4
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 50,
                    Name = "Ronaldinho",
                    Year = 2005,
                    Club = "Barcelona",
                    Nationality = "Brazilian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 26,
                            Assists = 24
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 51,
                    Name = "Fabio Cannavaro",
                    Year = 2006,
                    Club = "Real Madrid",
                    Nationality = "Italian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 0,
                            Assists = 0
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 52,
                    Name = "Kaká",
                    Year = 2007,
                    Club = "Milan",
                    Nationality = "Brazilian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 19,
                            Assists = 16
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 53,
                    Name = "Cristiano Ronaldo",
                    Year = 2008,
                    Club = "Manchester United",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 26,
                            Assists = 12
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 54,
                    Name = "Lionel Messi",
                    Year = 2009,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 47,
                            Assists = 13
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 55,
                    Name = "Lionel Messi",
                    Year = 2010,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 53,
                            Assists = 14
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 56,
                    Name = "Lionel Messi",
                    Year = 2011,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 73,
                            Assists = 32
                        }
                    }        
                },
                new PlayerDto()
                {
                    Id = 57,
                    Name = "Lionel Messi",
                    Year = 2012,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 60,
                            Assists = 15
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 58,
                    Name = "Cristiano Ronaldo",
                    Year = 2013,
                    Club = "Real Madrid",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 51,
                            Assists = 17
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 59,
                    Name = "Cristiano Ronaldo",
                    Year = 2014,
                    Club = "Real Madrid",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 61,
                            Assists = 22
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 60,
                    Name = "Lionel Messi",
                    Year = 2015,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 41,
                            Assists = 24
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 61,
                    Name = "Cristiano Ronaldo",
                    Year = 2016,
                    Club = "Real Madrid",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 42,
                            Assists = 11
                        }
                    }
                },
                new PlayerDto()
                {
                    Id = 62,
                    Name = "Cristiano Ronaldo",
                    Year = 2017,
                    Club = "Real Madrid",
                    Nationality = "Portuguese",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 44,
                            Assists = 8
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 63,
                    Name = "Luka Modric",
                    Year = 2018,
                    Club = "Real Madrid",
                    Nationality = "Croatian",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 4,
                            Assists = 8
                        },
                    }
                },
                new PlayerDto()
                {
                    Id = 64,
                    Name = "Lionel Messi",
                    Year = 2019,
                    Club = "Barcelona",
                    Nationality = "Argentine",
                    PlayerStats = new List<StatOfPlayersDto>()
                    {
                        new StatOfPlayersDto()
                        {
                            Goals = 51,
                            Assists = 21
                        },
                    }
                }
            };
        }
    }
}
