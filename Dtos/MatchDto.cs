namespace WorldCub.Dtos
{
    public class MatchDto
    {
        public DateTime utcDate {  get; set; }

        public string status { get; set; }
        public string stage { get; set; }
        public string group { get; set; }

        public TeamDto homeTeam { get; set; }
        public TeamDto awayTeam { get; set; }
        public ScoreDto score { get; set; }

    }
}
/*
 "": "2022-05-14T13:30:00Z",
            "": "FINISHED",
            "minute": "90",
            "injuryTime": 5,
            "attendance": null,
            "venue": "Signal Iduna Park",
            "matchday": 34,
            "": "REGULAR_SEASON",
            "": null,
            "lastUpdated": "2022-05-15T03:33:01Z",
            "": {
                "id": 4,
                "name": "Borussia Dortmund",
                "shortName": "Dortmund",
                "tla": "BVB",
                "crest": "https://crests.football-data.org/4.png",
                "coach": {
                    "id": 15111,
                    "name": "Marco Rose",
                    "nationality": "Germany"
                },
                "leagueRank": 2,
                "formation": "3-4-2-1",
                "lineup": [],
                "bench": []
            },
            "": {
                "id": 9,
                "name": "Hertha BSC",
                "shortName": "Hertha BSC",
                "tla": "BSC",
                "crest": "https://crests.football-data.org/9.svg",*/