/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 19:01:50
*/
using System.Collections.Generic;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Basement;

namespace YiQiWorkFlow.Application.Service.Fb
{
    public interface IFbPaGoodsGbService
    {
        string Create(FbPaGoodsGb entity);

        FbPaGoodsGb GetById(string id);

        IList<FbPaGoodsGb> GetAll();

        void Update(FbPaGoodsGb entity);

        /// <summary>
        /// 删除指定FbPaGoodsGb
        /// </summary>
        /// <param name="entity"></param>
        void Delete(FbPaGoodsGb entity);

        /// <summary>
        /// FbPaGoodsGb
        /// </summary>
        /// <param name="entitys"></param>
        void Delete(IEnumerable<FbPaGoodsGb> entitys);


        SearchResult<FbPaGoodsGb> Search(SearchDtoBase<FbPaGoodsGb> c);
		
		IList<FbPaGoodsGb> Search(string key, int pageSize = 20, int pageIndex = 1);

        void Delete(IList<string> ids);
    }
}



