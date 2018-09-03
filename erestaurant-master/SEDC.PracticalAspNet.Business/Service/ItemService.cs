using SEDC.PracticalAspNet.Business.Model;
using SEDC.PracticalAspNet.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Business.Service
{
    public class ItemService : BaseService<ItemRepository>, IService<DtoItem>
    {
        public ServiceResult<DtoItem> Add(DtoItem item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoItem> Edit(DtoItem item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoItem> Load(DtoItem item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoItem> LoadAll()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoItem> Remove(DtoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
