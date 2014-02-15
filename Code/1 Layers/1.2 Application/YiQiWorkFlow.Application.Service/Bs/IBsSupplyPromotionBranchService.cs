/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsSupplyPromotionBranchService
    {
        string Create(BsSupplyPromotionBranch entity);

        BsSupplyPromotionBranch GetById(string id);

        IList<BsSupplyPromotionBranch> GetAll();

        void Update(BsSupplyPromotionBranch entity);

        /// <summary>
        /// 删除指定BsSupplyPromotionBranch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsSupplyPromotionBranch entity);

        /// <summary>
        /// BsSupplyPromotionBranch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsSupplyPromotionBranch> entitys);


        SearchResult<BsSupplyPromotionBranch> Search(SearchDtoBase<BsSupplyPromotionBranch> c);
		
		IList<BsSupplyPromotionBranch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



