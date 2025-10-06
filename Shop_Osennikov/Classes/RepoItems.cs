using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Osennikov.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, 3));
            allItems.Add(new Children("Кактус танцующий", 894, 6));
            allItems.Add(new Children("Кошка подушка", 1754, 6));
            allItems.Add(new Sport("Костюм", 4913, "S"));
            allItems.Add(new Sport("Мяч", 2200, "61-63 см"));
            allItems.Add(new Sport("Набор для гольфа", 2200, "600*800 мм"));
            return allItems;
        }
    }
}
