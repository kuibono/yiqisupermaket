/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPaAccountService
    {
        string Create(BaPaAccount entity);

        BaPaAccount GetById(string id);

        IList<BaPaAccount> GetAll();

        void Update(BaPaAccount entity);

        /// <summary>
        /// 删除指定BaPaAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPaAccount entity);

        /// <summary>
        /// BaPaAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPaAccount> entitys);


        SearchResult<BaPaAccount> Search(SearchDtoBase<BaPaAccount> c);
		
		IList<BaPaAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


