/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcPaDayaccountStockService
    {
        string Create(AcPaDayaccountStock entity);

        AcPaDayaccountStock GetById(string id);

        IList<AcPaDayaccountStock> GetAll();

        void Update(AcPaDayaccountStock entity);

        /// <summary>
        /// 删除指定AcPaDayaccountStock
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcPaDayaccountStock entity);

        /// <summary>
        /// AcPaDayaccountStock
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcPaDayaccountStock> entitys);


        SearchResult<AcPaDayaccountStock> Search(SearchDtoBase<AcPaDayaccountStock> c);
		
		IList<AcPaDayaccountStock> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



