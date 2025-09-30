using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class Establiment
    {
        private int _id;
        private string _nom;
        private Client _propietari;
        private Ubicacio _ubicacio;
        private string _tipus;
        private string _accesibilitat;

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Tipus { get; set; }
        public string Accesibilitat { get; set; }

        // Relació amb Client
        public int ClientId { get; set; }       // EF Core utilitza aquesta columna per la relació
        public Client Propietari { get; set; }  //Include()

        // Relació amb Ubicacio
        public int UbicacioId { get; set; }       // EF Core utilitza aquesta columna per la relació
        public Ubicacio Ubicacio { get; set; }    


        public Establiment() { }

        public Establiment(string nom, Client propietari, Ubicacio ubicacio, string tipus, string accesibilitat)
        {
            Nom = nom;
            Propietari = propietari;
            ClientId = propietari?.Id ?? 0;
            Ubicacio = ubicacio;
            UbicacioId = ubicacio?.Id ?? 0;
            Tipus = tipus;
            Accesibilitat = accesibilitat;
        }

        public Establiment(string nom, int clientId, int ubicacioId, string tipus, string accesibilitat)
        {
            Nom = nom;
            ClientId = clientId;
            UbicacioId = ubicacioId;
            Tipus = tipus;
            Accesibilitat = accesibilitat;
        }

    }
}
