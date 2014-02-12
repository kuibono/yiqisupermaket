/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public interface IEmEmployeePhotoService
    {
        string Create(EmEmployeePhoto entity);

        EmEmployeePhoto GetById(string id);

        IList<EmEmployeePhoto> GetAll();

        void Update(EmEmployeePhoto entity);

        /// <summary>
        /// 删除指定EmEmployeePhoto
        /// </summary>
        /// <param name="entity"></param>
        void Delete(EmEmployeePhoto entity);

        /// <summary>
        /// EmEmployeePhoto
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<EmEmployeePhoto> entitys);


        SearchResult<EmEmployeePhoto> Search(SearchDtoBase<EmEmployeePhoto> c);
		
		IList<EmEmployeePhoto> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



