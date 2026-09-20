using System;
using System.Collections.Generic;
using System.Text;

namespace ShooterGame
{
    public class Player
    {
        private string playerName;
        private int health;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
        public virtual int Attack()
        {
            return 0;
        }
        public virtual int Health()
        {
            return 0;
        }

        public virtual int CurrentHealth
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public virtual List<Image> GetPlayerImage() 
        {
            return null;
        }
        public virtual Image GetBulletImage()
        {
            return null;
        }
        public virtual List<Image> GetHPBarImage()
        {
            return null;
        }

        public int PlayerScore;
        public string CharacterType;
        public Player(string name, string type, int score) //Positions for characters
        {
            this.PlayerName = name;
            this.CharacterType = type;
            this.PlayerScore = score;
            
        }
    }
}
