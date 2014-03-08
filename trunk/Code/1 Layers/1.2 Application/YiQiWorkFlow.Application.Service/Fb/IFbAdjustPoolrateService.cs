/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbAdjustPoolrateService
    {
        string Create(FbAdjustPoolrate entity);

        FbAdjustPoolrate GetById(string id);

        void ExameByNumber(string id);

        IList<FbAdjustPoolrate> GetAll();

        void Update(FbAdjustPoolrate entity);

        /// <summary>
        /// 删除指定FbAdjustPoolrate
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbAdjustPoolrate entity);

        /// <summary>
        /// FbAdjustPoolrate
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbAdjustPoolrate> entitys);


        SearchResult<FbAdjustPoolrate> Search(SearchDtoBase<FbAdjustPoolrate> c);
		
		IList<FbAdjustPoolrate> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



