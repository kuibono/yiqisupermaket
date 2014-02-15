/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtSheetPromotionService
    {
        string Create(RtSheetPromotion entity);

        RtSheetPromotion GetById(string id);

        IList<RtSheetPromotion> GetAll();

        void Update(RtSheetPromotion entity);

        /// <summary>
        /// 删除指定RtSheetPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtSheetPromotion entity);

        /// <summary>
        /// RtSheetPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtSheetPromotion> entitys);


        SearchResult<RtSheetPromotion> Search(SearchDtoBase<RtSheetPromotion> c);
		
		IList<RtSheetPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



