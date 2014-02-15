/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpCheckManageService
    {
        string Create(OpCheckManage entity);

        OpCheckManage GetById(string id);

        IList<OpCheckManage> GetAll();

        void Update(OpCheckManage entity);

        /// <summary>
        /// 删除指定OpCheckManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpCheckManage entity);

        /// <summary>
        /// OpCheckManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpCheckManage> entitys);


        SearchResult<OpCheckManage> Search(SearchDtoBase<OpCheckManage> c);
		
		IList<OpCheckManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



