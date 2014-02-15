/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPaBranchAccountService
    {
        string Create(BaPaBranchAccount entity);

        BaPaBranchAccount GetById(string id);

        IList<BaPaBranchAccount> GetAll();

        void Update(BaPaBranchAccount entity);

        /// <summary>
        /// 删除指定BaPaBranchAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPaBranchAccount entity);

        /// <summary>
        /// BaPaBranchAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPaBranchAccount> entitys);


        SearchResult<BaPaBranchAccount> Search(SearchDtoBase<BaPaBranchAccount> c);
		
		IList<BaPaBranchAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



