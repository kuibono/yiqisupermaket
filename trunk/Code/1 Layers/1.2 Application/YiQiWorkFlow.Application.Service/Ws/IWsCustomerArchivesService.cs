/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsCustomerArchivesService
    {
        string Create(WsCustomerArchives entity);

        WsCustomerArchives GetById(string id);

        IList<WsCustomerArchives> GetAll();

        void Update(WsCustomerArchives entity);

        /// <summary>
        /// 删除指定WsCustomerArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsCustomerArchives entity);

        /// <summary>
        /// WsCustomerArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsCustomerArchives> entitys);


        SearchResult<WsCustomerArchives> Search(SearchDtoBase<WsCustomerArchives> c);
		
		IList<WsCustomerArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



