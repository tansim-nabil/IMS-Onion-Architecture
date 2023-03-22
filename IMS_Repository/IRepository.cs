using IMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Repository
{
    public interface IRepository<T> where T : BaseEntity 
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
    }
}
