using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisV228._4
{
    public interface IController<T>
    {
        List<T> GetCards();
        T GetCard(int id);
        void AddCard(T record);
    }
}
