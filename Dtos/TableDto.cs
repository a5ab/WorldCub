﻿namespace WorldCub.Dtos
{
    public class TableDto
    {
        public int Position { get; set; }

        public TeamDto Team { get; set; }

        public int playedGames { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int points { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
    }
}


