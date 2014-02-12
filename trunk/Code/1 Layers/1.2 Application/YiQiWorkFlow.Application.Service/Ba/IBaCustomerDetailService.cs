/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaCustomerDetailService
    {
        string Create(BaCustomerDetail entity);

        BaCustomerDetail GetById(string id);

        IList<BaCustomerDetail> GetAll();

        void Update(BaCustomerDetail entity);

        /// <summary>
        /// 删除指定BaCustomerDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaCustomerDetail entity);

        /// <summary>
        /// BaCustomerDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaCustomerDetail> entitys);


        SearchResult<BaCustomerDetail> Search(SearchDtoBase<BaCustomerDetail> c);
		
		IList<BaCustomerDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



