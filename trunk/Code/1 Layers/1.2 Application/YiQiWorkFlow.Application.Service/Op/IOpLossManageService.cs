/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpLossManageService
    {
        string Create(OpLossManage entity);

        OpLossManage GetById(string id);

        IList<OpLossManage> GetAll();

        void Update(OpLossManage entity);

        /// <summary>
        /// 删除指定OpLossManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpLossManage entity);

        /// <summary>
        /// OpLossManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpLossManage> entitys);


        SearchResult<OpLossManage> Search(SearchDtoBase<OpLossManage> c);
		
		IList<OpLossManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



