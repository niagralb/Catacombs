using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class StatList
    {
        private const int NUMBER_OF_STATS = 10;

        private const int INDEX_HP = 0;             // Hit Points
        private const int INDEX_MP = 1;             // Mana Points
        private const int INDEX_STR = 2;            // Strength - 
        private const int INDEX_INT = 3;            // Intelligence - 
        private const int INDEX_DEX = 4;            // Dexterity - 
        private const int INDEX_AGI = 5;            // Agility - 
        private const int INDEX_PER = 6;            // Perception - 
        private const int INDEX_REF = 7;            // Reflexes - 
        private const int INDEX_CHA = 8;            // Charisma - 
        private const int INDEX_LUK = 9;            // Luck

        private int[] _maxStatList = { 10, 10, 5, 5, 5, 5, 5, 5, 5, 1 };
        private int[] _statList = new int[NUMBER_OF_STATS];

        public StatList(bool isBodyPart, int DefaultStatLevel)
        {
            // 1: Weakest monster; 2: weak tier; 3: normal human; 4: normal monster; 5: adventurer; 6: elite monster; 7: hero ; 8: commander monster; 9: exalted hero ; 10: demon lord
            
            // Adjust values
            for (int i = 0; i < _maxStatList.Length; i++)
            {
                _maxStatList[i] = (int) Math.Pow(i, DefaultStatLevel);
                _statList[i] = _maxStatList[i] / 2;
            }  
        }

        public StatList(int[] newStats)
        {
            for (int i = 0; i < _maxStatList.Length; i++)
            {
                _statList[i] = newStats[i];
                _maxStatList[i] = newStats[i] * 2;
            }
        }

        public StatList CombineStats(int[] otherStats)
        {
            int[] newStats = new int[_statList.Length];

            for (int i = 0; i < _statList.Length; i++)
            {
                newStats[i] = _statList[i] + otherStats[i];
            }

            return new StatList(newStats);
        }

        // Returns 0 if stat did not increase (like if it was already maxed); otherwise returns the new value
        public int ModifyStat(int StatIndex, int newValue)
        {
            _statList[StatIndex] += newValue;
            return _statList[StatIndex];
        }

        // Stat Mods
        public int ModifyHP(int newValue)
        {
            return ModifyStat(INDEX_HP, newValue);
        }

        public int ModifyMP(int newValue)
        {
            return ModifyStat(INDEX_MP, newValue);
        }

        public int ModifyStrength(int newValue)
        {
            return ModifyStat(INDEX_STR, newValue);
        }

        public int ModifyIntelligence(int newValue)
        {
            return ModifyStat(INDEX_INT, newValue);
        }

        public int ModifyDexterity(int newValue)
        {
            return ModifyStat(INDEX_DEX, newValue);
        }

        public int ModifyAgility(int newValue)
        {
            return ModifyStat(INDEX_AGI, newValue);
        }

        public int ModifyPerception(int newValue)
        {
            return ModifyStat(INDEX_PER, newValue);
        }

        public int ModifyReflexes(int newValue)
        {
            return ModifyStat(INDEX_REF, newValue);
        }

        public int ModifyCharisma(int newValue)
        {
            return ModifyStat(INDEX_CHA, newValue);
        }

        public int ModifyLuck(int newValue)
        {
            return ModifyStat(INDEX_LUK, newValue);
        }


        // Max Stat Mods
        public int ModifyMaxStat(int StatIndex, int newValue)
        {
            _maxStatList[StatIndex] += newValue;
            return _maxStatList[StatIndex];
        }

        public int ModifyMaxHP(int newValue)
        {
            return ModifyMaxStat(INDEX_HP, newValue);
        }

        public int ModifyMaxMP(int newValue)
        {
            return ModifyMaxStat(INDEX_MP, newValue);
        }

        public int ModifyMaxStrength(int newValue)
        {
            return ModifyMaxStat(INDEX_STR, newValue);
        }

        public int ModifyMaxIntelligence(int newValue)
        {
            return ModifyMaxStat(INDEX_INT, newValue);
        }

        public int ModifyMaxDexterity(int newValue)
        {
            return ModifyMaxStat(INDEX_DEX, newValue);
        }

        public int ModifyMaxAgility(int newValue)
        {
            return ModifyMaxStat(INDEX_AGI, newValue);
        }

        public int ModifyMaxPerception(int newValue)
        {
            return ModifyMaxStat(INDEX_PER, newValue);
        }

        public int ModifyMaxReflexes(int newValue)
        {
            return ModifyMaxStat(INDEX_REF, newValue);
        }

        public int ModifyMaxCharisma(int newValue)
        {
            return ModifyMaxStat(INDEX_CHA, newValue);
        }

        public int ModifyMaxLuck(int newValue)
        {
            return ModifyMaxStat(INDEX_LUK, newValue);
        }
    }
}
