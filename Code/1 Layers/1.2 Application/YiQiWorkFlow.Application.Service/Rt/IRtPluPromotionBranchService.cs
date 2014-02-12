/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPluPromotionBranchService
    {
        string Create(RtPluPromotionBranch entity);

        RtPluPromotionBranch GetById(string id);

        IList<RtPluPromotionBranch> GetAll();

        void Update(RtPluPromotionBranch entity);

        /// <summary>
        /// 删除指定RtPluPromotionBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPluPromotionBranch entity);

        /// <summary>
        /// RtPluPromotionBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPluPromotionBranch> entitys);


        SearchResult<RtPluPromotionBranch> Search(SearchDtoBase<RtPluPromotionBranch> c);
		
		IList<RtPluPromotionBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



