/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcGoodssaleAccountTgService
    {
        int Create(AcGoodssaleAccountTg entity);

        AcGoodssaleAccountTg GetById(int id);

        IList<AcGoodssaleAccountTg> GetAll();

        void Update(AcGoodssaleAccountTg entity);

        /// <summary>
        /// 删除指定AcGoodssaleAccountTg
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcGoodssaleAccountTg entity);

        /// <summary>
        /// AcGoodssaleAccountTg
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcGoodssaleAccountTg> entitys);


        SearchResult<AcGoodssaleAccountTg> Search(SearchDtoBase<AcGoodssaleAccountTg> c);
		
		IList<AcGoodssaleAccountTg> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



