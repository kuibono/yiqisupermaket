/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCancelCardManageService
    {
        string Create(MsCancelCardManage entity);

        MsCancelCardManage GetById(string id);

        IList<MsCancelCardManage> GetAll();

        void Update(MsCancelCardManage entity);

        /// <summary>
        /// 删除指定MsCancelCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCancelCardManage entity);

        /// <summary>
        /// MsCancelCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCancelCardManage> entitys);


        SearchResult<MsCancelCardManage> Search(SearchDtoBase<MsCancelCardManage> c);
		
		IList<MsCancelCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);

        string GenerateCancelNumber();
    }
}



