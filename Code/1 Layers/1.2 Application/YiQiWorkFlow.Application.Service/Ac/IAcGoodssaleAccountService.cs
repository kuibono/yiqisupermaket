/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcGoodssaleAccountService
    {
        int Create(AcGoodssaleAccount entity);

        AcGoodssaleAccount GetById(int id);

        IList<AcGoodssaleAccount> GetAll();

        void Update(AcGoodssaleAccount entity);

        /// <summary>
        /// 删除指定AcGoodssaleAccount
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcGoodssaleAccount entity);

        /// <summary>
        /// AcGoodssaleAccount
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcGoodssaleAccount> entitys);


        SearchResult<AcGoodssaleAccount> Search(SearchDtoBase<AcGoodssaleAccount> c);
		
		IList<AcGoodssaleAccount> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



