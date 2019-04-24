using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberPunk.ViewModels
{

    private const int defaultDice = 10;
    private const int expertDice = 20;
    private const int fightDice = 6;

    public class ModelData : IDiceData
    {
        private Random _random;
        public int Dice10 { get; set; }

        public int Dice20 { get; set; }

        public int GetResult(int feature, int skill, int baseDice = defaultDice)
        {
            int result = 0;
            int d;
            bool failure = false;
            bool first = true;
            bool replay = false;

            // Une compétences superieure à 12 fait lancer un dé de 20.
            if (skill >= 12)
            {
                baseDice = expertDice;
            }

            int tmp = 0;
            _random = new Random(baseDice);

            do
            {
                d = rnd.Next();

                // Relance le dé
                switch (d)
                {
                    case 1:
                        if (first)
                        {
                            failure = true;
                            replay = true;
                        }
                        else
                        {
                            tmp += 1;
                            replay = false;
                        }
                        break;

                    case 0:
                        tmp += baseDice;
                        replay = true;
                        break;
                    default:
                        tmp += d;
                        replay = false;
                        break;

                }
                first = false;
            }
            while (replay);
            result = feature + skill;
            failure = true ? result -= tmp : result += tmp;
            return result;
        }

        public bool UnderFeature(string feature = "CH")
        {
            // Pour tester valeur en dure
            int value = 9;
            _random = new Random(defaultDice);
            // TODO : Recuperer la valeur de la compétence
            int d = _random.Next();
            return (d <= value);
        }
        public int GetHole()
        {
            // Lancement d'un dé de 100 (un dé de 10 dizaine + un dé unitaire)
            _random = new Random(defaultDice);

            return _random.Next(0, 100);

        }



        public void SetPointToSkill(string skillName, int newPoint)
        {
            using (CyberPunkEntities cyber = new CyberPunkEntities())
            {
                //int skillPoint = cyber.;

            }

            int skillYet = 15;
            int skillAttribute = 7;
            int multi;

            if (skillPoint >= 12)
            {
                multi = skillAttribute * 20;
            }
            else
            {
                multi = skillAttribute * 10;            }


        }
    }
}