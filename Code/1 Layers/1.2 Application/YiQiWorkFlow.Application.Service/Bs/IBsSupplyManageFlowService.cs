/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyManageFlowService
    {
        string Create(BsSupplyManageFlow entity);

        BsSupplyManageFlow GetById(string id);

        IList<BsSupplyManageFlow> GetAll();

        void Update(BsSupplyManageFlow entity);

        /// <summary>
        /// 删除指定BsSupplyManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyManageFlow entity);

        /// <summary>
        /// BsSupplyManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyManageFlow> entitys);


        SearchResult<BsSupplyManageFlow> Search(SearchDtoBase<BsSupplyManageFlow> c);
		
		IList<BsSupplyManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


