/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaOfferDetailService
    {
        string Create(BaOfferDetail entity);

        BaOfferDetail GetById(string id);

        IList<BaOfferDetail> GetAll();

        void Update(BaOfferDetail entity);

        /// <summary>
        /// 删除指定BaOfferDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaOfferDetail entity);

        /// <summary>
        /// BaOfferDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaOfferDetail> entitys);


        SearchResult<BaOfferDetail> Search(SearchDtoBase<BaOfferDetail> c);
		
		IList<BaOfferDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



