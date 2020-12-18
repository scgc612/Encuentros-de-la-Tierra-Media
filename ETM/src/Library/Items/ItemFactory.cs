using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase 
    /// </summary>
    public class ItemFactory
    {
        public List<string> ListaItemsDesc = new List<string>();

        //Defense
        public IDefenseItem CreateArmor()
        {
            ListaItemsDesc.Add("Armor");
            return new Armor();
        }

        public IDefenseItem CreateHelmet()
        {
            ListaItemsDesc.Add("Helmet");
            return new Helmet();
        }
        public IDefenseItem CreateShield()
        {
            ListaItemsDesc.Add("Shield");
            return new Shield();
        }
        //gemas
        public IGem CreateBlueGem()
        {
            ListaItemsDesc.Add("BlueGem");
            return new BlueGem();
        }
        public IGem CreateSilverGem()
        {
            ListaItemsDesc.Add("SilverGem");
            return new SilverGem();
        }
        //ataque

        public IAttackItem CreateSword()
        {
            ListaItemsDesc.Add("Sword");
            return new Sword();
        }
         public IAttackItem CreateDarkSword()
        {
            ListaItemsDesc.Add("DarkSword");
            return new DarkSword();
        }

        //Health

        public IHealthItem CreateCureBox()
        {
            ListaItemsDesc.Add("CureBox");
            return new CureBox();
        }

        //Magic

        public IMagicItem CreateExcalibur()
        {
            ListaItemsDesc.Add("Excalibur");
            return new Excalibur();
        }

    }
}