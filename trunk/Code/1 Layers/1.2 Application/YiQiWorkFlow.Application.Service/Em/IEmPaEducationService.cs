/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public interface IEmPaEducationService
    {
        string Create(EmPaEducation entity);

        EmPaEducation GetById(string id);

        IList<EmPaEducation> GetAll();

        void Update(EmPaEducation entity);

        /// <summary>
        /// 删除指定EmPaEducation
        /// </summary>
        /// <param name="entity"></param>
        void Delete(EmPaEducation entity);

        /// <summary>
        /// EmPaEducation
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<EmPaEducation> entitys);


        SearchResult<EmPaEducation> Search(SearchDtoBase<EmPaEducation> c);
		
		IList<EmPaEducation> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



