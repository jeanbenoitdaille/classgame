    using System;
    using System.Linq;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Score {
            public int userId {get;set;}
            public int scoreValue {get;set;}
            
            public Score(int _userId, int _scoreValue){
                userId = _userId;
                scoreValue = _scoreValue;
            }
        }
        
        public class ScoreManager
        {
            private Score[] _scores;
     
            public ScoreManager(List<Score> scores)
            {
                this._scores = scores.ToArray();
            }
     
            public List<Score> GetScores(){
                return _scores.ToList();
            }
     
            public int GetLastScore(){
                return _scores.Last().scoreValue;
            }
     
            public int GetHighScore(){
              return _scores.Max(x => x.scoreValue);
            }
     
            public List<int> GetTop3OfUser(int userId)
            {
              return _scores.Where(x => x.userId == userId)
                            .OrderByDescending(x => x.scoreValue)
                            .Take(3)
                            .Select(x => x.scoreValue)
                            .ToList();
            }
        }
    }