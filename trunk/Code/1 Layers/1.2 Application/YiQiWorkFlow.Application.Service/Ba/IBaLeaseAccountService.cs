/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaLeaseAccountService
    {
        string Create(BaLeaseAccount entity);

        BaLeaseAccount GetById(string id);

        IList<BaLeaseAccount> GetAll();

        void Update(BaLeaseAccount entity);

        /// <summary>
        /// 删除指定BaLeaseAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaLeaseAccount entity);

        /// <summary>
        /// BaLeaseAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaLeaseAccount> entitys);


        SearchResult<BaLeaseAccount> Search(SearchDtoBase<BaLeaseAccount> c);
		
		IList<BaLeaseAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



