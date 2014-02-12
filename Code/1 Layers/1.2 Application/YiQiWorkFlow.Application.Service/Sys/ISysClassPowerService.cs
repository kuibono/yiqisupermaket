/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysClassPowerService
    {
        string Create(SysClassPower entity);

        SysClassPower GetById(string id);

        IList<SysClassPower> GetAll();

        void Update(SysClassPower entity);

        /// <summary>
        /// 删除指定SysClassPower
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysClassPower entity);

        /// <summary>
        /// SysClassPower
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysClassPower> entitys);


        SearchResult<SysClassPower> Search(SearchDtoBase<SysClassPower> c);
		
		IList<SysClassPower> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



