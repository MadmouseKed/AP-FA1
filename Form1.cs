using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FA1
{
    using MijnRekenen;
    public partial class FormBattleSim : Form
    {
        /*public Combatant c1 = new Combatant();
        public Combatant c2 = new Combatant();*/
        Combatant c1;
        Combatant c2;

        public FormBattleSim()
        {
            InitializeComponent();
        }
        public class Combatant
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

            public void setHP(int hp)
            {
                HP = hp;
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

            public string toString()
            {
                string text;
                text = "Naam: " + naam + " \r\n"
                    + "Ac: " + AC + " \r\n"
                    + "Hp: " + HP + " \r\n";
                return text;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void c1ACBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void c1SetButton_Click(object sender, EventArgs e) 
        {
            string nm = combatant1Name.Text;
            int ac = Int32.Parse(c1ACBox.Text);
            int hp = Int32.Parse(c1HpBox.Text);
            int act = Int32.Parse(c1ActionsBox.Text);
            int dmgdice = Int32.Parse(c1DiceBox.Text);
            int dmgmod = Int32.Parse(c1DmgModBox.Text);
            int hitmod = Int32.Parse(c1HitModBox.Text);
            ResultBox.Text = "Hallo \r\n";
            Combatant c1 = new Combatant(nm, ac, hp, act, dmgdice, dmgmod, hitmod);
            ResultBox.Text += c1.toString();
            /*Combatant createCombatant1(nm,ac,hp,act,dmgdice,dmgmod,hitmod);*/
            /*createCombatant1(nm, ac, hp, act, dmgdice, dmgmod, hitmod);*/
        }

        private void c2SetButton_Click(object sender, EventArgs e) 
        { 
            string nm = combatant2Name.Text;
            int ac = Int32.Parse(c2ACBox.Text);
            int hp = Int32.Parse(c2HpBox.Text);
            int act = Int32.Parse(c2ActionsBox.Text);
            int dmgdice = Int32.Parse(c2DiceBox.Text);
            int dmgmod = Int32.Parse(c2DmgBox.Text);
            int hitmod = Int32.Parse(c2HitBox.Text);
            ResultBox.Text = "Hallo2 \r\n";
            Combatant c2 = new Combatant(nm, ac, hp, act, dmgdice, dmgmod, hitmod);
            ResultBox.Text += c2.toString();
        }

        private void c1DiceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void combatant1Name_TextChanged(object sender, EventArgs e)
        {

        }

        public void ResolveCombat()
        {
            ResultBox.Text = "";
            string c1HitText;
            string c2HitText;
            int c1Hp = c1.getHP();
            int c2Hp = c2.getHP();
            int d20 = 20;
            int c1HitRoll = Rekenen.RollDice(d20) + c1.getHitModifier();
            int c2HitRoll = Rekenen.RollDice(d20) + c2.getHitModifier();
            bool c1HitCheck = Rekenen.HitCheck(c2.getAC(), c1HitRoll);
            bool c2HitCheck = Rekenen.HitCheck(c1.getAC(), c2HitRoll);

            if (c1HitCheck)
            {
                c1HitText = "And it hit!";
            }
            else
            {
                c1HitText = "And it misses!";
            }

            if (c2HitCheck)
            {
                c2HitText = "And it hit!";
            }
            else
            {
                c2HitText = "And it misses!";
            }

            ResultBox.Text += c1.getNaam() + " rolled " + c1HitRoll + " \r\n"
                + c1HitText + " \r\n"
                + c2.getNaam() + " rolled " + c1HitRoll + " \r\n"
                + c2HitText + " \r\n";

            /*if ((c1Hp <= 0) & (c2Hp <= 0))
            {

            }*/

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            ResolveCombat();
        }

        private void NextTurn_Click(object sender, EventArgs e)
        {
            ResolveCombat();
        }


    }
}