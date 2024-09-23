using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace seredes
{
    public partial class Form1 : Form
    {
        List<Persona> Listadati;
        string file = "dati.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] datil = new string[3];
            Listadati = new List<Persona>();
            if (File.Exists("./dati.txt") == false)
            {
                StreamWriter sw = new StreamWriter(file);
            }
            else
            {
                StreamReader sr = new StreamReader(file);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    datil = line.Split(',');
                    Persona pers = new Persona(datil[0], datil[1], datil[2]); 
                    Listadati.Add(pers);
                    Visudati.Items.Add(pers.ToString());
                }
                sr.Close();
            }
        }
        private void Form1_FormClosed(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < Listadati.Count; i++)
            {
                sw.WriteLine(Listadati[i].Serializza());
            }
            sw.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            Persona dati = new Persona(name.Text, Surname.Text, Age.Text);
            Listadati.Add(dati);
            Visudati.Items.Add($"Name: {dati.Nome} Surname: {dati.Cognome} Age: {dati.Eta}");
            name.Clear();
            Surname.Clear();
            Age.Clear();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            /*Lettura da un file (con controllo esistenza)
            StreamReader sr = new StreamReader(file);
             string riga;
             do
             {
                 riga = file.ReadLine();
                 if (riga != null)
                 {
                    Visudati.Clear();
                     for (int i = 0; i < dim; i++)
                     {
                        Visudati.Items.Add($"");
                     }
                 }
             }
             while (!File.EndOfStream);
             File.Close();*/
         }

         private void Save_Click(object sender, EventArgs e)
         {
             StreamWriter sw = new StreamWriter(file);
             for (int i = 0; i < Listadati.Count; i++)
             {
                 sw.WriteLine(Listadati[i].Serializza());
             }
             sw.Close();
             //Visudati.Items.Clear();
         }

         private void Delate_Click(object sender, EventArgs e)
         {
            int sel = Visudati.SelectedIndex;
            Listadati.RemoveAt(sel);
         }
     }
     class Persona
     {
         public string Nome { get; set; }
         public string Cognome { get; set; }
         public string Eta { get; set; }
         public Persona(string nome, string cognome, string eta)
         {
             Nome = nome;
             Cognome = cognome;
             Eta = eta;
         }

         public override string ToString()
         {
             return $"Name: {Nome}, Surname: {Cognome} Age: {Eta}";
         }
         public string Serializza()
         {
             return $"{Nome},{Cognome},{Eta}";
         }
         /*public static Persona Deserializza(string linea)
         {
             string[] campi = linea.Split(',');
             if (campi.Length == 2 && int.TryParse(campi[1], out int eta))
             {
                 return new Persona(campi[0], eta);
             }
             return null;
         }*/
        }
    }
