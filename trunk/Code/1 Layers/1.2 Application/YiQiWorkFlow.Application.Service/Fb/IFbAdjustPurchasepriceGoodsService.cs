/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustPurchasepriceGoodsService
    {
        string Create(FbAdjustPurchasepriceGoods entity);

        FbAdjustPurchasepriceGoods GetById(string id);

        IList<FbAdjustPurchasepriceGoods> GetAll();

        void Update(FbAdjustPurchasepriceGoods entity);

        /// <summary>
        /// 删除指定FbAdjustPurchasepriceGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustPurchasepriceGoods entity);

        /// <summary>
        /// FbAdjustPurchasepriceGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustPurchasepriceGoods> entitys);


        SearchResult<FbAdjustPurchasepriceGoods> Search(SearchDtoBase<FbAdjustPurchasepriceGoods> c);
		
		IList<FbAdjustPurchasepriceGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



