/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyManageFlowService
    {
        int Create(BsSupplyManageFlow entity);

        BsSupplyManageFlow GetById(int id);

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



