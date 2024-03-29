/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpDynamicStockWhService
    {
        string Create(OpDynamicStockWh entity);

        OpDynamicStockWh GetById(string id);

        IList<OpDynamicStockWh> GetAll();

        void Update(OpDynamicStockWh entity);

        /// <summary>
        /// 删除指定OpDynamicStockWh
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpDynamicStockWh entity);

        /// <summary>
        /// OpDynamicStockWh
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpDynamicStockWh> entitys);


        SearchResult<OpDynamicStockWh> Search(SearchDtoBase<OpDynamicStockWh> c);
		
		IList<OpDynamicStockWh> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



