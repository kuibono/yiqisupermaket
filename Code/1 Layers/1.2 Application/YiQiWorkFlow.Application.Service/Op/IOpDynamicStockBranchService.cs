/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpDynamicStockBranchService
    {
        string Create(OpDynamicStockBranch entity);

        OpDynamicStockBranch GetById(string id);

        IList<OpDynamicStockBranch> GetAll();

        void Update(OpDynamicStockBranch entity);

        /// <summary>
        /// 删除指定OpDynamicStockBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpDynamicStockBranch entity);

        /// <summary>
        /// OpDynamicStockBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpDynamicStockBranch> entitys);


        SearchResult<OpDynamicStockBranch> Search(SearchDtoBase<OpDynamicStockBranch> c);
		
		IList<OpDynamicStockBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



