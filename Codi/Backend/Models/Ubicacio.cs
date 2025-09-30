using System.Security.Cryptography;

namespace Backend.Models
{
    public class Ubicacio
    {
        private int _id;
        private double _cordsX;
        private double _cordsY;
        private string _codiPostal;
        private string _poblacio;
        private string _direccio;

        public int Id { get => _id; set => _id = value; }
        public double CordsX { get => _cordsX; set => _cordsX = value; }
        public double CordsY { get => _cordsY; set => _cordsY = value; }
        public string CodiPostal { get => _codiPostal; set => _codiPostal = value; }
        public string Poblacio { get => _poblacio; set => _poblacio = value; }
        public string Direccio { get => _direccio; set => _direccio = value; }


        public Ubicacio() { }
        public Ubicacio(double cordsX, double cordsY, string codiPostal, string poblacio, string direccio)
        {
            _cordsX = cordsX;
            _cordsY = cordsY;
            _codiPostal = codiPostal;
            _poblacio = poblacio;
            _direccio = direccio;
        }
     
    }
}
