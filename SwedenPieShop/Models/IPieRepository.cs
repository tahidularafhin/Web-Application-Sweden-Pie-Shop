using SwedenPieShop.Models;
using System.Collections.Generic;

namespace SwedenPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}
