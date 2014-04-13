/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsGrantCardManageService
    {
        string Create(MsGrantCardManage entity);

        MsGrantCardManage GetById(string id);

        IList<MsGrantCardManage> GetAll();

        void Update(MsGrantCardManage entity);

        /// <summary>
        /// 删除指定MsGrantCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsGrantCardManage entity);

        /// <summary>
        /// MsGrantCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsGrantCardManage> entitys);


        SearchResult<MsGrantCardManage> Search(SearchDtoBase<MsGrantCardManage> c);
		
		IList<MsGrantCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        string GenerateGrantNumber();
    }
}



