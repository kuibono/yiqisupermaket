/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaChargeDetailService
    {
        string Create(BaChargeDetail entity);

        BaChargeDetail GetById(string id);

        IList<BaChargeDetail> GetAll();

        void Update(BaChargeDetail entity);

        /// <summary>
        /// 删除指定BaChargeDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaChargeDetail entity);

        /// <summary>
        /// BaChargeDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaChargeDetail> entitys);


        SearchResult<BaChargeDetail> Search(SearchDtoBase<BaChargeDetail> c);
		
		IList<BaChargeDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



