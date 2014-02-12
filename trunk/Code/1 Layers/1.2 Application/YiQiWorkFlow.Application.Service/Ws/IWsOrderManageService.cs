/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsOrderManageService
    {
        string Create(WsOrderManage entity);

        WsOrderManage GetById(string id);

        IList<WsOrderManage> GetAll();

        void Update(WsOrderManage entity);

        /// <summary>
        /// 删除指定WsOrderManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsOrderManage entity);

        /// <summary>
        /// WsOrderManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsOrderManage> entitys);


        SearchResult<WsOrderManage> Search(SearchDtoBase<WsOrderManage> c);
		
		IList<WsOrderManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



