using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace Backend.Models
{
    public class BlockHores
    {
        private int _id;
        private Treballador _treballador;
        private bool _disp;
        private DateTime _inici;
        private DateTime _final;
        private bool _treballat;

        public BlockHores() { }

        public BlockHores(Treballador treballador, bool disp, DateTime inici, DateTime final)
        {
            _treballador = treballador;
            _disp = disp;
            _inici = inici;
            _final = final;
        }
        public int Id { get => _id; set => _id = value; }
        [NotMapped]
        public Treballador Treballador { get => _treballador; set => _treballador = value; }
        public bool Disp { get => _disp; set => _disp = value; }
        public DateTime Inici { get => _inici; set => _inici = value; }
        public DateTime Final { get => _final; set => _final = value; }
        public bool Treballat { get => _treballat; set => _treballat = value; }
    }
}
