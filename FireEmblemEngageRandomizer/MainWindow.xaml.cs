using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FireEmblemEngageRandomizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Run population of characters and their classes
            Cl c = new();
            c.AddValues();
            Chars ch = new Chars();
            foreach (KeyValuePair<string, string> x in Characters.d)
            {
                string key = x.Key.ToString();
                CharacterListView.Items.Add(key);
            }
            foreach (KeyValuePair<string, string> x in Characters.d)
            {
                string value = x.Value.ToString();
                StartingClassListView.Items.Add(value);
            }
            
        
        }
        //On button click, run the randomizer, send the new class to the respective list. Every time button is clicked, clear the results and randomize again
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Randomizer r = new();
            r.Randomize();

            if(RandomizedClassListView.Items.Count >= Characters.d.Count) 
            { 
                RandomizedClassListView.Items.Clear();
                foreach (string value in r.NewClasses)
                {
                    RandomizedClassListView.Items.Add(value);
                }
            }
            else 
            {
                foreach (string value in r.NewClasses)
                {
                    RandomizedClassListView.Items.Add(value);
                }
            }
            
        }
    }

    //Populate public dictionary of all classes in the game with a unique ID
    public class Cl
    {
        public static Dictionary<string, string> ClassDict = new Dictionary<string, string>();
        public void AddValues()
        {
            ClassDict.Add("Dragon Child", "1");
            ClassDict.Add("Divine Dragon", "2");
            ClassDict.Add("Noble (Alfred)", "3");
            ClassDict.Add("Noble (Celine)", "4");
            ClassDict.Add("Avenir", "5");
            ClassDict.Add("Vidame", "6");
            ClassDict.Add("Lord (Diamant)", "7");
            ClassDict.Add("Lord (Alcryst)", "8");
            ClassDict.Add("Successeur", "9");
            ClassDict.Add("Tireur d`elite", "10");
            ClassDict.Add("Wing Tamer", "11");
            ClassDict.Add("Lindwurm", "12");
            ClassDict.Add("Sleipnir Rider", "13");
            ClassDict.Add("Sentinel (Timerra)", "14");
            ClassDict.Add("Sentinel (Fogado)", "15");
            ClassDict.Add("Picket", "16");
            ClassDict.Add("Cupido", "17");
            ClassDict.Add("Dancer", "18");
            ClassDict.Add("Fell Child", "19");
            ClassDict.Add("Lance Cavalier", "20");
            ClassDict.Add("Sword Cavalier", "21");
            ClassDict.Add("Axe Cavalier", "22");
            ClassDict.Add("Paladin (Lance)", "23");
            ClassDict.Add("Paladin (Sword)", "24");
            ClassDict.Add("Paladin (Axe)", "25");
            ClassDict.Add("Wolf Knight (Sword)", "26");
            ClassDict.Add("Wolf Knight (Axe)", "27");
            ClassDict.Add("Wolf Knight (Lance)", "28");
            ClassDict.Add("Martial Monk", "29");
            ClassDict.Add("Martial Master", "30");
            ClassDict.Add("High Priest", "31");
            ClassDict.Add("Mage", "32");
            ClassDict.Add("Sage", "33");
            ClassDict.Add("Mage Knight (Sword)", "34");
            ClassDict.Add("Mage Knight (Lance)", "35");
            ClassDict.Add("Mage Knight (Axe)", "35");
            ClassDict.Add("Sword Fighter", "36");
            ClassDict.Add("Lance Fighter", "37");
            ClassDict.Add("Axe Fighter", "38");
            ClassDict.Add("Hero (Lance)", "39");
            ClassDict.Add("Hero (Axe)", "40");
            ClassDict.Add("Swordmaster", "41");
            ClassDict.Add("Halberdier", "42");
            ClassDict.Add("Royal Knight", "43");
            ClassDict.Add("Beserker", "44");
            ClassDict.Add("Warrior", "45");
            ClassDict.Add("Archer", "46");
            ClassDict.Add("Sniper", "47");
            ClassDict.Add("Bow Knight (Sword)", "48");
            ClassDict.Add("Bow Knight (Lance)", "49");
            ClassDict.Add("Lance Flier", "50");
            ClassDict.Add("Sword Flier", "51");
            ClassDict.Add("Axe Flier", "52");
            ClassDict.Add("Griffin Knight (Lance)", "53");
            ClassDict.Add("Griffin Knight (Sword)", "54");
            ClassDict.Add("Griffin Knight (Axe)", "55");
            ClassDict.Add("Wyvern Knight (Lance, Axe)", "56");
            ClassDict.Add("Wyvern Knight (Sword, Lance)", "57");
            ClassDict.Add("Sword Armor", "58");
            ClassDict.Add("Lance Armor", "59");
            ClassDict.Add("Axe Armor", "60");
            ClassDict.Add("General (Sword)", "61");
            ClassDict.Add("General (Lance)", "62");
            ClassDict.Add("General (Axe)", "63");
            ClassDict.Add("Great Knight (Sword, Axe)", "64");
            ClassDict.Add("Great Knight (Sword, Lance)", "65");
            ClassDict.Add("Great Knight (Lance, Axe)", "66");
            ClassDict.Add("Thief", "67");
        }
    }

    //Creates a dictionary and maps specific strings to those for use in other classes
    public class Chars : Dictionary<string, string>
    {

        public new void Add(string Character, string Class)
        {
            base.Add(Character, Class);
        }

        public new string this[string Character]
        {
            get { return base[Character]; }
            set { base[Character] = value; }
        }

    }

    public class Characters
    {
        //Populates character dictionary with character name and starting class
        public static Chars d = new Chars
        {
            { "Alear", "Dragon Child" },
            { "Vander", "Paladin(Lance)" },
            { "Clanne", "Mage"},
            { "Framme", "Martial Monk"},
            { "Alfred", "Noble(Alfred)" },
            { "Boucheron", "Axe Fighter" },
            { "Etie", "Archer" },
            { "Celine", "Noble(Celine)" },
            { "Louis", "Lance Armor" },
            { "Chloe", "Lance Flier"},
            { "Jean", "Martial Monk"},
            { "Alcryst", "Lord(Alcryst)"},
            { "Lapis", "Sword Fighter"},
            { "Citrinne", "Mage"},
            { "Diamant", "Lord(Diamant)"},
            { "Jade", "Axe Armor" },
            { "Saphir", "Warrior"},
            { "Anna", "Axe Fighter"},
            { "Ivy", "Wing Tamer"},
            { "Zelkov", "Theif"},
            { "Kagetsu", "Swordmaster"},
            { "Hortensia", "Wing Tamer"},
            { "Rosado", "Wyvern Knight(Lance, Axe)"},
            { "Goldmary", "Hero(Lance"},
            { "Lindon", "Sage"},
            { "Fogado", "Sentinel(Fogado)"},
            { "Pandreo", "High Priest" },
            { "Bunet", "Great Knight(Sword, Lance)"},
            { "Timerra", "Sentinel(Timerra)"},
            { "Merrin", "Wolf Knight(Sword)"},
            { "Panette", "Beserker"},
            { "Seadall", "Dancer"},
            { "Yunaka", "Thief"},
            { "Veyle", "Fell Child"},
            { "Mauvier", "Royal Knight"},
        };

        
    }

    public class Randomizer : Cl
    {
        //List to save the new classes and add them to respective listview in GUI
        public List<string> NewClasses = new List<string>();
        public void Randomize()
        {
            //For each character/starting class pair, randomize the class to a new one from the dictionary of classes
            foreach (KeyValuePair<string, string> x in Characters.d)
            {

                //Initiate while loop within for each so that way we ensure the exclusive classes only get assigned to the specfic characters that they are exclusive to

                bool picking = true;
                while (picking)
                {
                    var rand = new Random();
                    string NewClassID = rand.Next(1, Cl.ClassDict.Count).ToString();
                    string NewClassName = Cl.ClassDict.FirstOrDefault(x => x.Value == NewClassID).Key.ToString();
                    string changer = x.Key.ToString();
                    changer = NewClassName;

                    if (changer == "Dragon Child" && !Characters.d.Equals("Alear") ||
                        changer == "Divine Dragon" && !Characters.d.Equals("Alear") ||
                        changer == "Noble (Alfred)" && !Characters.d.Equals("Alfred") ||
                        changer == "Noble (Celine)" && !Characters.d.Equals("Celine") ||
                        changer == "Avenir" && !Characters.d.Equals("Alfred") ||
                        changer == "Vidame" && !Characters.d.Equals("Celine") ||
                        changer == "Lord (Diamant)" && !Characters.d.Equals("Diamant") ||
                        changer == "Lord (Alcryst)" && !Characters.d.Equals("Alcryst") ||
                        changer == "Successeur" && !Characters.d.Equals("Diamant") ||
                        changer == "Tireur d`elite" && !Characters.d.Equals("Alear") ||
                        changer == "Wing Tamer" && !Characters.d.Equals("Ivy") ||
                        changer == "Wing Tamer" && !Characters.d.Equals("Hortensia") ||
                        changer == "Lindwurm" && !Characters.d.Equals("Ivy") ||
                        changer == "Sleipnir Rider" && !Characters.d.Equals("Hortensia") ||
                        changer == "Tireur d`elite" && !Characters.d.Equals("Alcryst") ||
                        changer == "Sentinel (Timerra)" && !Characters.d.Equals("Timerra") ||
                        changer == "Sentinel (Fogado)" && !Characters.d.Equals("Fogado") ||
                        changer == "Picket" && !Characters.d.Equals("Timerra") ||
                        changer == "Cupido" && !Characters.d.Equals("Fogado") ||
                        changer == "Dancer" && !Characters.d.Equals("Seadall") ||
                        changer == "Fell Child" && !Characters.d.Equals("Veyle")

                        )
                    {
                        picking = true;
                    }
                    else
                    {
                        NewClasses.Add(changer);

                        picking = false;
                    }
                }
            }
        }

    }
}





//1.Character and starting classes get printed to listview Character and Starting Class, respectively
//2. When randomize button is hit, run randomizer and print the list of new classes to Randomized Class list box

