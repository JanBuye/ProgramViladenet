using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Treballador
    {
        private int _id;
        private string _nom;
        private string _cognom1;
        private string _cognom2;
        private string _dni;
        private string _email;
        private bool _vehicle;
        private List<BlockHores> _horesBloquejades;
        private List<BlockHores> _horestreballades;


        public Treballador() { }
        public Treballador(int id, string nom, string cognom1, string cognom2, string dni, string email, bool vehicle)
        {
            _id = id;
            _nom = nom;
            _cognom1 = cognom1;
            _cognom2 = cognom2;
            _dni = dni;
            _email = email;
            _vehicle = vehicle;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Cognom1 { get => _cognom1; set => _cognom1 = value; }
        public string Cognom2 { get => _cognom2; set => _cognom2 = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Vehicle { get => _vehicle; set => _vehicle = value; }

        [NotMapped]
        public List<BlockHores> HoresBloquejades { get => _horesBloquejades; set => _horesBloquejades = value; }
        [NotMapped]
        public List<BlockHores> Horestreballades { get => _horestreballades; set => _horestreballades = value; }
    }
}
