using System;
using System.Collections.Generic;
using System.Text;

namespace MijnRekenen
{
    public static class Rekenen
    {

        public static int RollDice(int diceSize)
        {
            Random random = new Random();
            int roll = random.Next(1, diceSize);
            return roll;
        }

        public static bool HitCheck(int AC, int Dice)
        {
            if (Dice >= AC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalculateDamage(int diceSize, int damageModifier)
        {
            int damage = RollDice(diceSize) + damageModifier;
            return damage;
        }

        public static int Remaining(int start, int substraction)
        {
            int HPLeft = start - substraction;
            return HPLeft;
        }


    }
}
