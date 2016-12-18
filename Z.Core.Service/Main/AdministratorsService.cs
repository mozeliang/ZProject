using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Z.Core.Model.Main;
using Z.Core.Repository.Main;

namespace Z.Core.Service.Main
{
    public class AdministratorsService
    {
        IAdministratorsRepository repository = new AdministratorsRepository();

        public Administrators Create()
        {
            var s = new List<Administrators>();
            var administrators = new Administrators()
            {
                Ad_ID=1,
                Ad_AdminAccount="1",
                Ad_AdminPassword="1",
                Ad_CreateTime=DateTime.Now,
                Ad_IsDetele=1,
                Ad_IsDisable=1,
                Ad_UpdateTime=DateTime.Now
            };
            for (int i = 0; i < 10; i++)
            {
                s.Add(administrators);
            }

            repository.BatchCreate(s);

            return administrators;
        }
    }
}
