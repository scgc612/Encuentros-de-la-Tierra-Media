using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que implementa interfaz para crear Escenario 
    /// </summary>
    public class CrearEscenarioFromArchivo:ICrearEscenario
    {

        public Escenario Escenario {get;set;}

        public string FileDir {get;}

        public CrearEscenarioFromArchivo(string fileDir)
        {
            this.FileDir=fileDir;
        }
        public Escenario CrearEscenario()
        {
            
            this.Escenario = new Escenario();
            string[] listaComandos = System.IO.File.ReadAllLines($@"{this.FileDir}");
            foreach (string comando in listaComandos)
            {
                InterpretarComando(comando);
            }
            return Escenario;
        }
        public void InterpretarComando(string comando)
        {
            
            switch (comando)
            {
                //heroes
                case "crearEnano":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateDwarf());
                    break;
                case "crearElfo":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateElf());
                    break;
                case "crearCaballero":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateKnight());
                    break;
                case "crearMago":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateWizard());
                    break;
                //villanos
                case "crearMagoOscuro":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateDarkWizard());
                    break;
                case "crearDemonio":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateDemonio());
                    break;
                case "crearDragon":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateDragon());
                    break;
                case "crearOrco":
                    Escenario.AddCharacter(Escenario.CharFactory.CreateOrco());
                    break;
                //itemDefensa
                case "crearAmor":
                    Escenario.AddItem(Escenario.ItemFactory.CreateArmor());
                    break;
                case "crearHelmet":
                    Escenario.AddItem(Escenario.ItemFactory.CreateHelmet());
                    break;
                case "crearShield":
                    Escenario.AddItem(Escenario.ItemFactory.CreateShield());
                    break;
                //gema
                case "crearSilverGem":
                    Escenario.AddItem(Escenario.ItemFactory.CreateSilverGem());
                    break;
                //atack
                case "crearDarkSword":
                    Escenario.AddItem(Escenario.ItemFactory.CreateDarkSword());
                    break;
                //health
                case "crearCureBox":
                    Escenario.AddItem(Escenario.ItemFactory.CreateCureBox());
                    break;
                //magic
                case "crearExcalibur":
                    Escenario.AddItem(Escenario.ItemFactory.CreateExcalibur());
                    break;

                //preparación para intercambio
                case "interEnano":
                    Escenario.AddPersonajeForIntercambio("Enano");
                    break;
                case "interElfo":
                    Escenario.AddPersonajeForIntercambio("Elfo");
                    break;
                case "interCaballero":
                    Escenario.AddPersonajeForIntercambio("Caballero");
                    break;
                case "interMago":
                    Escenario.AddPersonajeForIntercambio("Gandalf");
                    break;
                case "interMagoOscuro":
                    Escenario.AddPersonajeForIntercambio("Saruman");
                    break;
                case "interDemonio":
                    Escenario.AddPersonajeForIntercambio("Lanthos");
                    break;
                case "interDragon":
                    Escenario.AddPersonajeForIntercambio("Shiva");
                    break;
                case "interOrco":
                    Escenario.AddPersonajeForIntercambio("Ugly");
                    break; 
                //itemforintercambio
                case "interDarkSword":
                    Escenario.AddItemForIntercambio("DarkSword");
                    break;
                case "interHelmet":
                    Escenario.AddItemForIntercambio("Helmet");
                    break;
                case "interSilverGema":
                    Escenario.AddItemForIntercambio("SilverGem");
                    break;        

                //intercambio
                case "intercambiar":
                    Escenario.CrearEncuentroIntercambio();
                    break;  
                

                //preparación para combate 
                case "combatEnano":
                    Escenario.AddHeroeForCombat("Enano");
                    break;
                case "combatElfo":
                    Escenario.AddHeroeForCombat("Elfo");
                    break;
                case "combatCaballero":
                    Escenario.AddHeroeForCombat("Caballero");
                    break;
                case "combatMago":
                    Escenario.AddHeroeForCombat("Gandalf");
                    break;
                case "combatMagoOscuro":
                    Escenario.AddVillanoForCombat("Saruman");
                    break;
                case "combatDemonio":
                    Escenario.AddVillanoForCombat("Lanthos");
                    break;
                case "combatDragon":
                    Escenario.AddVillanoForCombat("Shiva");
                    break;
                case "combatOrco":
                    Escenario.AddVillanoForCombat("Ugly");
                    break;  
                
                //combatir
                case "combatir":
                    Escenario.CrearEncuentroCombate();
                    break;   
                case "finalizarEscenario":
                    Console.WriteLine(Escenario.FinalizarEscenario());
                    break;                           
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}