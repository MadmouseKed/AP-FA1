using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA1
{
    /*public class Combatant
    {
        private string naam;
        private int AC;
        private int HP;
        private int Actions;
        private int DamageDice;
        private int DamageModifier;
        private int HitModifier;

        public Combatant(string nm, int ac, int hp, int Act, int DmgDice, int DmgMod, int HitMod)
        {
            naam = nm;
            AC = ac;
            HP = hp;
            Actions = Act;
            DamageDice = DmgDice;
            DamageModifier = DmgMod;
            HitModifier = HitMod;
        }

        public string getNaam()
        {
            return naam;
        }

        public int getAC()
        {
            return AC;
        }

        public int getHP()
        {
            return HP;
        }

        public int getActions()
        {
            return Actions;
        }

        public int getDamageDice()
        {
            return DamageDice;
        }

        public int getDamageModifier()
        {
            return DamageModifier;
        }

        public int getHitModifier()
        {
            return HitModifier;
        }
    }*/

/*    public class RoundLogic
    {

    }*/

/*    public class HandleCombatants
    {
        public void createCombatant1(string nm, int ac, int hp, int act, int dmgdice, int dmgmod, int hitmod)
        {
            Combatant c1 = new Combatant(nm, ac, hp, act, dmgdice, dmgmod, hitmod);
        }

        public void createCombatant2(string nm, int ac, int hp, int act, int dmgdice, int dmgmod, int hitmod)
        {
            Combatant c2 = new Combatant(nm, ac, hp, act, dmgdice, dmgmod ,hitmod);
        }
    }*/
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBattleSim());
        }
    }
}
