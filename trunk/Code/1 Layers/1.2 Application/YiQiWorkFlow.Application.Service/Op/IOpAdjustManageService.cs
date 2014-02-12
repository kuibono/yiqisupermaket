/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAdjustManageService
    {
        string Create(OpAdjustManage entity);

        OpAdjustManage GetById(string id);

        IList<OpAdjustManage> GetAll();

        void Update(OpAdjustManage entity);

        /// <summary>
        /// 删除指定OpAdjustManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAdjustManage entity);

        /// <summary>
        /// OpAdjustManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAdjustManage> entitys);


        SearchResult<OpAdjustManage> Search(SearchDtoBase<OpAdjustManage> c);
		
		IList<OpAdjustManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



