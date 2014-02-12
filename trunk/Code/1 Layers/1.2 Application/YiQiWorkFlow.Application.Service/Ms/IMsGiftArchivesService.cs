/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsGiftArchivesService
    {
        string Create(MsGiftArchives entity);

        MsGiftArchives GetById(string id);

        IList<MsGiftArchives> GetAll();

        void Update(MsGiftArchives entity);

        /// <summary>
        /// 删除指定MsGiftArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsGiftArchives entity);

        /// <summary>
        /// MsGiftArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsGiftArchives> entitys);


        SearchResult<MsGiftArchives> Search(SearchDtoBase<MsGiftArchives> c);
		
		IList<MsGiftArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



