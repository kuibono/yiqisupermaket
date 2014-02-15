/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Em
{
    public interface IEmPaProfessionalTitleService
    {
        string Create(EmPaProfessionalTitle entity);

        EmPaProfessionalTitle GetById(string id);

        IList<EmPaProfessionalTitle> GetAll();

        void Update(EmPaProfessionalTitle entity);

        /// <summary>
        /// 删除指定EmPaProfessionalTitle
        /// </summary>
        /// <param name="entity"></param>
        void Delete(EmPaProfessionalTitle entity);

        /// <summary>
        /// EmPaProfessionalTitle
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<EmPaProfessionalTitle> entitys);


        SearchResult<EmPaProfessionalTitle> Search(SearchDtoBase<EmPaProfessionalTitle> c);
		
		IList<EmPaProfessionalTitle> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



