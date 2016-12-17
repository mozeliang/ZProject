using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Z.Core.Model.Main;

namespace Z.Core.Repository.Main
{
    public partial class AdministratorsRepository : RepositoryBase<Administrators>, IAdministratorsRepository
    {
       
    }
    public partial interface IAdministratorsRepository : IRepository<Administrators> {
    
    }
}
