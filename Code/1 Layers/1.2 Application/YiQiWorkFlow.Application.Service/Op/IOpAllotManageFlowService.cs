/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAllotManageFlowService
    {
        string Create(OpAllotManageFlow entity);

        OpAllotManageFlow GetById(string id);

        IList<OpAllotManageFlow> GetAll();

        void Update(OpAllotManageFlow entity);

        /// <summary>
        /// 删除指定OpAllotManageFlow
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAllotManageFlow entity);

        /// <summary>
        /// OpAllotManageFlow
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAllotManageFlow> entitys);


        SearchResult<OpAllotManageFlow> Search(SearchDtoBase<OpAllotManageFlow> c);
		
		IList<OpAllotManageFlow> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



