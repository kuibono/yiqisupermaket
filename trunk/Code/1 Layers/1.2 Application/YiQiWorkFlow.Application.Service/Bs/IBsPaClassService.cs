/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsPaClassService
    {
        string Create(BsPaClass entity);

        BsPaClass GetById(string id);

        IList<BsPaClass> GetAll();

        void Update(BsPaClass entity);

        /// <summary>
        /// 删除指定BsPaClass
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsPaClass entity);

        /// <summary>
        /// BsPaClass
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsPaClass> entitys);


        SearchResult<BsPaClass> Search(SearchDtoBase<BsPaClass> c);
		
		IList<BsPaClass> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



