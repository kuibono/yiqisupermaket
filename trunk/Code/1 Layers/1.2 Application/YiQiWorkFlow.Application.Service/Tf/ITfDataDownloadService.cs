/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public interface ITfDataDownloadService
    {
        string Create(TfDataDownload entity);

        TfDataDownload GetById(string id);

        IList<TfDataDownload> GetAll();

        void Update(TfDataDownload entity);

        /// <summary>
        /// 删除指定TfDataDownload
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TfDataDownload entity);

        /// <summary>
        /// TfDataDownload
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TfDataDownload> entitys);


        SearchResult<TfDataDownload> Search(SearchDtoBase<TfDataDownload> c);
		
		IList<TfDataDownload> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



