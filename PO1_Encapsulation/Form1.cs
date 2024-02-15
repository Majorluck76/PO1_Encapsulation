namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new();

        public Form1()
        {
            InitializeComponent();
            joueur.PointDeVies = 10;
            joueur.PointDePuissance = 1;

            dragon.PointDeVies = joueur.PointDeVies * 3;
            dragon.PointDePuissance = 3;


        }

        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = "vie du joueur : " + joueur.PointDeVies.ToString();
            lbl_pointsVieDragon.Text = "vie du dragon : " + dragon.PointDeVies.ToString();
            lbl_puissanceAttaqueJoueur.Text = "puissance du joueur : " + joueur.PointDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "puissance du dragon : " + dragon.PointDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDeVies -= joueur.PointDePuissance;
            TourDuDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVies += 5;
            TourDuDragon();
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointDePuissance++;
            TourDuDragon();
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }
        private void TourDuDragon()
        {
            joueur.PointDeVies -= dragon.PointDePuissance;
        }
    }
}