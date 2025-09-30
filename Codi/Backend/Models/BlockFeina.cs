using System.Diagnostics.Contracts;

namespace Backend.Models
{
    public class BlockFeina
    {
        private int _id;
        private Event _event;
        private string _listTreballadors;
        private DateTime _horaInici;
        private DateTime _horaFinal;
        private Treballador _conductor;

        public BlockFeina() { }
        public BlockFeina (string listTreballadors, DateTime horaInici, DateTime horaFinal)
        {
            _listTreballadors = listTreballadors;
            _horaInici = horaInici;
            _horaFinal = horaFinal;
        }
        public BlockFeina(Event @event, string listTreballadors, DateTime horaInici, DateTime horaFinal, Treballador conductor)
        {
            _event = @event;
            _listTreballadors = listTreballadors;
            _horaInici = horaInici;
            _horaFinal = horaFinal;
            _conductor = conductor;
        }
        public int Id { get => _id; set => _id = value; }
        public Event Event { get => _event; set => _event = value; }
        public string ListTreballadors { get => _listTreballadors; set => _listTreballadors = value; }
        public DateTime HoraInici { get => _horaInici; set => _horaInici = value; }
        public DateTime HoraFinal { get => _horaFinal; set => _horaFinal = value; }
        public Treballador Conductor { get => _conductor; set => _conductor = value; }
    }
}
