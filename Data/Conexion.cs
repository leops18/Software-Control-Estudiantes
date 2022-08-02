using LinqToDB.Data;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion: DataConnection
    {
        public Conexion() : base("BD") { }
        
        public ITable<Estudiante> _Estudiante { get { return GetTable<Estudiante>(); } }

        private ITable<T> GetTable<T>()
        {
            throw new NotImplementedException();
        }
    }
}
