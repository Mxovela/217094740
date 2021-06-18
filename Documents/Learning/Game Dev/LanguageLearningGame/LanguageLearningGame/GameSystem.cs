using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearningGame
{
    abstract class GameSystem
    {
        private int score;
        #region Constructor
        public GameSystem(int score)
        {
            this.score = score;
        }

        #endregion
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        #region AbstractMethods
        public abstract void home();
        public abstract void tips();

        public abstract void totalScore();
        #endregion

    }
}
