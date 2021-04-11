using System;

namespace WizardClassGeneratorE07
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        private int spellSlots;
        private double experience;

        public static int Count;

        //initiliazes values it's called the construct
        public Wizard(string initialName, string initialFavouriteSpell)
        {
            name = initialName;
            favouriteSpell = initialFavouriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void castSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine("{0} casts {1}", name, favouriteSpell);
                spellSlots--;
                experience += 0.3; 
            }
            else
            {
                Console.WriteLine("{0} is out of spellslots", name);
            }
        }
        public void medidate()
        {
            Console.WriteLine("{0} beins to meditate to regain spell slots", name);
            spellSlots = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Darkguy", "Darkmagic");

            wizard01.castSpell();

            Wizard wizard02 = new Wizard("Lightman", "Lightmagic");

            wizard02.castSpell();

            Console.WriteLine(Wizard.Count);
        }
    }
}
