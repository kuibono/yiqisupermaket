/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpGoodsBatchService
    {
        int Create(OpGoodsBatch entity);

        OpGoodsBatch GetById(int id);

        IList<OpGoodsBatch> GetAll();

        void Update(OpGoodsBatch entity);

        /// <summary>
        /// 删除指定OpGoodsBatch
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpGoodsBatch entity);

        /// <summary>
        /// OpGoodsBatch
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpGoodsBatch> entitys);


        SearchResult<OpGoodsBatch> Search(SearchDtoBase<OpGoodsBatch> c);
		
		IList<OpGoodsBatch> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



