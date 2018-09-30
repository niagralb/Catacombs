using GameEngine.BodyParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    // Contains general information about a character
    public class Character
    {
        // Characteristics
        private string Name { get; set; }
        private int Tier { get; set; }       // 1 - 20
        private int Gender { get; set; }     // 0: other, 1: male, 2: female
        private int Age { get; set; }

        // Game attributes
        // Stat modifiers
        private StatList _charBaseStats;
        private StatList _charAdjustedStats;

        // Main body areas
        private Head _head;
        private UpperBody _upperBody;
        private LowerBody _lowerBody;

        public Character(String name, int startingTier, int startingAge, int gender)
        {
            this.Name = name;
            this.Tier = startingTier;
            this.Gender = gender;
            this.Age = startingAge;

            InitStats(startingTier);
        }

        private void InitStats(int tier)
        {
            _charBaseStats = new StatList(false, tier);
        }

        private void UpdateAdjustedStats()
        {
            _charAdjustedStats = _charBaseStats.CombineStats();
        }
    }
}
