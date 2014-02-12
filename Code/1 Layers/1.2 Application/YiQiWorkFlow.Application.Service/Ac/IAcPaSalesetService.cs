/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Ac
{
    public interface IAcPaSalesetService
    {
        string Create(AcPaSaleset entity);

        AcPaSaleset GetById(string id);

        IList<AcPaSaleset> GetAll();

        void Update(AcPaSaleset entity);

        /// <summary>
        /// 删除指定AcPaSaleset
        /// </summary>
        /// <param name="entity"></param>
        void Delete(AcPaSaleset entity);

        /// <summary>
        /// AcPaSaleset
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<AcPaSaleset> entitys);


        SearchResult<AcPaSaleset> Search(SearchDtoBase<AcPaSaleset> c);
		
		IList<AcPaSaleset> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



