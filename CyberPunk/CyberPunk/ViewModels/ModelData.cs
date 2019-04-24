using System;

namespace CyberPunk.ViewModels
{



    public class ModelData : IDiceData
    {
        private const int defaultDice = 10;
        private const int expertDice = 20;
        private const int fightDice = 6;

        private Random _random;
        public int Dice10 { get; set; }

        public int Dice20 { get; set; }

        public int GetResult(int feature, int skill)
        {
            int result = 0;
            int d;
            bool failure = false;
            bool first = true;
            bool replay = false;
            int baseDice = defaultDice;

            // Une compétences superieure à 12 fait lancer un dé de 20.
            if (skill >= 12)
            {
                baseDice = expertDice;
            }

            int tmp = 0;
            _random = new Random();

            do
            {
                d = _random.Next(0, baseDice);

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
            if (failure)
            {
                result -= tmp;
            }
            else
            {
                result += tmp;
            }

            return result;
        }

        public bool UnderFeature(out int result, string feature = "CH")
        {
            // Pour tester valeur en dure
            int value = 9;
            int dice;
            result = 0;
            _random = new Random();
            // TODO : Recuperer la valeur de la compétence
            do
            {
                dice = _random.Next(0, defaultDice);

                if (dice == 0) result += 10; else result += dice;

            } while (dice == 0);
            
            return (result <= value);
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