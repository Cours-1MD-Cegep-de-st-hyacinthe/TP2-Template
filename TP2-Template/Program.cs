namespace TP2_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le générateur de faits inusités !");

            int niveauInusité;

            do
            {
                Console.Write("Entrez un niveau d'inusité entre 0 et 5 : ");
            }
            while (!int.TryParse(Console.ReadLine(), out niveauInusité)
                || niveauInusité < 0
                || niveauInusité > 5);

            AfficherFaitInusité(niveauInusité);

            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour fermer la console...");
            Console.ReadKey();
        }

        static void AfficherFaitInusité(int niveauInusité)
        {
            string[] faits =
            {
                "Les bananes sont des baies, mais les fraises ne le sont pas.",
                "Les pieuvres ont trois cœurs.",
                "Le miel peut rester comestible pendant des milliers d'années.",
                "Les vaches ont de meilleures amies et peuvent être stressées lorsqu'elles en sont séparées.",
                "Les flamants roses naissent avec des plumes grises.",
                "Un groupe de flamants roses s'appelle une flamboyance.",
                "Les corbeaux peuvent reconnaître les visages humains.",
                "Les nuages peuvent peser plusieurs centaines de tonnes.",
                "Les empreintes digitales des koalas ressemblent à celles des humains.",
                "Les loutres de mer se tiennent parfois la main pendant leur sommeil.",
                "Le cœur d'une crevette est situé dans sa tête.",
                "Les chèvres ont des pupilles rectangulaires.",
                "La tour Eiffel peut grandir de plusieurs centimètres pendant l'été.",
                "Les dauphins ont des noms qui leur sont propres.",
                "Le sang des limules est bleu.",
                "Les papillons goûtent avec leurs pattes.",
                "Les axolotls peuvent régénérer certaines parties de leur cerveau.",
                "Une journée sur Vénus est plus longue qu'une année sur Vénus.",
                "Les éléphants ne peuvent pas sauter.",
                "Les hippocampes mâles portent les œufs et donnent naissance aux petits.",
                "Les requins existaient avant les arbres.",
                "Les tardigrades peuvent survivre à des conditions extrêmes.",
                "Le son ne se propage pas dans le vide de l'espace.",
                "Certains champignons peuvent contrôler le comportement des insectes.",
                "Les cachalots dorment verticalement dans l'eau.",
                "Le cerveau humain consomme environ 20 % de l'énergie du corps.",
                "Les tardigrades ont survécu à une exposition temporaire aux conditions de l'espace.",
                "Certaines grenouilles peuvent geler presque complètement puis reprendre vie.",
                "Une cuillère à café de matière d'une étoile à neutrons pèserait des milliards de tonnes.",
                "Les arbres peuvent communiquer entre eux grâce à des réseaux de champignons dans le sol."
            };

            int premierFaitDuNiveau = niveauInusité * 5;
            Random hasard = new Random();
            int numéroDuFait = premierFaitDuNiveau + hasard.Next(5);

            Console.WriteLine();
            Console.WriteLine($"Fait inusité de niveau {niveauInusité} :");
            Console.WriteLine(faits[numéroDuFait]);
        }
    }
}
