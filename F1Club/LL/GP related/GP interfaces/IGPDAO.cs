using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface IGPDAO
    {
        List<GP> GetAllGPs();
        void CreateGP(GP gp);
        void UpdateGP(GP gp);
        void DeleteGP(int id);
        int GetLastInsertedId();
    }
}
