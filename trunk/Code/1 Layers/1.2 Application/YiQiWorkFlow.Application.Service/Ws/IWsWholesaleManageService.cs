/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsWholesaleManageService
    {
        string Create(WsWholesaleManage entity);

        WsWholesaleManage GetById(string id);

        IList<WsWholesaleManage> GetAll();

        void Update(WsWholesaleManage entity);

        /// <summary>
        /// 删除指定WsWholesaleManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsWholesaleManage entity);

        /// <summary>
        /// WsWholesaleManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsWholesaleManage> entitys);


        SearchResult<WsWholesaleManage> Search(SearchDtoBase<WsWholesaleManage> c);
		
		IList<WsWholesaleManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


