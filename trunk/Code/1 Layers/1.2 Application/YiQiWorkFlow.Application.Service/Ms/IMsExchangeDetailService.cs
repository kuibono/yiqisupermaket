/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsExchangeDetailService
    {
        string Create(MsExchangeDetail entity);

        MsExchangeDetail GetById(string id);

        IList<MsExchangeDetail> GetAll();

        void Update(MsExchangeDetail entity);

        /// <summary>
        /// 删除指定MsExchangeDetail
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsExchangeDetail entity);

        /// <summary>
        /// MsExchangeDetail
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsExchangeDetail> entitys);


        SearchResult<MsExchangeDetail> Search(SearchDtoBase<MsExchangeDetail> c);
		
		IList<MsExchangeDetail> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



