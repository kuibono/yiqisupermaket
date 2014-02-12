/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsWholesaleDetailService
    {
        string Create(WsWholesaleDetail entity);

        WsWholesaleDetail GetById(string id);

        IList<WsWholesaleDetail> GetAll();

        void Update(WsWholesaleDetail entity);

        /// <summary>
        /// 删除指定WsWholesaleDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsWholesaleDetail entity);

        /// <summary>
        /// WsWholesaleDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsWholesaleDetail> entitys);


        SearchResult<WsWholesaleDetail> Search(SearchDtoBase<WsWholesaleDetail> c);
		
		IList<WsWholesaleDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



