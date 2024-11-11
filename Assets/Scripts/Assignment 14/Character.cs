using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        private string _characterName;
        public string CharacterName
        {
            get { return _characterName; }
            set
            {
                _characterName = value;
            }
        }

        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }


        public Character(string characterName, int characterHealth)
        {
            this.CharacterName = characterName;
            this.Health = characterHealth;
        }
    }
}