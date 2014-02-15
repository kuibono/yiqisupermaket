/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtClassPromotionBranchService
    {
        string Create(RtClassPromotionBranch entity);

        RtClassPromotionBranch GetById(string id);

        IList<RtClassPromotionBranch> GetAll();

        void Update(RtClassPromotionBranch entity);

        /// <summary>
        /// 删除指定RtClassPromotionBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtClassPromotionBranch entity);

        /// <summary>
        /// RtClassPromotionBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtClassPromotionBranch> entitys);


        SearchResult<RtClassPromotionBranch> Search(SearchDtoBase<RtClassPromotionBranch> c);
		
		IList<RtClassPromotionBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



