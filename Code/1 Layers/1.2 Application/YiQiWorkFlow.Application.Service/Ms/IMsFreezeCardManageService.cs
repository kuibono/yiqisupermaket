/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsFreezeCardManageService
    {
        string Create(MsFreezeCardManage entity);

        MsFreezeCardManage GetById(string id);

        IList<MsFreezeCardManage> GetAll();

        void Update(MsFreezeCardManage entity);

        /// <summary>
        /// 删除指定MsFreezeCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsFreezeCardManage entity);

        /// <summary>
        /// MsFreezeCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsFreezeCardManage> entitys);


        SearchResult<MsFreezeCardManage> Search(SearchDtoBase<MsFreezeCardManage> c);
		
		IList<MsFreezeCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



