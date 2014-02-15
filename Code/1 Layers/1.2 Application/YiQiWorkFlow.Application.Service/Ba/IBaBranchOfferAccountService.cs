/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaBranchOfferAccountService
    {
        string Create(BaBranchOfferAccount entity);

        BaBranchOfferAccount GetById(string id);

        IList<BaBranchOfferAccount> GetAll();

        void Update(BaBranchOfferAccount entity);

        /// <summary>
        /// 删除指定BaBranchOfferAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaBranchOfferAccount entity);

        /// <summary>
        /// BaBranchOfferAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaBranchOfferAccount> entitys);


        SearchResult<BaBranchOfferAccount> Search(SearchDtoBase<BaBranchOfferAccount> c);
		
		IList<BaBranchOfferAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



