/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustClassService
    {
        string Create(FbAdjustClass entity);

        FbAdjustClass GetById(string id);

        void ExameByNumber(string id);

        IList<FbAdjustClass> GetAll();

        void Update(FbAdjustClass entity);

        /// <summary>
        /// 删除指定FbAdjustClass
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustClass entity);

        /// <summary>
        /// FbAdjustClass
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustClass> entitys);


        SearchResult<FbAdjustClass> Search(SearchDtoBase<FbAdjustClass> c);
		
		IList<FbAdjustClass> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



