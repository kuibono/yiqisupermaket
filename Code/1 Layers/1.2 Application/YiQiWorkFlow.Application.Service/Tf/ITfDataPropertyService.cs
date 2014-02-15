/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:51
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Tf
{
    public interface ITfDataPropertyService
    {
        string Create(TfDataProperty entity);

        TfDataProperty GetById(string id);

        IList<TfDataProperty> GetAll();

        void Update(TfDataProperty entity);

        /// <summary>
        /// 删除指定TfDataProperty
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TfDataProperty entity);

        /// <summary>
        /// TfDataProperty
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<TfDataProperty> entitys);


        SearchResult<TfDataProperty> Search(SearchDtoBase<TfDataProperty> c);
		
		IList<TfDataProperty> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



