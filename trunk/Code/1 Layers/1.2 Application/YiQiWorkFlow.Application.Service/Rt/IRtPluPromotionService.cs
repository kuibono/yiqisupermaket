/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPluPromotionService
    {
        string Create(RtPluPromotion entity);

        RtPluPromotion GetById(string id);

        IList<RtPluPromotion> GetAll();

        void Update(RtPluPromotion entity);

        /// <summary>
        /// 删除指定RtPluPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPluPromotion entity);

        /// <summary>
        /// RtPluPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPluPromotion> entitys);


        SearchResult<RtPluPromotion> Search(SearchDtoBase<RtPluPromotion> c);
		
		IList<RtPluPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



