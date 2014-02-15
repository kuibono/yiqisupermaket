/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsPointtoprepaidManageService
    {
        int Create(MsPointtoprepaidManage entity);

        MsPointtoprepaidManage GetById(int id);

        IList<MsPointtoprepaidManage> GetAll();

        void Update(MsPointtoprepaidManage entity);

        /// <summary>
        /// 删除指定MsPointtoprepaidManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsPointtoprepaidManage entity);

        /// <summary>
        /// MsPointtoprepaidManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsPointtoprepaidManage> entitys);


        SearchResult<MsPointtoprepaidManage> Search(SearchDtoBase<MsPointtoprepaidManage> c);
		
		IList<MsPointtoprepaidManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



