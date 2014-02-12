/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 23:42:08
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Op
{
    public interface IOpAllotManageService
    {
        string Create(OpAllotManage entity);

        OpAllotManage GetById(string id);

        IList<OpAllotManage> GetAll();

        void Update(OpAllotManage entity);

        /// <summary>
        /// 删除指定OpAllotManage
        /// </summary>
        /// <param name="entity"></param>
        void Delete(OpAllotManage entity);

        /// <summary>
        /// OpAllotManage
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<OpAllotManage> entitys);


        SearchResult<OpAllotManage> Search(SearchDtoBase<OpAllotManage> c);
		
		IList<OpAllotManage> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



