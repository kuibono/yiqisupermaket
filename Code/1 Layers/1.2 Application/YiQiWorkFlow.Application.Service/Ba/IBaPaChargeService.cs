/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPaChargeService
    {
        string Create(BaPaCharge entity);

        BaPaCharge GetById(string id);

        IList<BaPaCharge> GetAll();

        void Update(BaPaCharge entity);

        /// <summary>
        /// 删除指定BaPaCharge
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPaCharge entity);

        /// <summary>
        /// BaPaCharge
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPaCharge> entitys);


        SearchResult<BaPaCharge> Search(SearchDtoBase<BaPaCharge> c);
		
		IList<BaPaCharge> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



