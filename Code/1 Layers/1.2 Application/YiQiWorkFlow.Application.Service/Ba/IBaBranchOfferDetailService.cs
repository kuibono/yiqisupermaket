/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaBranchOfferDetailService
    {
        string Create(BaBranchOfferDetail entity);

        BaBranchOfferDetail GetById(string id);

        IList<BaBranchOfferDetail> GetAll();

        void Update(BaBranchOfferDetail entity);

        /// <summary>
        /// 删除指定BaBranchOfferDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaBranchOfferDetail entity);

        /// <summary>
        /// BaBranchOfferDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaBranchOfferDetail> entitys);


        SearchResult<BaBranchOfferDetail> Search(SearchDtoBase<BaBranchOfferDetail> c);
		
		IList<BaBranchOfferDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



