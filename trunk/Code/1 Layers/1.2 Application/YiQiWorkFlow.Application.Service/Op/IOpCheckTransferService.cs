/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpCheckTransferService
    {
        int Create(OpCheckTransfer entity);

        OpCheckTransfer GetById(int id);

        IList<OpCheckTransfer> GetAll();

        void Update(OpCheckTransfer entity);

        /// <summary>
        /// 删除指定OpCheckTransfer
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpCheckTransfer entity);

        /// <summary>
        /// OpCheckTransfer
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpCheckTransfer> entitys);


        SearchResult<OpCheckTransfer> Search(SearchDtoBase<OpCheckTransfer> c);
		
		IList<OpCheckTransfer> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



