/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Rt
{
    public interface IRtRetailPayService
    {
        int Create(RtRetailPay entity);

        RtRetailPay GetById(int id);

        IList<RtRetailPay> GetAll();

        void Update(RtRetailPay entity);

        /// <summary>
        /// 删除指定RtRetailPay
        /// </summary>
        /// <param name="entity"></param>
        void Delete(RtRetailPay entity);

        /// <summary>
        /// RtRetailPay
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<RtRetailPay> entitys);


        SearchResult<RtRetailPay> Search(SearchDtoBase<RtRetailPay> c);
		
		IList<RtRetailPay> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



