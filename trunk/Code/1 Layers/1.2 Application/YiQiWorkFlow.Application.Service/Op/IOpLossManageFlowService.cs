/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpLossManageFlowService
    {
        int Create(OpLossManageFlow entity);

        OpLossManageFlow GetById(int id);

        IList<OpLossManageFlow> GetAll();

        void Update(OpLossManageFlow entity);

        /// <summary>
        /// 删除指定OpLossManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpLossManageFlow entity);

        /// <summary>
        /// OpLossManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpLossManageFlow> entitys);


        SearchResult<OpLossManageFlow> Search(SearchDtoBase<OpLossManageFlow> c);
		
		IList<OpLossManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



