using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase 
    /// </summary>
    public class CharFactory
    {
        public List<string> ListaNombresHeroes = new List<string>();
        public List<string> ListaNombresVillanos = new List<string>();

        //Heroes
        public Character CreateDwarf()
        {
            ListaNombresHeroes.Add("Enano");
            return new Dwarf("Enano", new Axe(), new Helmet(), new Shield());
        }
        public Character CreateElf()
        {
            ListaNombresHeroes.Add("Elfo");
            return new Elf("Elfo", new Bow(), new Armor(), new Helmet());
        }
        public Character CreateKnight()
        {
            ListaNombresHeroes.Add("Caballero");
            return new Knight("Caballero", new Sword(), new Armor(), new Shield());
        }
        public Character CreateWizard()
        {
            ListaNombresHeroes.Add("Gandalf");
            return new Wizard("Gandalf", new Staff(), new Shield(), new Armor(), new SpellsBook());
        }

        //Villanos

        public Character CreateDarkWizard()
        {
            ListaNombresVillanos.Add("Saruman");
            return new DarkWizard("Saruman", new Staff(), new Armor(), new SpellsBook());
        }
        public Character CreateDemonio()
        {
            ListaNombresVillanos.Add("Lanthos");
            return new Demonio("Lanthos", new Sword(), new Armor());
        }
        public Character CreateDragon()
        {
            ListaNombresVillanos.Add("Shiva");
            return new Dragon("Shiva", new Bow(), new Armor());
        }
        public Character CreateOrco()
        {
            ListaNombresVillanos.Add("Ugly");
            return new Orco("Ugly",new Axe(), new Helmet());
        }
    }
}