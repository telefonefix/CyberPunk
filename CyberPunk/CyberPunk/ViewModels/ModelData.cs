using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberPunk.ViewModels
{
    public enum StateAction
    {
        failure = 1,
        sucess = 0,
        normal = 2
    }
    public class ModelData : IDiceData
    {
        public int Dice10 { get; set; }

        public int Dice20 { get; set; }

        public int GetResult(int feature, int skill, int dice)
        {
            int baseDice = 10;
            int resultDice = 0;
            int dice;
            bool failure = false;

            if (skill >= 12)
            {
                baseDice = 20;
            }

            int tmp = 0;

            Random rnd = new Random(baseDice);

            do
            {
                dice = rnd.Next();

                // Relance le dé
                switch (dice)
                {
                    case 1:
                        if (!failure)
                        {
                            failure = true;
                            // TODO : Gerer la relance avec un 0
                            tmp -= rnd.Next();
                            
                        }
                        else
                        {
                            tmp += 1;
                        }
                        break;

                    case 0:
                        baseDice = 0 ? tmp += 10 : tmp += 20;
                        break;
                    default:
                        tmp += dice;
                        break;

                }


            }
            while (dice == baseDice);

            resultDice += tmp;
            return resultDice;
        }
        private int GetStatut(bool Failure, Random random)
        {
            int dice;
            if (failure)
            {
                dice = random.Next();
                if (dice == 0)
                {

                }
            }
        }
    }
}