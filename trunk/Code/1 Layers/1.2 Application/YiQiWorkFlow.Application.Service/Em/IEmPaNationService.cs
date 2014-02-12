/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public interface IEmPaNationService
    {
        string Create(EmPaNation entity);

        EmPaNation GetById(string id);

        IList<EmPaNation> GetAll();

        void Update(EmPaNation entity);

        /// <summary>
        /// 删除指定EmPaNation
        /// </summary>
        /// <param name="entity"></param>
        void Delete(EmPaNation entity);

        /// <summary>
        /// EmPaNation
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<EmPaNation> entitys);


        SearchResult<EmPaNation> Search(SearchDtoBase<EmPaNation> c);
		
		IList<EmPaNation> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



