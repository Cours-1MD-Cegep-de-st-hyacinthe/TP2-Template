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
                "Les pommes flottent dans l'eau parce qu'elles contiennent environ 25 % d'air.",
                "Les girafes ont le même nombre de vertèbres dans le cou que les humains.",
                "Les abeilles communiquent l'emplacement des fleurs grâce à une danse.",
                "Les carottes étaient mauves avant que les variétés orange deviennent populaires.",
                "Les escargots peuvent avoir des milliers de petites dents.",
                "Les manchots ont des genoux, même s'ils sont cachés dans leur corps.",
                "Le bambou peut pousser de près d'un mètre en une seule journée.",
                "Les chats passent une grande partie de leur vie à dormir.",
                "Les fourmis peuvent transporter plusieurs fois leur propre poids.",
                "Les hiboux ne peuvent pas bouger leurs yeux dans leurs orbites.",
                "Les calamars géants ont des yeux qui peuvent être plus grands qu'un ballon.",
                "Les tomates sont des fruits, mais elles sont souvent utilisées comme des légumes.",
                "Les chèvres ont des accents qui peuvent varier selon leur groupe.",
                "Les castors ont des dents orange à cause du fer contenu dans leur émail.",
                "Les corbeaux peuvent utiliser des outils pour atteindre de la nourriture.",
                "Les arbres libèrent de l'oxygène pendant la photosynthèse.",
                "Les étoiles de mer n'ont pas de cerveau central.",
                "Les ours polaires ont une peau noire sous leur fourrure.",
                "Les poissons-clowns peuvent changer de sexe au cours de leur vie.",
                "Les colibris peuvent voler vers l'arrière.",
                "Les méduses existent depuis plus longtemps que les dinosaures.",
                "Les termites peuvent construire des monticules plus hauts qu'un humain.",
                "Les plantes carnivores attirent parfois leurs proies avec des couleurs et des odeurs.",
                "Les cachalots peuvent produire des sons extrêmement puissants.",
                "Les dragons de Komodo peuvent détecter une proie à plusieurs kilomètres grâce à leur odorat.",
                "Certains bambous fleurissent seulement après plusieurs dizaines d'années.",
                "Les champignons sont plus proches des animaux que des plantes sur le plan évolutif.",
                "Les volcans peuvent créer de nouvelles îles lorsqu'ils entrent en éruption sous la mer.",
                "Les fourmis et les pucerons peuvent entretenir une relation semblable à l'élevage.",
                "Certains oiseaux migrateurs peuvent s'orienter en détectant le champ magnétique terrestre."
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
