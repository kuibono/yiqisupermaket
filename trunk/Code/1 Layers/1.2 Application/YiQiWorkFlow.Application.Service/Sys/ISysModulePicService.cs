/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysModulePicService
    {
        string Create(SysModulePic entity);

        SysModulePic GetById(string id);

        IList<SysModulePic> GetAll();

        void Update(SysModulePic entity);

        /// <summary>
        /// 删除指定SysModulePic
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysModulePic entity);

        /// <summary>
        /// SysModulePic
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysModulePic> entitys);


        SearchResult<SysModulePic> Search(SearchDtoBase<SysModulePic> c);
		
		IList<SysModulePic> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



