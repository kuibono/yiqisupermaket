/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtClassPromotionService
    {
        string Create(RtClassPromotion entity);

        RtClassPromotion GetById(string id);

        IList<RtClassPromotion> GetAll();

        void Update(RtClassPromotion entity);

        /// <summary>
        /// 删除指定RtClassPromotion
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtClassPromotion entity);

        /// <summary>
        /// RtClassPromotion
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtClassPromotion> entitys);


        SearchResult<RtClassPromotion> Search(SearchDtoBase<RtClassPromotion> c);
		
		IList<RtClassPromotion> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



