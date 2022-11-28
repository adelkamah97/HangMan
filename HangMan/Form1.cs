using System.Text;
using System.Collections.Generic;
using System.IO;
using AsciiArt;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace HangMan
{
    public partial class Form1 : Form
    {
        const int NB_VIES = 6;
        int viesRestantes = NB_VIES;
        string motd = ChargerLesMots();
        public List<char> lettresDevinees = new List<char>() ;
        public List<char> lettresExclues = new List<char>() ;
        public List<string> ImagesLocation = new List<String>()
        {
            "Ressources/hangman0.png",
            "Ressources/hangman1.png",
            "Ressources/hangman2.png",
            "Ressources/hangman3.png",
            "Ressources/hangman4.png",
            "Ressources/hangman5.png",
            "Ressources/hangman6.png",

        };

        public Form1()
        {
            InitializeComponent();
            rmlives.Text = viesRestantes.ToString();
            lettresnon.Text=String.Join(',',lettresExclues);
            AfficherMot(motd, lettresDevinees, word);
            
            pondu.Image = Image.FromFile(ImagesLocation[0]);
            
            

        }

        static string ChargerLesMots()
        {
            var lettres = new List<char>();
            string motd = "";
            var mots = File.ReadAllLines("mots.txt");
            if ((mots == null) || (mots.Length == 0))
            {
                MessageBox.Show("La liste de mots est vide");
            }
            else
            {
                Random r = new Random();
                int b = r.Next(mots.Length);
                string mot = mots[b].Trim().ToUpper();
                motd = mot;

            }
            return motd;
        }

        static bool ToutesLettresDevinees(string mot, List<char> lettres)
        {
            // true -> toutes les lettres ont été trouvées -> gagné
            // false 
            // ""
            foreach (var lettre in lettres)
            {
                mot = mot.Replace(lettre.ToString(), "");
            }

            if (mot.Length == 0)
            {
                return true;
            }
            return false;
        }

        static void AfficherMot(string mot, List<char> lettres, TextBox textBox)
        {
            string mott = "";
            for (int i = 0; i < mot.Length; i++)
            {
                char c = mot[i];
                if (lettres.Contains(c))
                {
                    c = c;
                }
                else
                {
                    c = '_';
                }

                mott += c + " ";
            }
            textBox.Text = mott;
        }

        static string DemanderUneLettre(string s)
        {                        
                string reponse = s;
                if (reponse.Length == 1)
                {
                    reponse = reponse.ToUpper();
                    return reponse;

                }
                else
                {
                    MessageBox.Show("ERREUR : Vous devez rentrer une lettre");
                    return null;
                }
                        
        }
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        private void test_Click(object sender, EventArgs e)
        {
            if (viesRestantes > 1)
            {
                if (ltr.Text.Length != 1 || !IsAllLetters(ltr.Text))
                {
                    MessageBox.Show("you Have to write a Lettre");
                    ltr.Clear();
                }
                else
                {
                    string q = DemanderUneLettre(ltr.Text);
                    if (motd.Contains(q))
                    {
                        if (!lettresDevinees.Contains(q[0]))
                        {
                            lettresDevinees.Add(q[0]);
                            MessageBox.Show("Good : the lettre '" + q + "' existe in the word ");
                        }
                        else
                        {
                            MessageBox.Show("you have already find the lettre '" + q + "' Please try another one");
                        }
                    }
                    else
                    {
                        if (!lettresExclues.Contains(q[0]))
                        {
                            viesRestantes--;
                            lettresExclues.Add(q[0]);
                            MessageBox.Show("Sorry : the lettre '" + q + "' does not existe in the word ");
                            int c = NB_VIES - viesRestantes;
                            pondu.Image = Image.FromFile(ImagesLocation[c]);
                        }
                        else
                        {
                            MessageBox.Show("you tried with the lettre '" + q + "' and it doesn't work!! Please try another one");

                        }
                    }
                    if (ToutesLettresDevinees(motd, lettresDevinees))
                    {
                        MessageBox.Show("gagne");
                    }

                    rmlives.Text = viesRestantes.ToString();
                    lettresnon.Text = String.Join(',', lettresExclues);
                    AfficherMot(motd, lettresDevinees, word);
                    ltr.Clear();
                }
            }
            else
            {

                MessageBox.Show(" You Lost !! the word is " + motd);
                test.Enabled = false;
                ltr.Enabled = false;
                word.Text = motd;
                rmlives.Text = "0";
                pondu.Image = Image.FromFile(ImagesLocation[6]);
                ltr.Clear();
            }

        }

        private void replay_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}