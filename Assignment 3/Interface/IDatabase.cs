using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IDatabase<T> where T : class
    {
        //interface (arayüz) bir nesnenin sahip olması gereken metot, özellik ve olayların belirlendiği, soyut bir yapıdır.
        void Add(T customer);
        T GetById(int id);
    }
}
