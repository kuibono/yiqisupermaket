/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsUpdateCardManageService
    {
        string Create(MsUpdateCardManage entity);

        MsUpdateCardManage GetById(string id);

        IList<MsUpdateCardManage> GetAll();

        void Update(MsUpdateCardManage entity);

        /// <summary>
        /// 删除指定MsUpdateCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsUpdateCardManage entity);

        /// <summary>
        /// MsUpdateCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsUpdateCardManage> entitys);

        SearchResult<MsUpdateCardManage> Search(SearchDtoBase<MsUpdateCardManage> c);

        IList<MsUpdateCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        string GenerateUpdateNumber();
    }
}