using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hej
{
    public class KlasseRepo
    {
        private int _nextId = 1;

        private List<Klasse> _klasses;

        public KlasseRepo()
        {
            _klasses = new List<Klasse>()
            {
                new Klasse { Id = _nextId ++, Name = "hej"}
            };
        }

        public List<Klasse> GetAll()
        {
            return new List<Klasse>(_klasses);
        }
    }
}
