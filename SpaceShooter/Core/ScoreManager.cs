using System;

namespace SpaceShooter.Core
{
    public class ScoreManager
    {


        private readonly GameSession _session;

        public ScoreManager(GameSession session)
        {
            
            _session = session;
            ResetScore();

        }

        public void AddScore(int points)
        {
            if (points > 0)
            {
                _session.Score += points;
            }
        }

        public void ResetScore()
        {
            _session.Score = 0;
        }
    }
}
