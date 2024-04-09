namespace _01_Bases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mots = { "Un", "tableau", "de", "mots" };
            List<string> listStr = new List<string>();
            listStr.AddRange(mots);
            listStr.Remove("tableau"); //retier le mot du tableau"
            //rechercher l'indice de ce même mot (il n'est plus présent donc on aura -1)
            int indiceMotTableau = listStr.IndexOf("tableau");

            try
            {
                textBox1.Text += listStr[indiceMotTableau];
            }catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Le mot recherché n'existe pas dans la liste.", "HERS",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }finally
            {
                MessageBox.Show("On a fini d'executer le code.", "HERS");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            object message = "Je débute le C#";
            int bloc = 2;
            System.Diagnostics.Debug.WriteLine("Numéro du bloc : " + bloc);
            System.Diagnostics.Debug.Assert(bloc > 0 && bloc < 4, "Numéro de bloc incorrect");
           // MessageBox.Show(message+ " en bloc "+bloc , "HERS");
            
        }

 
    }
}