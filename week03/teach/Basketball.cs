/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            players[playerId] = players.GetValueOrDefault(playerId) + points;
        }

        // Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        if (players.Count > 0) {
            Console.WriteLine("Top 10 Players:");
            var topPlayer = players.OrderByDescending(p => p.Value).Take(10).ToArray();
            for (var i = 0; i < topPlayer.Length; ++i) {
                Console.WriteLine($"{i + 1}. {topPlayer[i].Key} - {topPlayer[i].Value}");
            }
        }

        var topPlayers = new string[10];
    }
}