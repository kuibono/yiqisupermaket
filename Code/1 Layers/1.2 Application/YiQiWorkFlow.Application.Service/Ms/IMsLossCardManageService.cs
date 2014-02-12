/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsLossCardManageService
    {
        string Create(MsLossCardManage entity);

        MsLossCardManage GetById(string id);

        IList<MsLossCardManage> GetAll();

        void Update(MsLossCardManage entity);

        /// <summary>
        /// 删除指定MsLossCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsLossCardManage entity);

        /// <summary>
        /// MsLossCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsLossCardManage> entitys);


        SearchResult<MsLossCardManage> Search(SearchDtoBase<MsLossCardManage> c);
		
		IList<MsLossCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



