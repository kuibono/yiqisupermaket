/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysEnterpriseArchivesService
    {
        string Create(SysEnterpriseArchives entity);

        SysEnterpriseArchives GetById(string id);

        IList<SysEnterpriseArchives> GetAll();

        void Update(SysEnterpriseArchives entity);

        /// <summary>
        /// 删除指定SysEnterpriseArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysEnterpriseArchives entity);

        /// <summary>
        /// SysEnterpriseArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysEnterpriseArchives> entitys);


        SearchResult<SysEnterpriseArchives> Search(SearchDtoBase<SysEnterpriseArchives> c);
		
		IList<SysEnterpriseArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



