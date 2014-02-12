/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tg
{
    public interface ITgTravelArchivesPushtacService
    {
        string Create(TgTravelArchivesPushtac entity);

        TgTravelArchivesPushtac GetById(string id);

        IList<TgTravelArchivesPushtac> GetAll();

        void Update(TgTravelArchivesPushtac entity);

        /// <summary>
        /// 删除指定TgTravelArchivesPushtac
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TgTravelArchivesPushtac entity);

        /// <summary>
        /// TgTravelArchivesPushtac
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TgTravelArchivesPushtac> entitys);


        SearchResult<TgTravelArchivesPushtac> Search(SearchDtoBase<TgTravelArchivesPushtac> c);
		
		IList<TgTravelArchivesPushtac> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



