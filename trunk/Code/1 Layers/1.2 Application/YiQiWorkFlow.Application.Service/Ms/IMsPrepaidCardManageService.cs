/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsPrepaidCardManageService
    {
        string Create(MsPrepaidCardManage entity);

        MsPrepaidCardManage GetById(string id);

        IList<MsPrepaidCardManage> GetAll();

        void Update(MsPrepaidCardManage entity);

        /// <summary>
        /// 删除指定MsPrepaidCardManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsPrepaidCardManage entity);

        /// <summary>
        /// MsPrepaidCardManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsPrepaidCardManage> entitys);


        SearchResult<MsPrepaidCardManage> Search(SearchDtoBase<MsPrepaidCardManage> c);
		
		IList<MsPrepaidCardManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}


