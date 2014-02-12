/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsPaBranchWarehouseService
    {
        string Create(BsPaBranchWarehouse entity);

        BsPaBranchWarehouse GetById(string id);

        IList<BsPaBranchWarehouse> GetAll();

        void Update(BsPaBranchWarehouse entity);

        /// <summary>
        /// 删除指定BsPaBranchWarehouse
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsPaBranchWarehouse entity);

        /// <summary>
        /// BsPaBranchWarehouse
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsPaBranchWarehouse> entitys);


        SearchResult<BsPaBranchWarehouse> Search(SearchDtoBase<BsPaBranchWarehouse> c);
		
		IList<BsPaBranchWarehouse> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



