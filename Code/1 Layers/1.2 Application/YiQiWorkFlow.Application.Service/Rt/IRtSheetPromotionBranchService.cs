/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtSheetPromotionBranchService
    {
        string Create(RtSheetPromotionBranch entity);

        RtSheetPromotionBranch GetById(string id);

        IList<RtSheetPromotionBranch> GetAll();

        void Update(RtSheetPromotionBranch entity);

        /// <summary>
        /// 删除指定RtSheetPromotionBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtSheetPromotionBranch entity);

        /// <summary>
        /// RtSheetPromotionBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtSheetPromotionBranch> entitys);


        SearchResult<RtSheetPromotionBranch> Search(SearchDtoBase<RtSheetPromotionBranch> c);
		
		IList<RtSheetPromotionBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



