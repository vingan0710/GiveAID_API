using GiveAID_API.Models.Context;
using GiveAID_API.Models.ModelView;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace GiveAID_API.Models.Repository.ContextRepo
{
    public class AccountRepository
    {
        private static AccountRepository? instance = null;
        private AccountRepository() { }

        public static AccountRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountRepository();
                }
                return instance;
            }
        }

        public List<AccountView> GetAllData()
        {
            var en = new GiveAIDContext();
            var lsAccount = en.Accounts.Select(s => new AccountView
            {
                Id = s.Id,
                Avt = s.Avt,
                Name = s.Name,
                Like = s.Like,
                Support = s.Support,
                Type_acc = s.Type_acc,
            }).ToList();
            return lsAccount;
        }

        public AccountView GetDatabyId(int Id)
        {
            AccountView av = new AccountView();

            try
            {
                var en = new GiveAIDContext();
                var selAccount = en.Accounts.Where(w => w.Id == Id).SingleOrDefault();
                var lsOrg = (from og in en.Organization_programs
                      where og.Status == 1 && og.Id_account == Id
                      select new Organization_programView
                      {
                          Id = og.Id,
                          O_image = og.O_image,
                          Day_start = og.Day_start,
                          O_name = og.O_name,
                          Target = og.Target,
                          Current = og.Current,

                      }).ToList();
                var lsGal = (from t in en.Galleries
                             join a in en.Accounts on t.Account_id equals a.Id
                             where a.Id == Id
                             select new GalleryView
                             {
                                 Id = t.Id,
                                 Image = t.Image,
                                 Image1 = t.Image1,
                                 Image2 = t.Image2,
                             }).ToList();
                if (selAccount != null)
                {
                    av.Id = Id;
                    av.Avt = selAccount.Avt;
                    av.Name = selAccount.Name;
                    av.Username = selAccount.Username;
                    av.Type_acc = selAccount.Type_acc;
                    av.Description = selAccount.Description;
                    av.Follower = selAccount.Follower;
                    av.Like = selAccount.Like;
                    av.Support = selAccount.Support;
                    av.lsOrg = lsOrg;
                    av.lsGal = lsGal;
                      
                }
            }
            catch (Exception)
            {
                throw;
            }
            return av;
        }

        
    }
}
