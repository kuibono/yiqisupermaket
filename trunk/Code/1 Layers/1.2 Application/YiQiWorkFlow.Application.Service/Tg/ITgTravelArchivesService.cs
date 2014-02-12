/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgTravelArchivesService
    {
        string Create(TgTravelArchives entity);

        TgTravelArchives GetById(string id);

        IList<TgTravelArchives> GetAll();

        void Update(TgTravelArchives entity);

        /// <summary>
        /// 删除指定TgTravelArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgTravelArchives entity);

        /// <summary>
        /// TgTravelArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgTravelArchives> entitys);


        SearchResult<TgTravelArchives> Search(SearchDtoBase<TgTravelArchives> c);
		
		IList<TgTravelArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



