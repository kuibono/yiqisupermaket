/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaBranchBalanceService
    {
        string Create(BaBranchBalance entity);

        BaBranchBalance GetById(string id);

        IList<BaBranchBalance> GetAll();

        void Update(BaBranchBalance entity);

        /// <summary>
        /// 删除指定BaBranchBalance
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaBranchBalance entity);

        /// <summary>
        /// BaBranchBalance
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaBranchBalance> entitys);


        SearchResult<BaBranchBalance> Search(SearchDtoBase<BaBranchBalance> c);
		
		IList<BaBranchBalance> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



