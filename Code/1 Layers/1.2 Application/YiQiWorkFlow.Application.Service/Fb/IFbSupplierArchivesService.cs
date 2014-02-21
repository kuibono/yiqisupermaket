/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbSupplierArchivesService
    {
        string Create(FbSupplierArchives entity);

        FbSupplierArchives GetById(string id);

        IList<FbSupplierArchives> GetAll();

        void Update(FbSupplierArchives entity);

        void SaveOrUpdate(FbSupplierArchives entity);

        /// <summary>
        /// 删除指定FbSupplierArchives
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbSupplierArchives entity);

        /// <summary>
        /// FbSupplierArchives
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbSupplierArchives> entitys);


        SearchResult<FbSupplierArchives> Search(SearchDtoBase<FbSupplierArchives> c);
		
		IList<FbSupplierArchives> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



