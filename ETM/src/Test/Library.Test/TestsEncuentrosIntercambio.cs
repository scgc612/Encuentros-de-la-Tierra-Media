using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class TestsEncuentrosIntercambio
    {
        [SetUp]
        public void Setup()
        {
            Armor armor = new Armor();
            DefaultDefenseItem defaultDefenseItem = new DefaultDefenseItem();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();

            //attackItems
            Axe axe = new Axe();
            Bow bow = new Bow();
            DarkSword darkSword = new DarkSword();
            Sword sword = new Sword();
            DefaultAttackItem defaultAttackItem = new DefaultAttackItem();

            //healthItems
            Bandage bandage = new Bandage();
            CureBox cureBox= new CureBox();
            Poison poison = new Poison();

            //magicItems
            DefaultMagicItem defaultMagicItem = new DefaultMagicItem();
            Excalibur excalibur = new Excalibur();
            SpellsBook spellsBook = new SpellsBook();
            Spell spell1 = new Spell();
            Spell spell2 = new Spell();

            Staff staff = new Staff();


            //heroes
            Dwarf dwarf = new Dwarf("Enano", axe, helmet, shield);
            Elf elf = new Elf("Elfo", bow, armor, helmet);
            Knight knight = new Knight("Caballero", sword, armor, shield);
            Wizard wizard = new Wizard("Gandalf", staff, shield, armor, spellsBook);

            //villanos
            DarkWizard darkWizard = new DarkWizard("Saruman", staff, armor, spellsBook);
            Demonio demonio = new Demonio("Lanthos", sword, armor);
            Dragon dragon = new Dragon("Shiva", bow, armor);
            Orco orco = new Orco("Ugly",axe, helmet);


        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}