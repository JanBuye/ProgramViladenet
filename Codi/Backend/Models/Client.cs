namespace Backend.Models
{
    public class Client
    {
        private int _id;
        private string _nom;
        private string _cognom1;
        private string _cognom2;
        private string _cif;
        private string _email;
        
        public Client () { }
        public Client(int id,string nom, string cognom1, string cognom2, string cif, string email) 
        {
            _id = id;
            _nom = nom;
            _cognom1 = cognom1;
            _cognom2 = cognom2;
            _cif = cif;
            _email = email; 
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Cognom1 { get => _cognom1; set => _cognom1 = value; }
        public string Cognom2 { get => _cognom2; set => _cognom2 = value; }
        public string Cif { get => _cif; set => _cif = value; }
        public string Email { get => _email; set => _email = value; }
    }

}
