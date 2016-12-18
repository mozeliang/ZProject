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
            var s=repository.GetList(c=>c.Ad_IsDetele==1,d=>d.Ad_ID,false);
            
            return administrators;
        }
    }
}
