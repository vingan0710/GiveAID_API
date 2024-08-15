using GiveAID_API.Models.ModelView;
using GiveAID_API.Models.Repository.ContextRepo;

namespace GiveAID_API.Models.Repository
{
    public class GvieAIDRepository
    {
        private static GvieAIDRepository? instance = null;
        private GvieAIDRepository() { }

        public static GvieAIDRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GvieAIDRepository();
                }
                return instance;
            }
        }
        #region ACCOUNTS
        public List<AccountView> GetAllAccount()
        {
            return AccountRepository.Instance.GetAllData();
        }

        public AccountView GetAccountbyId(int Id)
        {
            return AccountRepository.Instance.GetDatabyId(Id);
        }
        #endregion

        #region PROGRAMS
        public List<Organization_programView> GetOrgbyOutstanding()
        {
            return Organization_programRepository.Instance.getOrg();
        }
        public Organization_programView GetOrgbyId(int Id)
        {
            return Organization_programRepository.Instance.getOrgbyId(Id);
        }
        #endregion

        #region GALLERY
        public List<GalleryView> GetAllGallery()
        {
            return GalleryRepository.Instance.getGallery();
        }
        #endregion
    }
}
