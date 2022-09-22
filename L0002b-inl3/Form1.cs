namespace L0002b_inl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definerar alla variabler jag beh�ver 
            string Fname = textBox1.Text;
            string Lname = textBox2.Text;
            string pnr = textBox3.Text;
            person.checking(pnr);

            //skriver ut Fnamn Enamn och pnr
            listBox1.Items.Clear();
            listBox1.Items.Add($"F�rnamn: {Fname}");
            listBox1.Items.Add($"Efternamn: {Lname}");
            listBox1.Items.Add($"Personnummer: {pnr}");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //st�nger ner appen
            Close();
        }
    }
    //skapar en klass som kommer kolla s� att personnummret �r giltligt
    //Kommer �ven kolla vilket k�n man �r
    class person
    {
        string Fname;
        string Lname;
        int pnr;

        public static int checking(string pnr)
        {
            //Algoritmen vi fick
            int value = 0;
            for (int i = 0; i < pnr.Length; i++)
            {
                int t = (pnr[i] - 48)
                       << (1 - (i & 1));
                if (t > 9)
                    t = t - 9;
                value += t;
            }

            int answer = value % 10;
            if (answer == 0)
            {
                //om personnummret st�mmer s� k�rs �ven den andra metoden
                MessageBox.Show("Personnummret �r giltligt");
                gender(pnr); 

            }
            else
            {
                MessageBox.Show("Personnummret �r inte giltligt");
            }
            return (value % 10);

        }

        static void gender(string pnr)
        {
            int gender = pnr[8] - 48;
            //om det �r j�mt s� �r man en kvinna eller s� �r man en man
            if (gender % 2 == 0)
            {
                MessageBox.Show("Kvinna");
            }
            else
            {
                MessageBox.Show("Man");
            }
        }

    }
}