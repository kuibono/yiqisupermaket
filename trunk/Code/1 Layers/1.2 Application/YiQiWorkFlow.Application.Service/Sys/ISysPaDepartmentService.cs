/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysPaDepartmentService
    {
        string Create(SysPaDepartment entity);

        SysPaDepartment GetById(string id);

        IList<SysPaDepartment> GetAll();

        void Update(SysPaDepartment entity);

        /// <summary>
        /// 删除指定SysPaDepartment
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysPaDepartment entity);

        /// <summary>
        /// SysPaDepartment
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysPaDepartment> entitys);


        SearchResult<SysPaDepartment> Search(SearchDtoBase<SysPaDepartment> c);
		
		IList<SysPaDepartment> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



