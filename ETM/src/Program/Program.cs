using System;
using System.Collections.Generic;
using System.Linq;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearEscenarioFromArchivo creadorEscenario= new CrearEscenarioFromArchivo("../../escenario1.txt");
            Escenario escenario1 = creadorEscenario.CrearEscenario();
        }
    }
}

            /*  //defenseItems
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


            // Console.WriteLine($"lanthos has ❤️ {demonio.Health}");
            
            // Console.WriteLine($"Gandalf attacks Lanthos with ⚔️ {wizard.AttackValue}");

            // demonio.ReceiveAttack(wizard.AttackValue);

            // Console.WriteLine($"Lanthos has ❤️ {demonio.Health}");

            // demonio.Cure();

            // Console.WriteLine($"Lanthos has ❤️ {demonio.Health}");

            // knight.VictoryPoints+=1;

            // Console.WriteLine($"Caballero has ! {knight.VictoryPoints} VP");
            // Console.WriteLine();

            // Console.WriteLine(knight.AddItem(bow));


            // Console.WriteLine();
            // Console.WriteLine(knight.UseAttackItem(bow));
      
            // Console.WriteLine($"Caballero attacks Lanthos with ⚔️ {knight.AttackValue}");

            // Console.WriteLine($"Lanthos has ❤️ {demonio.Health}");

            // demonio.ReceiveAttack(knight.AttackValue);

            // Console.WriteLine($"Lanthos has ❤️ {demonio.Health}"); 

            // Console.WriteLine(knight.ShowItems());

            wizard.AddItem(helmet);
            wizard.AddItem(staff);
            elf.AddItem(shield);
            wizard.UseDefenseItem(helmet);
            // Console.WriteLine(wizard.ShowItems());

            darkWizard.AddItem(poison);
            Console.WriteLine(darkWizard.UseHealthItem(poison));
            // Console.WriteLine(darkWizard.ShowItems());

            //Test EncuentroCombate y Encuentro Intercambio
            List<Villano> villanos = new List<Villano>();
            villanos.Add(darkWizard);
            villanos.Add(demonio);
            villanos.Add(dragon);
            villanos.Add(orco);

            List<Heroe> heroes = new List<Heroe>();
            heroes.Add(dwarf);
            heroes.Add(elf);
            heroes.Add(knight);
            heroes.Add(wizard);


            Escenario escenario1 = new Escenario();
            escenario1.AddCharacter(darkWizard);
            escenario1.AddCharacter(demonio);
            escenario1.AddCharacter(dragon);
            escenario1.AddCharacter(orco);
            escenario1.AddCharacter(dwarf);
            escenario1.AddCharacter(elf);
            escenario1.AddCharacter(knight);
            escenario1.AddCharacter(wizard);

            escenario1.CrearEncuentroCombate(heroes, villanos); */



            //EncuentroIntercambio
            // EncuentroIntercambio encuentroIntercambio = new EncuentroIntercambio(wizard, elf);
            // encuentroIntercambio.Intercambiar(staff);
            // encuentroIntercambio.Intercambiar(sword);

            // Console.WriteLine(encuentroIntercambio.ShowResults());

            
            //EncuentroCombate
            // EncuentroCombate encuentroCombate1 = new EncuentroCombate(heroes, villanos);
            // encuentroCombate1.Fight();
            // Console.WriteLine(encuentroCombate1.ShowResults());








            

            

            
 
