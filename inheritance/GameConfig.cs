using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class GameConfig
    {
        public string menuMessage = "";
        public string menuOptions = "";
        public string mainMenuChoice;
        public int gameRound = 1;
        public int round = 1;
        public int limit = 3;
        public string playerOneChoice;
        public string playerTwoChoice;
        public bool validationCheck = false;

        public List<string> gestures = new List<string>(new string[]
       {
            "Rock",
            "Paper",
            "Scissors",
            "Lizard",
            "Spock"
       }
       );

        public List<string> rules = new List<string>(new string[]
      {
            "Rock crushes Scissors",
            "Scissors cuts Paper",
            "Paper covers Rock",
            "Rock boulders Lizard",
            "Lizard eats Spock",
            "Spock destroys Scissors",
            "Scissors chop Lizard",
            "Lizard rips Paper",
            "Paper disproves Spock",
            "Spock vaporizes Rock"
      }
      );
    }
}
