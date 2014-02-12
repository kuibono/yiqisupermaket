/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcPaDayaccountService
    {
        string Create(AcPaDayaccount entity);

        AcPaDayaccount GetById(string id);

        IList<AcPaDayaccount> GetAll();

        void Update(AcPaDayaccount entity);

        /// <summary>
        /// 删除指定AcPaDayaccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcPaDayaccount entity);

        /// <summary>
        /// AcPaDayaccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcPaDayaccount> entitys);


        SearchResult<AcPaDayaccount> Search(SearchDtoBase<AcPaDayaccount> c);
		
		IList<AcPaDayaccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



