/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsAdjustSalepriceGoodsService
    {
        string Create(BsAdjustSalepriceGoods entity);

        BsAdjustSalepriceGoods GetById(string id);

        IList<BsAdjustSalepriceGoods> GetAll();

        void Update(BsAdjustSalepriceGoods entity);

        /// <summary>
        /// 删除指定BsAdjustSalepriceGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsAdjustSalepriceGoods entity);

        /// <summary>
        /// BsAdjustSalepriceGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsAdjustSalepriceGoods> entitys);


        SearchResult<BsAdjustSalepriceGoods> Search(SearchDtoBase<BsAdjustSalepriceGoods> c);
		
		IList<BsAdjustSalepriceGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



