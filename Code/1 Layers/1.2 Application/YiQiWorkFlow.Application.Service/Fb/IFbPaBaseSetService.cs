/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaBaseSetService
    {
        string Create(FbPaBaseSet entity);

        FbPaBaseSet GetById(string id);

        IList<FbPaBaseSet> GetAll();

        void Update(FbPaBaseSet entity);

        /// <summary>
        /// 删除指定FbPaBaseSet
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaBaseSet entity);

        /// <summary>
        /// FbPaBaseSet
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaBaseSet> entitys);


        SearchResult<FbPaBaseSet> Search(SearchDtoBase<FbPaBaseSet> c);
		
		IList<FbPaBaseSet> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


