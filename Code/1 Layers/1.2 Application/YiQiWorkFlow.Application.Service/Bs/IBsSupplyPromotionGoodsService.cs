/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyPromotionGoodsService
    {
        string Create(BsSupplyPromotionGoods entity);

        BsSupplyPromotionGoods GetById(string id);

        IList<BsSupplyPromotionGoods> GetAll();

        void Update(BsSupplyPromotionGoods entity);

        /// <summary>
        /// 删除指定BsSupplyPromotionGoods
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyPromotionGoods entity);

        /// <summary>
        /// BsSupplyPromotionGoods
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyPromotionGoods> entitys);


        SearchResult<BsSupplyPromotionGoods> Search(SearchDtoBase<BsSupplyPromotionGoods> c);
		
		IList<BsSupplyPromotionGoods> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



