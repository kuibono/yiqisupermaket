/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustSalepriceGoodsService
    {
        string Create(FbAdjustSalepriceGoods entity);

        FbAdjustSalepriceGoods GetById(string id);

        IList<FbAdjustSalepriceGoods> GetAll();

        void Update(FbAdjustSalepriceGoods entity);

        /// <summary>
        /// 删除指定FbAdjustSalepriceGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustSalepriceGoods entity);

        /// <summary>
        /// FbAdjustSalepriceGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustSalepriceGoods> entitys);


        SearchResult<FbAdjustSalepriceGoods> Search(SearchDtoBase<FbAdjustSalepriceGoods> c);
		
		IList<FbAdjustSalepriceGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



