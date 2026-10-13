namespace VerificadiRipasso
{
    public partial class Form1 : Form
    {
        List<string> listaParole = new List<string> ();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listaParoleCifrate = new List<string>();
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] arrayAlfabeto = alfabeto.ToCharArray();

            int l = 1;

            using (StreamReader sr = new StreamReader("FileParole.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                   
                    if (l % 2 == 0)
                    {
                        listaParole.Add(riga);
                    }

                    riga = sr.ReadLine();
                    l++;
                }
            }

            int a = 0;
            string parola = "";

            for (int i = 0; i < listaParole.Count; i++)
            {
                parola = "";
                char[] arrayParola = listaParole[i].ToCharArray();

                for(int k = 0; k < arrayParola.Length; k++)
                {
                    a = 0;

                    while (arrayParola[k] != arrayAlfabeto[a])
                    {
                        a++;
                    }

                    if (a > 2)
                    {
                        a = a - 3;
                    }
                    else
                    {
                        a = arrayAlfabeto.Length - (3 - a);
                    }

                    arrayParola[k] = arrayAlfabeto[a];
                }

                for(int j = 0; j <  arrayParola.Length; j++)
                {
                    parola = parola + arrayParola[j];
                }

                listBoxParole.Items.Add(parola);
                listaParoleCifrate.Add(parola);
            }

            using(StreamWriter sw = new StreamWriter("FileNuoveParole.txt"))
            {
                foreach(string s in listaParoleCifrate)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
