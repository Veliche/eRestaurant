using SEDC.PracticalAspNet.Business.Model;
using SEDC.PracticalAspNet.Data.Model;
using SEDC.PracticalAspNet.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PracticalAspNet.Business.Service
{
    public class CategoryService : BaseService<CategoryRepository>, IService<DtoCategory>
    {
        public ServiceResult<DtoCategory> Add(DtoCategory item)
        {
            try
            {
                var menuExists = Repository.DbContext.Menus.Any(m => m.Id == item.Id);
                if (!menuExists)
                {
                    return new ServiceResult<DtoCategory>
                    {
                        Success = false,
                        ErrorMessage = "Menu not found"
                    };
                }
                var result = Repository.Create(new Category()
                {
                    Name = item.CategoryName,
                    MenuId = item.MenuId
                });
                return new ServiceResult<DtoCategory>()
                {
                    Item = new DtoCategory(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> Edit(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoCategory> Load(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<DtoCategory> LoadAll()
        {
            try
            {
                var categories = Repository.GetAll().ToList();
                var resultList = new List<DtoCategory>();
                categories.ForEach(c => resultList.Add(new DtoCategory(c)));
                return new ServiceResult<DtoCategory>()
                {
                    ListItems = resultList,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> Remove(DtoCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
