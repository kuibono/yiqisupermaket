/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpSplitComManageFlowService
    {
        string Create(OpSplitComManageFlow entity);

        OpSplitComManageFlow GetById(string id);

        IList<OpSplitComManageFlow> GetAll();

        void Update(OpSplitComManageFlow entity);

        /// <summary>
        /// 删除指定OpSplitComManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpSplitComManageFlow entity);

        /// <summary>
        /// OpSplitComManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpSplitComManageFlow> entitys);


        SearchResult<OpSplitComManageFlow> Search(SearchDtoBase<OpSplitComManageFlow> c);
		
		IList<OpSplitComManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



