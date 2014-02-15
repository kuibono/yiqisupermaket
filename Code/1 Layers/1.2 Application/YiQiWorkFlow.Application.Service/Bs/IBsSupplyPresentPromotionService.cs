/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyPresentPromotionService
    {
        string Create(BsSupplyPresentPromotion entity);

        BsSupplyPresentPromotion GetById(string id);

        IList<BsSupplyPresentPromotion> GetAll();

        void Update(BsSupplyPresentPromotion entity);

        /// <summary>
        /// 删除指定BsSupplyPresentPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyPresentPromotion entity);

        /// <summary>
        /// BsSupplyPresentPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyPresentPromotion> entitys);


        SearchResult<BsSupplyPresentPromotion> Search(SearchDtoBase<BsSupplyPresentPromotion> c);
		
		IList<BsSupplyPresentPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



