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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace seredes
{
    public partial class Form1 : Form
    {
        List<Persona> Listadati;
        string file = "dati.txt";


        bool trovato = false;
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
            string vnome = name.Text;        
            string vcogn = Surname.Text;     
            string veta = Age.Text;          

            for (int i = 0; i < Listadati.Count; i++)
            {

                if (Listadati[i].Nome == vnome && Listadati[i].Cognome == vcogn && Listadati[i].Eta == veta)
                {
                    trovato = true;

                    break;
                }
            }

            if (trovato)
            {
                nnome.Text = vnome;
                ncogn.Text = vcogn;
                neta.Text = veta;
            }
            else
            {
                MessageBox.Show("Studente non trovato.");
            }
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
            string nomecanc = name.Text;
            string cogncanc = Surname.Text;
            string etacanc = Age.Text;
            bool trovato = false;

            for (int i = 0; i < Listadati.Count; i++)
            {
                if (Listadati[i].Nome == nomecanc && Listadati[i].Cognome == cogncanc && Listadati[i].Eta == etacanc)
                {
                    Listadati.RemoveAt(i);
                    Visudati.Items.RemoveAt(i);
                    trovato = true;
                    break;
                }
            }

            if (trovato)
            {
                MessageBox.Show("Studente cancellato con successo!");
            }
            else
            {
                MessageBox.Show("Studente non trovato.");
            }


        }

        private void Update_Click(object sender, EventArgs e)
        {
            string nname = nnome.Text;
            string ncognome = ncogn.Text;
            string nEta = neta.Text;
            for (int i = 0; i < Listadati.Count; i++)
            {
                if (trovato == true)
                {

                    Listadati[i].Nome = nname;
                    Listadati[i].Cognome = ncognome;
                    Listadati[i].Eta = nEta;

                    Visudati.Items[i] = Listadati[i].ToString();
                        MessageBox.Show("Studente cancellato con successo!");
                    break;
                }
            }
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