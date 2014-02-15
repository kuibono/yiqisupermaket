/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsWholesaleGoodsSetService
    {
        string Create(WsWholesaleGoodsSet entity);

        WsWholesaleGoodsSet GetById(string id);

        IList<WsWholesaleGoodsSet> GetAll();

        void Update(WsWholesaleGoodsSet entity);

        /// <summary>
        /// 删除指定WsWholesaleGoodsSet
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsWholesaleGoodsSet entity);

        /// <summary>
        /// WsWholesaleGoodsSet
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsWholesaleGoodsSet> entitys);


        SearchResult<WsWholesaleGoodsSet> Search(SearchDtoBase<WsWholesaleGoodsSet> c);
		
		IList<WsWholesaleGoodsSet> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



