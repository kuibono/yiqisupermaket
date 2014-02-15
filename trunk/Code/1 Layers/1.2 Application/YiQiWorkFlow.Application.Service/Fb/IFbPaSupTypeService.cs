/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaSupTypeService
    {
        string Create(FbPaSupType entity);

        FbPaSupType GetById(string id);

        IList<FbPaSupType> GetAll();

        void Update(FbPaSupType entity);

        /// <summary>
        /// 删除指定FbPaSupType
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaSupType entity);

        /// <summary>
        /// FbPaSupType
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaSupType> entitys);


        SearchResult<FbPaSupType> Search(SearchDtoBase<FbPaSupType> c);
		
		IList<FbPaSupType> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



