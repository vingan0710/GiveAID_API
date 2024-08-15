using GiveAID_API.Models.Context;
using GiveAID_API.Models.ModelView;

namespace GiveAID_API.Models.Repository.ContextRepo
{
    public class Organization_programRepository
    {
        private static Organization_programRepository? instance = null;
        private Organization_programRepository() { }

        public static Organization_programRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Organization_programRepository();
                }
                return instance;
            }
        }

        public List<Organization_programView> getOrg()
        {
            List<Organization_programView> ls = new List<Organization_programView>();
            var en = new GiveAIDContext();
            try
            {
                ls = (from og in en.Organization_programs
                      join a in en.Accounts on og.Id_account equals a.Id
                      where og.Status == 1
                      select new Organization_programView
                      {
                          Id = og.Id,
                          O_image = og.O_image,
                          Day_start = og.Day_start,
                          Id_account = og.Id_account,
                          Avt = a.Avt,
                          Name = a.Name,
                          Username = a.Username,
                          O_name = og.O_name,
                          Target = og.Target,
                          Current = og.Current,
                          Outstanding = og.Outstanding,

                      }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return ls;
        }

        public Organization_programView getOrgbyId(int Id)
        {
            Organization_programView? ov = new Organization_programView();
            var en = new GiveAIDContext();
            try
            {

                ov = (from og in en.Organization_programs
                      join a in en.Accounts on og.Id_account equals a.Id
                      join t in en.Topics on og.Topic_id equals t.Id
                      join g in en.Galleries on og.Id equals g.Program_id
                      where og.Id == Id
                      select new Organization_programView
                      {
                          Id = og.Id,
                          O_image = og.O_image,
                          Topic_name = t.Topic_name,
                          Day_start = og.Day_start,
                          Day_end = og.Day_end,
                          Target = og.Target,
                          O_name = og.O_name,
                          O_address = og.O_address,
                          Id_account = og.Id_account,
                          Name = a.Name,
                          Current = og.Current,
                          O_description = og.O_description,
                          Image = g.Image,
                          Image1 = g.Image1,
                          Image2 = g.Image2,
                      }).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return ov;
        }
    }
}
