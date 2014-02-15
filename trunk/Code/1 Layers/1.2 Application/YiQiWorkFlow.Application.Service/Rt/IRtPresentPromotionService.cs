/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPresentPromotionService
    {
        string Create(RtPresentPromotion entity);

        RtPresentPromotion GetById(string id);

        IList<RtPresentPromotion> GetAll();

        void Update(RtPresentPromotion entity);

        /// <summary>
        /// 删除指定RtPresentPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPresentPromotion entity);

        /// <summary>
        /// RtPresentPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPresentPromotion> entitys);


        SearchResult<RtPresentPromotion> Search(SearchDtoBase<RtPresentPromotion> c);
		
		IList<RtPresentPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



