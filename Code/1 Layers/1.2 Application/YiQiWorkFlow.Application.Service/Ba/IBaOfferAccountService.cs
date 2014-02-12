/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaOfferAccountService
    {
        string Create(BaOfferAccount entity);

        BaOfferAccount GetById(string id);

        IList<BaOfferAccount> GetAll();

        void Update(BaOfferAccount entity);

        /// <summary>
        /// 删除指定BaOfferAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaOfferAccount entity);

        /// <summary>
        /// BaOfferAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaOfferAccount> entitys);


        SearchResult<BaOfferAccount> Search(SearchDtoBase<BaOfferAccount> c);
		
		IList<BaOfferAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



