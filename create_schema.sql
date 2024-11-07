CREATE TABLE leaderboard_entries (
    player_id SERIAL PRIMARY KEY,
    player_name VARCHAR(100) NOT NULL,
    player_score INT NOT NULL
);

-- Create an index to sort by player_score in descending order
CREATE INDEX idx_leaderboard_entries_score_desc ON leaderboard_entries (player_score DESC);
