/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpDynamicStockService
    {
        string Create(OpDynamicStock entity);

        OpDynamicStock GetById(string id);

        IList<OpDynamicStock> GetAll();

        void Update(OpDynamicStock entity);

        /// <summary>
        /// 删除指定OpDynamicStock
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpDynamicStock entity);

        /// <summary>
        /// OpDynamicStock
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpDynamicStock> entitys);


        SearchResult<OpDynamicStock> Search(SearchDtoBase<OpDynamicStock> c);
		
		IList<OpDynamicStock> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



