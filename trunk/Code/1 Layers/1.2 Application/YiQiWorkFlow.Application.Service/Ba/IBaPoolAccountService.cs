/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPoolAccountService
    {
        string Create(BaPoolAccount entity);

        BaPoolAccount GetById(string id);

        IList<BaPoolAccount> GetAll();

        void Update(BaPoolAccount entity);

        /// <summary>
        /// 删除指定BaPoolAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPoolAccount entity);

        /// <summary>
        /// BaPoolAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPoolAccount> entitys);


        SearchResult<BaPoolAccount> Search(SearchDtoBase<BaPoolAccount> c);
		
		IList<BaPoolAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



