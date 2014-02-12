/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgGuideArchivesService
    {
        string Create(TgGuideArchives entity);

        TgGuideArchives GetById(string id);

        IList<TgGuideArchives> GetAll();

        void Update(TgGuideArchives entity);

        /// <summary>
        /// 删除指定TgGuideArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgGuideArchives entity);

        /// <summary>
        /// TgGuideArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgGuideArchives> entitys);


        SearchResult<TgGuideArchives> Search(SearchDtoBase<TgGuideArchives> c);
		
		IList<TgGuideArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



