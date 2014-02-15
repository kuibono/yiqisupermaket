/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Bs
{
    public interface IBsPaAreaService
    {
        string Create(BsPaArea entity);

        BsPaArea GetById(string id);

        IList<BsPaArea> GetAll();

        void Update(BsPaArea entity);

        /// <summary>
        /// 删除指定BsPaArea
        /// </summary>
        /// <param name="entity"></param>
        void Delete(BsPaArea entity);

        /// <summary>
        /// BsPaArea
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<BsPaArea> entitys);


        SearchResult<BsPaArea> Search(SearchDtoBase<BsPaArea> c);
		
		IList<BsPaArea> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



