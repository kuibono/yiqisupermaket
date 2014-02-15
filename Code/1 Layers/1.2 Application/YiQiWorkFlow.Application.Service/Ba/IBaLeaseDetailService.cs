/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaLeaseDetailService
    {
        string Create(BaLeaseDetail entity);

        BaLeaseDetail GetById(string id);

        IList<BaLeaseDetail> GetAll();

        void Update(BaLeaseDetail entity);

        /// <summary>
        /// 删除指定BaLeaseDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaLeaseDetail entity);

        /// <summary>
        /// BaLeaseDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaLeaseDetail> entitys);


        SearchResult<BaLeaseDetail> Search(SearchDtoBase<BaLeaseDetail> c);
		
		IList<BaLeaseDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



