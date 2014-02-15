/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpCheckStockService
    {
        string Create(OpCheckStock entity);

        OpCheckStock GetById(string id);

        IList<OpCheckStock> GetAll();

        void Update(OpCheckStock entity);

        /// <summary>
        /// 删除指定OpCheckStock
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpCheckStock entity);

        /// <summary>
        /// OpCheckStock
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpCheckStock> entitys);


        SearchResult<OpCheckStock> Search(SearchDtoBase<OpCheckStock> c);
		
		IList<OpCheckStock> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



