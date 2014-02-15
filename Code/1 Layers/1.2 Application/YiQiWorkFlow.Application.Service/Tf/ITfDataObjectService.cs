/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public interface ITfDataObjectService
    {
        string Create(TfDataObject entity);

        TfDataObject GetById(string id);

        IList<TfDataObject> GetAll();

        void Update(TfDataObject entity);

        /// <summary>
        /// 删除指定TfDataObject
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TfDataObject entity);

        /// <summary>
        /// TfDataObject
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TfDataObject> entitys);


        SearchResult<TfDataObject> Search(SearchDtoBase<TfDataObject> c);
		
		IList<TfDataObject> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



