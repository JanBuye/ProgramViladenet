namespace Backend.Models
{
        public class Event
        {
            private int _id;
            private Client _client;
            private Establiment _establiment;
            private int _establimentId;
            private DateTime _diaInici;
            private DateTime _diaFi;
            private int _tipus;

            public Event() { }
            public Event(Client client, Establiment establiment, DateTime diaInici, DateTime diaFi, int tipus)
            {
                _client = client;
                _establiment = establiment;
                _diaInici = diaInici;
                _diaFi = diaFi;
                _tipus = tipus;
            }
            public int Id { get => _id; set => _id = value; }
            public Client Client { get => _client; set => _client = value; }
            public Establiment Establiment { get => _establiment; set => _establiment = value; }
            public DateTime DiaInici { get => _diaInici; set => _diaInici = value; }
            public DateTime DiaFi { get => _diaFi; set => _diaFi = value; }
            public int Tipus { get => _tipus; set => _tipus = value; }

            // Clau forana
            public int EstablimentId { get => _establimentId; set => _establimentId = value; }

        }
}


