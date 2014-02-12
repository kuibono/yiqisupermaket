/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsMadecardManageService
    {
        string Create(MsMadecardManage entity);

        MsMadecardManage GetById(string id);

        IList<MsMadecardManage> GetAll();

        void Update(MsMadecardManage entity);

        /// <summary>
        /// 删除指定MsMadecardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsMadecardManage entity);

        /// <summary>
        /// MsMadecardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsMadecardManage> entitys);


        SearchResult<MsMadecardManage> Search(SearchDtoBase<MsMadecardManage> c);
		
		IList<MsMadecardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



