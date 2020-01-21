using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersFinal
{
    public static class ORM
    {
        public partial class Form1 : frm_Users
        {
            public Form1()
            {
                InitializeComponent();
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                usersBindingSource.DataSource = ORM.SelectAllUsers();
                PlanetsBindingSource.DataSource = ORM.SelectAllPlanets();
                SpeciesBindingSource.DataSource = ORM.SelectAllSpecies();
                UserCategoriesBindingSource.DataSource = ORM.SelectAllUserCategories();
                UserRanksBindingSource.DataSource = ORM.SelectAllUserRanks();
            }
        }

        public static BountyCodersEntities bd = new BountyCodersEntities();
        public static List <Users> SelectAllUsers()
        {
            List<Users> _users =
                (from u in bd.Users
                 select u
                 ).ToList();
            return _users;
        }
        public static List<Planets> SelectAllPlanets()
        {
            List<Planets> _planets =
                (from p in bd.Planets
                 orderby p.idPlanet
                 select p).ToList();
            return _planets;
        }
        public static List<Species> SelectAllSpecies()
        {
            List<Species> _species =
                (from s in bd.Species
                 orderby s.idSpecie
                 select s).ToList();
            return _species;
        }
        public static List<UserCategories> SelectAllUserCategories()
        {
            List<UserCategories> _UserCategories =
                (from c in bd.UserCategories
                 orderby c.idUserCategory
                 select c).ToList();
            return _UserCategories;
        }
        public static List<UserRanks> SelectAllUserRanks()
        {
            List<UserRanks> _UserRanks =
                (from r in bd.UserRanks
                 orderby r.idUserRank
                 select r).ToList();
            return _UserRanks;
        }
        public static List<Users> SelectUserNameByName(string name)
        {
            List<Users> _users = (from u in bd.Users
                                  where u.UserName.Contains(name)
                                  orderby u.UserName ascending
                                  select u).ToList();
            return _users;
        }
        public static void InsertUser (int idUser, String CodeUser, String UserName, String login, String password, int idUserRank, int idUserCategory, int idPlanet, int idSpecie, List<Users> Users)
        {
            Users usuari = new Users();
            usuari.idUser = idUser;
            usuari.CodeUser = CodeUser;
            usuari.UserName = UserName;
            usuari.Login = login;
            usuari.Password = password;
            usuari.idUserRank = idUserRank;
            usuari.idUserCategory = idUserCategory;
            usuari.idPlanet = idPlanet;
            usuari.idSpecie = idSpecie;

            ORM.bd.Users.Add(usuari);
            ORM.bd.SaveChanges();
        }
    }
}
