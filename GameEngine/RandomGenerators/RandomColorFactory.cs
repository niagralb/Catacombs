using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Constants;

namespace GameEngine.RandomGenerators
{
    static class RandomColorFactory
    {

        // Possible skin color values
        private static readonly string[] SKIN_HUMAN_COLORS = { "light", "olive", "dark", "white", "black", "brown", "pale", "bronze", "tan"};

        // Possible hair color values
        private static readonly string[] HAIR_HUMAN_COLORS = { "jet black", "black", "raven-colored", "auburn", "chestnut", "walnut-colored", "orange", "scarlet", "red", "blonde", "golden", "platinum blonde", "strawberry blonde" };
        // other colors: http://writersinthestormblog.com/2014/07/writing-about-hair-the-thick-and-thin-of-descriptions/
        // https://sites.google.com/site/choosewriting/tips-and-tricks-on-writing/desribing-eye-color-hair-color-and-hair-type

        private static Random rng = new Random();

        public static string GetRandomSkinColor(int type)
        {
            switch (type)
            {
                case TypeConstants.STYLE_HUMAN:
                    return SKIN_HUMAN_COLORS[rng.Next(SKIN_HUMAN_COLORS.Length)];
                 
            }

            return null;
        }

        public static string GetRandomHairColor(int type)
        {
            switch (type)
            {
                case TypeConstants.STYLE_HUMAN:
                    return HAIR_HUMAN_COLORS[rng.Next(SKIN_HUMAN_COLORS.Length)];

            }

            return null;
        }

        
    }
}
