/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcBranchGoodssaleAccountService
    {
        string Create(AcBranchGoodssaleAccount entity);

        AcBranchGoodssaleAccount GetById(string id);

        IList<AcBranchGoodssaleAccount> GetAll();

        void Update(AcBranchGoodssaleAccount entity);

        /// <summary>
        /// 删除指定AcBranchGoodssaleAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcBranchGoodssaleAccount entity);

        /// <summary>
        /// AcBranchGoodssaleAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcBranchGoodssaleAccount> entitys);


        SearchResult<AcBranchGoodssaleAccount> Search(SearchDtoBase<AcBranchGoodssaleAccount> c);
		
		IList<AcBranchGoodssaleAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


