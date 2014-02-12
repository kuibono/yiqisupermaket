/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsMemberArchivesService
    {
        string Create(MsMemberArchives entity);

        MsMemberArchives GetById(string id);

        IList<MsMemberArchives> GetAll();

        void Update(MsMemberArchives entity);

        /// <summary>
        /// 删除指定MsMemberArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsMemberArchives entity);

        /// <summary>
        /// MsMemberArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsMemberArchives> entitys);


        SearchResult<MsMemberArchives> Search(SearchDtoBase<MsMemberArchives> c);
		
		IList<MsMemberArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



