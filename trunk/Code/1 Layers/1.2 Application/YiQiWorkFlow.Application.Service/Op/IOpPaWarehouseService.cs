/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpPaWarehouseService
    {
        string Create(OpPaWarehouse entity);

        OpPaWarehouse GetById(string id);

        IList<OpPaWarehouse> GetAll();

        void Update(OpPaWarehouse entity);

        /// <summary>
        /// 删除指定OpPaWarehouse
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpPaWarehouse entity);

        /// <summary>
        /// OpPaWarehouse
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpPaWarehouse> entitys);


        SearchResult<OpPaWarehouse> Search(SearchDtoBase<OpPaWarehouse> c);
		
		IList<OpPaWarehouse> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



