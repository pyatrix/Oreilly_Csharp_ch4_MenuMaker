using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    class MeunMaker
    {
        public Random Randomizer;

        string[] Meats = { "Meats1", "Meats2", "Meats3", "Meats4", "Meats5" };
        string[] Condiments = { "Condiments1", "Condiments2", "Condiments3" };
        string[] Breads = { "Breads1", "Breads2", "Breads3", "Breads4" };

        public string GetMeunItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}