/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ba
{
    public interface IBaPaSubjectService
    {
        int Create(BaPaSubject entity);

        BaPaSubject GetById(int id);

        IList<BaPaSubject> GetAll();

        void Update(BaPaSubject entity);

        /// <summary>
        /// 删除指定BaPaSubject
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BaPaSubject entity);

        /// <summary>
        /// BaPaSubject
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BaPaSubject> entitys);


        SearchResult<BaPaSubject> Search(SearchDtoBase<BaPaSubject> c);
		
		IList<BaPaSubject> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



