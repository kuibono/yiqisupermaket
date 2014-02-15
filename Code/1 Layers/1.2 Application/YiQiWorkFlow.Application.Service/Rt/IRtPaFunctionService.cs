/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtPaFunctionService
    {
        string Create(RtPaFunction entity);

        RtPaFunction GetById(string id);

        IList<RtPaFunction> GetAll();

        void Update(RtPaFunction entity);

        /// <summary>
        /// 删除指定RtPaFunction
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtPaFunction entity);

        /// <summary>
        /// RtPaFunction
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtPaFunction> entitys);


        SearchResult<RtPaFunction> Search(SearchDtoBase<RtPaFunction> c);
		
		IList<RtPaFunction> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



