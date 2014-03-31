using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace YiQiWorkFlow.Domain.Basement
{
    public class Command
    {

        private static string ConnectionString {
            get{
                NameValueCollection cfgName = (NameValueCollection)ConfigurationSettings.GetConfig("databaseSettings"); ;
                return cfgName["db.connectionString"].ToString();
            }
        }

        /// <summary>
        /// 增加批次
        /// </summary>
        public static SpPcUpdateStockResult SpPcUpdateStock (string GoodsCode,string GoodsBarCode,string EnCode,string WhCode,string SupCode,string OpCode,decimal InputTax,decimal PurchasePrice,decimal NontaxPurchasePrice,decimal PurchaseQty,string PiNumber,System.DateTime PutinDate,System.DateTime ProduceDate,string EmCode,string AdjustOperat,decimal SalePrice)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand("sp_pc_update_stock", con);
            com.CommandType = CommandType.StoredProcedure;
            
            SqlParameter par = new SqlParameter("@goods_code", GoodsCode);
            com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@goods_bar_code", GoodsBarCode);
            com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter("@en_code", EnCode);
            com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@wh_code", WhCode);
            com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@sup_code", SupCode);
            com.Parameters.Add(par5);
            SqlParameter par6 = new SqlParameter("@op_code", OpCode);
            com.Parameters.Add(par6);
            SqlParameter par7 = new SqlParameter("@input_tax", InputTax);
            com.Parameters.Add(par7);
            SqlParameter par8 = new SqlParameter("@purchase_price", PurchasePrice);
            com.Parameters.Add(par8);
            SqlParameter par9 = new SqlParameter("@nontax_purchase_price", NontaxPurchasePrice);
            com.Parameters.Add(par9);
            SqlParameter par10 = new SqlParameter("@purchase_qty", PurchaseQty);
            com.Parameters.Add(par10);
            SqlParameter par11 = new SqlParameter("@pi_number", PiNumber);
            com.Parameters.Add(par11);
            SqlParameter par12 = new SqlParameter("@putin_date", PutinDate);
            com.Parameters.Add(par12);
            SqlParameter par13 = new SqlParameter("@produce_date", ProduceDate);
            com.Parameters.Add(par13);
            SqlParameter par14 = new SqlParameter("@em_code", EmCode);
            com.Parameters.Add(par14);
            SqlParameter par15 = new SqlParameter("@adjust_operat", AdjustOperat);
            com.Parameters.Add(par15);
            SqlParameter par16 = new SqlParameter("@sale_price", SalePrice);
            com.Parameters.Add(par16);

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                SpPcUpdateStockResult r = new SpPcUpdateStockResult();
                con.Close();
                con.Dispose();
                return r;
            }
            con.Close();
            con.Dispose();
            return new SpPcUpdateStockResult();

        }

        /// <summary>
        /// 冲减分店库存
        /// </summary>
        public static SpPcUpdateStockBranchResult SpPcUpdateStockBranch(string GoodsCode, string GoodsBarCode, string EnCode, string bCode, string WhCode, string SupCode, string OpCode, decimal InputTax, decimal PurchasePrice, decimal NontaxPurchasePrice, decimal PurchaseQty, string PiNumber, System.DateTime PutinDate, System.DateTime ProduceDate, string EmCode, string AdjustOperat)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand("sp_pc_update_stock_branch", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@goods_code", GoodsCode));
            com.Parameters.Add(new SqlParameter("@goods_bar_code", GoodsBarCode));
            com.Parameters.Add(new SqlParameter("@en_code", EnCode));
            com.Parameters.Add(new SqlParameter("@b_code", bCode));
            com.Parameters.Add(new SqlParameter("@wh_code", WhCode));
            com.Parameters.Add(new SqlParameter("@sup_code", SupCode));
            com.Parameters.Add(new SqlParameter("@op_code", OpCode));
            com.Parameters.Add(new SqlParameter("@input_tax", InputTax));
            com.Parameters.Add(new SqlParameter("@purchase_price", PurchasePrice));
            com.Parameters.Add(new SqlParameter("@nontax_purchase_price", NontaxPurchasePrice));
            com.Parameters.Add(new SqlParameter("@purchase_qty", PurchaseQty));
            com.Parameters.Add(new SqlParameter("@pi_number", PiNumber));
            com.Parameters.Add(new SqlParameter("@putin_date", PutinDate));
            com.Parameters.Add(new SqlParameter("@produce_date", ProduceDate));
            com.Parameters.Add(new SqlParameter("@em_code", EmCode));
            com.Parameters.Add(new SqlParameter("@adjust_operat", AdjustOperat));

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                SpPcUpdateStockBranchResult r = new SpPcUpdateStockBranchResult();
                con.Close();
                con.Dispose();
                return r;
            }
            con.Close();
            con.Dispose();
            return new SpPcUpdateStockBranchResult();

        }

        /// <summary>
        /// 冲减批次
        /// </summary>
        public static SpPcUpdateStockOutResult SpPcUpdateStockOut(string GoodsCode, string GoodsBarCode, string EnCode, string WhCode, string SupCode, string OpCode, decimal InputTax, decimal PurchasePrice, decimal NontaxPurchasePrice, decimal PutoutQty, System.DateTime PutoutDate, string EmCode, string AdjustOperat, decimal SalePrice)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand("sp_pc_update_stock_out", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@goods_code", GoodsCode));
            com.Parameters.Add(new SqlParameter("@goods_bar_code", GoodsBarCode));
            com.Parameters.Add(new SqlParameter("@en_code", EnCode));
            com.Parameters.Add(new SqlParameter("@wh_code", WhCode));
            com.Parameters.Add(new SqlParameter("@sup_code", SupCode));
            com.Parameters.Add(new SqlParameter("@op_code", OpCode));
            com.Parameters.Add(new SqlParameter("@input_tax", InputTax));
            com.Parameters.Add(new SqlParameter("@purchase_price", PurchasePrice));
            com.Parameters.Add(new SqlParameter("@nontax_purchase_price", NontaxPurchasePrice));
            com.Parameters.Add(new SqlParameter("@putout_qty", PutoutQty));
            com.Parameters.Add(new SqlParameter("@putout_date", PutoutDate));
            com.Parameters.Add(new SqlParameter("@em_code", EmCode));
            com.Parameters.Add(new SqlParameter("@adjust_operat", AdjustOperat));
            com.Parameters.Add(new SqlParameter("@sale_price", SalePrice));

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                SpPcUpdateStockOutResult r = new SpPcUpdateStockOutResult();
                r.PutoutMoney = reader.GetDecimal(0);
                r.NontaxPutoutMoney = reader.GetDecimal(1);
                r.SaleMoney = reader.GetDecimal(2);
                r.NontaxSaleMoney = reader.GetDecimal(3);
                con.Close();
                con.Dispose();
                return r;
            }
            con.Close();
            con.Dispose();
            return new SpPcUpdateStockOutResult();

        }

        /// <summary>
        /// 增加分店库存
        /// </summary>
        public static SpPcUpdateStockOutBranchResult SpPcUpdateStockOutBranch(string GoodsCode, string GoodsBarCode, string EnCode, string bCode, string WhCode, string SupCode, string OpCode, decimal InputTax, decimal PurchasePrice, decimal NontaxPurchasePrice, decimal PutoutQty, System.DateTime PutoutDate, string EmCode, string AdjustOperat, decimal SalePrice)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand com = new SqlCommand("sp_pc_update_stock_out_branch", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add(new SqlParameter("@goods_code", GoodsCode));
            com.Parameters.Add(new SqlParameter("@goods_bar_code", GoodsBarCode));
            com.Parameters.Add(new SqlParameter("@en_code", EnCode));
            com.Parameters.Add(new SqlParameter("@b_code", bCode));
            com.Parameters.Add(new SqlParameter("@wh_code", WhCode));
            com.Parameters.Add(new SqlParameter("@sup_code", SupCode));
            com.Parameters.Add(new SqlParameter("@op_code", OpCode));
            com.Parameters.Add(new SqlParameter("@input_tax", InputTax));
            com.Parameters.Add(new SqlParameter("@purchase_price", PurchasePrice));
            com.Parameters.Add(new SqlParameter("@nontax_purchase_price", NontaxPurchasePrice));
            com.Parameters.Add(new SqlParameter("@putout_qty", PutoutQty));
            com.Parameters.Add(new SqlParameter("@putout_date", PutoutDate));
            com.Parameters.Add(new SqlParameter("@em_code", EmCode));
            com.Parameters.Add(new SqlParameter("@adjust_operat", AdjustOperat));
            com.Parameters.Add(new SqlParameter("@sale_price", SalePrice));

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                SpPcUpdateStockOutBranchResult r = new SpPcUpdateStockOutBranchResult();
                r.PutoutMoney = reader.GetDecimal(0);
                r.NontaxPutoutMoney = reader.GetDecimal(1);
                con.Close();
                con.Dispose();
                return r;
            }
            con.Close();
            con.Dispose();
            return new SpPcUpdateStockOutBranchResult();

        }
    }
    public class SpPcUpdateStockResult
    {
    }

    public class SpPcUpdateStockBranchResult
    {
    }

    public class SpPcUpdateStockOutResult
    {
        public decimal PutoutMoney { get; set; }

        public decimal NontaxPutoutMoney { get; set; }

        public decimal SaleMoney { get; set; }

        public decimal NontaxSaleMoney { get; set; }
    }

    public class SpPcUpdateStockOutBranchResult
    {
        public decimal PutoutMoney { get; set; }

        public decimal NontaxPutoutMoney { get; set; }
    }
}