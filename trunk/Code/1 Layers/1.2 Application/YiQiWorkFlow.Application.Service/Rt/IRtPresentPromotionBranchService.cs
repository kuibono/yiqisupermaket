/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPresentPromotionBranchService
    {
        string Create(RtPresentPromotionBranch entity);

        RtPresentPromotionBranch GetById(string id);

        IList<RtPresentPromotionBranch> GetAll();

        void Update(RtPresentPromotionBranch entity);

        /// <summary>
        /// 删除指定RtPresentPromotionBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPresentPromotionBranch entity);

        /// <summary>
        /// RtPresentPromotionBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPresentPromotionBranch> entitys);


        SearchResult<RtPresentPromotionBranch> Search(SearchDtoBase<RtPresentPromotionBranch> c);
		
		IList<RtPresentPromotionBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



