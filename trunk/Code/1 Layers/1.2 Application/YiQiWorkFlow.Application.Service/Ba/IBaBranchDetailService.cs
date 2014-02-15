/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaBranchDetailService
    {
        string Create(BaBranchDetail entity);

        BaBranchDetail GetById(string id);

        IList<BaBranchDetail> GetAll();

        void Update(BaBranchDetail entity);

        /// <summary>
        /// 删除指定BaBranchDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaBranchDetail entity);

        /// <summary>
        /// BaBranchDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaBranchDetail> entitys);


        SearchResult<BaBranchDetail> Search(SearchDtoBase<BaBranchDetail> c);
		
		IList<BaBranchDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



