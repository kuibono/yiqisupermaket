/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsReturnManageFlowService
    {
        string Create(BsReturnManageFlow entity);

        BsReturnManageFlow GetById(string id);

        IList<BsReturnManageFlow> GetAll();

        void Update(BsReturnManageFlow entity);

        /// <summary>
        /// 删除指定BsReturnManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsReturnManageFlow entity);

        /// <summary>
        /// BsReturnManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsReturnManageFlow> entitys);


        SearchResult<BsReturnManageFlow> Search(SearchDtoBase<BsReturnManageFlow> c);
		
		IList<BsReturnManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



