/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ws;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ws
{
    public interface IWsPaCustomerTypeService
    {
        string Create(WsPaCustomerType entity);

        WsPaCustomerType GetById(string id);

        IList<WsPaCustomerType> GetAll();

        void Update(WsPaCustomerType entity);

        /// <summary>
        /// 删除指定WsPaCustomerType
        /// </summary>
        /// <param name="entity"></param>
        void Delete(WsPaCustomerType entity);

        /// <summary>
        /// WsPaCustomerType
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<WsPaCustomerType> entitys);


        SearchResult<WsPaCustomerType> Search(SearchDtoBase<WsPaCustomerType> c);
		
		IList<WsPaCustomerType> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



