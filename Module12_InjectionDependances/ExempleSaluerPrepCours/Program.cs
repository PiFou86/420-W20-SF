using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExempleSaluerPrepCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Main_UtilisationClassique(args);
            Main_objetSansDependance(args);
            Main_objetAvecDependance(args);
        }

        static void Main_UtilisationClassique(string[] args)
        {
            Console.Out.WriteLine("Utilisation classique sans injection de dépendance automatique :");
            ISaluer saluerFormel = new SalutationFormelle();
            saluerFormel.DireBonjour("Ada Lovelace");

            ISaluer saluerInformel = new SalutationInformelle();
            saluerInformel.DireBonjour("Katherine Johnson");

            ISaluer saluerAmical = new SalutationAmicale();
            saluerAmical.DireBonjour("Margaret Hamilton");

            ApplicationSalutations appFormelle = new ApplicationSalutations(saluerAmical);
            appFormelle.Saluer("Richard Feynman");

            Console.Out.WriteLine();
        }

        static void Main_objetSansDependance(string[] args)
        {
            Console.Out.WriteLine("Utilisation du conteneur d'injection de dépendances sans dépendance :");
            // Création du conteneur d'injection de dépendances
            // Avec sa configuration par défaut
            // Pour information il va lire les configurations dans appsettings.json,
            // appsettings.{ENV}.json, les variables d'environnement et les 
            // arguments de la ligne de commande
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            // Enregistrement des services dans le conteneur (i.e. Configuration des dépendances)
            builder.Services.AddTransient<ISaluer, SalutationFormelle>();
            // builder.Services.AddTransient<ISaluer, SalutationInformelle>();
            // builder.Services.AddTransient<ISaluer, SalutationAmicale>();

            IHost host = builder.Build();

            // Résolution de la dépendance et exécution de l'application
            ISaluer saluer = host.Services.GetRequiredService<ISaluer>();
            saluer.DireBonjour("Dorothy Vaughan");

            Console.Out.WriteLine();
        }

        static void Main_objetAvecDependance(string[] args)
        {
            Console.Out.WriteLine("Utilisation du conteneur d'injection de dépendances avec dépendances :");
            // Création du conteneur d'injection de dépendances
            // Avec sa configuration par défaut
            // Pour information il va lire les configurations dans appsettings.json,
            // appsettings.{ENV}.json, les variables d'environnement et les 
            // arguments de la ligne de commande
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            // Enregistrement des services dans le conteneur
            builder.Services.AddTransient<ApplicationSalutations>();

            //builder.Services.AddTransient<ISaluer, SalutationFormelle>();
            // builder.Services.AddTransient<ISaluer, SalutationInformelle>();
            builder.Services.AddTransient<ISaluer, SalutationAmicale>();

            IHost host = builder.Build();

            // Résolution de la dépendance et exécution de l'application
            ApplicationSalutations app = host.Services.GetRequiredService<ApplicationSalutations>();
            app.Saluer("Richard Feynman");
            
            Console.Out.WriteLine();
        }

        static void Main_objetEtCycleDeVie(string[] args)
        {
            Console.Out.WriteLine("Utilisation du conteneur d'injection de dépendances avec cycle de vie des objets :");
            // Création du conteneur d'injection de dépendances
            // Avec sa configuration par défaut
            // Pour information il va lire les configurations dans appsettings.json,
            // appsettings.{ENV}.json, les variables d'environnement et les 
            // arguments de la ligne de commande
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            // Enregistrement des services dans le conteneur
            // Transient : une nouvelle instance est créée à chaque résolution de dépendance
            // Scoped : une nouvelle instance est créée par scope (i.e. par requête web, par scope manuel)
            // Singleton : une seule instance est créée pour toute la durée de vie de l'application
            builder.Services.AddScoped<ApplicationSalutations>();

            // builder.Services.AddTransient<ISaluer, SalutationFormelle>();
            // builder.Services.AddTransient<ISaluer, SalutationInformelle>();
            builder.Services.AddScoped<ISaluer, SalutationAmicale>();

            IHost host = builder.Build();

            // Résolution de la dépendance et exécution de l'application
            // Ici on crée un scope, à la fin du scope les objets sont désalloués
            using (IServiceScope scope = host.Services.CreateScope())
            {
                ApplicationSalutations app = scope.ServiceProvider.GetRequiredService<ApplicationSalutations>();
                app.Saluer("Richard Feynman");
            }

            Console.Out.WriteLine();
    }
}