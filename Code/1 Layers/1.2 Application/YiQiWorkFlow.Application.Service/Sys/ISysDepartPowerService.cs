/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Sys
{
    public interface ISysDepartPowerService
    {
        string Create(SysDepartPower entity);

        SysDepartPower GetById(string id);

        IList<SysDepartPower> GetAll();

        void Update(SysDepartPower entity);

        /// <summary>
        /// 删除指定SysDepartPower
        /// </summary>
        /// <param name="entity"></param>
        void Delete(SysDepartPower entity);

        /// <summary>
        /// SysDepartPower
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<SysDepartPower> entitys);


        SearchResult<SysDepartPower> Search(SearchDtoBase<SysDepartPower> c);
		
		IList<SysDepartPower> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



