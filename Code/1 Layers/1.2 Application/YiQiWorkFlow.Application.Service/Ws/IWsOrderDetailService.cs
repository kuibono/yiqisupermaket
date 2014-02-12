/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsOrderDetailService
    {
        string Create(WsOrderDetail entity);

        WsOrderDetail GetById(string id);

        IList<WsOrderDetail> GetAll();

        void Update(WsOrderDetail entity);

        /// <summary>
        /// 删除指定WsOrderDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsOrderDetail entity);

        /// <summary>
        /// WsOrderDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsOrderDetail> entitys);


        SearchResult<WsOrderDetail> Search(SearchDtoBase<WsOrderDetail> c);
		
		IList<WsOrderDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



