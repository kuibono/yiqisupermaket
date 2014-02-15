/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtRetailLogService
    {
        int Create(RtRetailLog entity);

        RtRetailLog GetById(int id);

        IList<RtRetailLog> GetAll();

        void Update(RtRetailLog entity);

        /// <summary>
        /// 删除指定RtRetailLog
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtRetailLog entity);

        /// <summary>
        /// RtRetailLog
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtRetailLog> entitys);


        SearchResult<RtRetailLog> Search(SearchDtoBase<RtRetailLog> c);
		
		IList<RtRetailLog> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



