using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Models
{
    public class Choir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Char Address { get; set; }
        public int Phonenumber { get; set; }
    }
    public class ChoirVocalist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Address { get; set; }
        public string Voicepart { get; set; }
    }
    public class ChoirInstrumentalist
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public char Address { get; set; }
        public string Instrument { get; set; }

    }
}
