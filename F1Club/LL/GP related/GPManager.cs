using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.GP_related
{
    public class GPManager
    {
        IGPDAO GPDAO;

        public GPManager(IGPDAO GPDAO)
        {
            this.GPDAO = GPDAO;
        }

        private static List<GP>? GPs = new List<GP>();

        private int GetLastID()
        {
            try
            {
                return GPDAO.GetLastInsertedId();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private void PopulateIfEmpty()
        {
            if (GPs.Any())
            {
                return;
            }
            else
            {
                RefreshGPsFromDatabase();
            }
        }
        private void RefreshGPsFromDatabase()
        {
            GPs?.Clear();

            foreach (GP GP in GPDAO.GetAllGPs())
            {
                GPs?.Add(GP);
            }
        }

        public void CreateGP(GP GP)
        {
            try
            {
                GPDAO.CreateGP(GP);
                GP.ID = GetLastID();
                GPs.Add(GP);

            }
            catch (Exception)
            {
                return;
            }
        }

        public void DeleteGP(int id)
        {
            try
            {
                GPDAO.DeleteGP(id);

                PopulateIfEmpty();
                GP GPToRemove = GPs?.FirstOrDefault(gp => gp.ID == id);
                if (GPToRemove != null)
                {
                    GPs.Remove(GPToRemove);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<GP> GetAllGPs()
        {
            RefreshGPsFromDatabase();
            return GPs.OrderByDescending(gp => gp.DateOfGP).ToList();

        }

        public GP GetGPByID(int id)
        {
            PopulateIfEmpty();
            GP GP = GPs?.FirstOrDefault(gp => gp.ID == id);
            return GP;
        }

        public void UpdateGP(GP GP)
        {
            try
            {
                GPDAO.UpdateGP(GP);
                PopulateIfEmpty();
                GP existingGP = GPs?.First(gp => gp.ID == GP.ID);
                if (existingGP != null)
                {
                    existingGP.Circuit = GP.Circuit;
                    existingGP.DateOfGP = GP.DateOfGP;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<GP>? GetAllGPsRefreshed()
        {
            PopulateIfEmpty();
            return GPs.ToList();
        }
    }
}
