/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public interface IEmEmployeeArchivesService
    {
        string Create(EmEmployeeArchives entity);

        EmEmployeeArchives GetById(string id);

        IList<EmEmployeeArchives> GetAll();

        void Update(EmEmployeeArchives entity);

        /// <summary>
        /// 删除指定EmEmployeeArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(EmEmployeeArchives entity);

        /// <summary>
        /// EmEmployeeArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<EmEmployeeArchives> entitys);


        SearchResult<EmEmployeeArchives> Search(SearchDtoBase<EmEmployeeArchives> c);
		
		IList<EmEmployeeArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



