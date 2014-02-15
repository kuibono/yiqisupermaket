/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyPromotionService
    {
        string Create(BsSupplyPromotion entity);

        BsSupplyPromotion GetById(string id);

        IList<BsSupplyPromotion> GetAll();

        void Update(BsSupplyPromotion entity);

        /// <summary>
        /// 删除指定BsSupplyPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyPromotion entity);

        /// <summary>
        /// BsSupplyPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyPromotion> entitys);


        SearchResult<BsSupplyPromotion> Search(SearchDtoBase<BsSupplyPromotion> c);
		
		IList<BsSupplyPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



