/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAdjustManageFlowService
    {
        string Create(OpAdjustManageFlow entity);

        OpAdjustManageFlow GetById(string id);

        IList<OpAdjustManageFlow> GetAll();

        void Update(OpAdjustManageFlow entity);

        /// <summary>
        /// 删除指定OpAdjustManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAdjustManageFlow entity);

        /// <summary>
        /// OpAdjustManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAdjustManageFlow> entitys);


        SearchResult<OpAdjustManageFlow> Search(SearchDtoBase<OpAdjustManageFlow> c);
		
		IList<OpAdjustManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



