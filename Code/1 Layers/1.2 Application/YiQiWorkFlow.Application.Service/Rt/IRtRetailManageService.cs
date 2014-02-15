/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtRetailManageService
    {
        int Create(RtRetailManage entity);

        RtRetailManage GetById(int id);

        IList<RtRetailManage> GetAll();

        void Update(RtRetailManage entity);

        /// <summary>
        /// 删除指定RtRetailManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtRetailManage entity);

        /// <summary>
        /// RtRetailManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtRetailManage> entitys);


        SearchResult<RtRetailManage> Search(SearchDtoBase<RtRetailManage> c);
		
		IList<RtRetailManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



