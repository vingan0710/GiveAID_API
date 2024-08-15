using GiveAID_API.Models.Context;
using GiveAID_API.Models.ModelView;
using Microsoft.Identity.Client;

namespace GiveAID_API.Models.Repository.ContextRepo
{
    public class GalleryRepository
    {
        private static GalleryRepository? instance = null;
        private GalleryRepository() { }

        public static GalleryRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GalleryRepository();
                }
                return instance;
            }
        }

        public List<GalleryView> getGallery()
        {
            List<GalleryView> ls = new List<GalleryView>();
            var en = new GiveAIDContext();
            try
            {
                ls = (from g in en.Galleries
                      join og in en.Organization_programs on g.Program_id equals og.Id
                      join a in en.Accounts on og.Id_account equals a.Id
                      select new GalleryView
                      {
                          Id = g.Id,
                          Id_account = og.Id_account,
                          Avt = a.Avt,
                          Name = a.Name,
                          Program_id = g.Program_id,
                          O_name = og.O_name,
                          G_description = g.G_description,
                          Image = g.Image,
                          Image1 = g.Image1,
                          Image2 = g.Image2,
                          Created_at = g.Created_at,

                      }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return ls;
        }
        
    }
}
