/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ms
{
    public interface IMsCardtypePointsService
    {
        string Create(MsCardtypePoints entity);

        MsCardtypePoints GetById(string id);

        IList<MsCardtypePoints> GetAll();

        void Update(MsCardtypePoints entity);

        /// <summary>
        /// 删除指定MsCardtypePoints
        /// </summary>
        /// <param name="entity"></param>
        void Delete(MsCardtypePoints entity);

        /// <summary>
        /// MsCardtypePoints
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<MsCardtypePoints> entitys);


        SearchResult<MsCardtypePoints> Search(SearchDtoBase<MsCardtypePoints> c);
		
		IList<MsCardtypePoints> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



