using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YiQiWorkFlow.Domain.Ac;
using YiQiWorkFlow.Domain.Ba;
using YiQiWorkFlow.Domain.Basement;
using YiQiWorkFlow.Domain.Bs;
using YiQiWorkFlow.Domain.Em;
using YiQiWorkFlow.Domain.Fb;
using YiQiWorkFlow.Domain.Ms;
using YiQiWorkFlow.Domain.Op;
using YiQiWorkFlow.Domain.Pc;
using YiQiWorkFlow.Domain.Rt;
using YiQiWorkFlow.Domain.Sys;
using YiQiWorkFlow.Domain.Tf;
using YiQiWorkFlow.Domain.Tg;
using YiQiWorkFlow.Domain.Ws;

namespace System
{
    public static class TypeConvertor
    {
        public static AcBranchGoodssaleAccount C(this ac_branch_goodssale_account m)
        {
            return new AcBranchGoodssaleAccount
            {
                Id = m.rt_flow_number.ToInt32(),
                EnCode = m.en_code,
                bCode = m.b_code,
                WhCode = m.wh_code,
                RtDate = m.rt_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                OpCode = m.op_code,
                SalePrice = m.sale_price,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                CostMoney = m.cost_money.Value,
                NontaxCostMoney = m.nontax_cost_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                SupCode = m.sup_code,
                PoolRate = m.pool_rate.Value,
                OutputTax = m.output_tax.Value,
                IfPromotion = m.if_promotion
            };
        }
        public static AcCashierSummary C(this ac_cashier_summary m)
        {
            return new AcCashierSummary
            {
                Id = m.rt_flow_number.ToInt32(),
                RtDate = m.rt_date,
                Cashier = m.cashier,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                bCode = m.b_code,
                PaywayCode = m.payway_code,
                SaleMoney = m.sale_money.Value,
                ExRate = m.ex_rate.Value,
                PayMoney = m.pay_money.Value,
                PayLoss = m.pay_loss.Value
            };
        }
        public static AcCounterSummary C(this ac_counter_summary m)
        {
            return new AcCounterSummary
            {
                Id = m.rt_flow_number.ToInt32(),
                RtDate = m.rt_date,
                UnderCounterCode = m.under_counter_code,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                bCode = m.b_code,
                PaywayCode = m.payway_code,
                SaleMoney = m.sale_money.Value,
                ExRate = m.ex_rate.Value,
                PayMoney = m.pay_money.Value,
                PayLoss = m.pay_loss.Value
            };
        }
        public static AcDayBranchclassJournalAccount C(this ac_day_branchclass_journal_account m)
        {
            return new AcDayBranchclassJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcDate = m.ac_date,
                bCode = m.b_code,
                GoodsClassCode = m.goods_class_code,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SupplyQty = m.supply_qty.Value,
                SupplyMoney = m.supply_money.Value,
                NontaxSupplyMoney = m.nontax_supply_money.Value,
                SpReturnQty = m.sp_return_qty.Value,
                SpReturnMoney = m.sp_return_money.Value,
                NontaxSpReturnMoney = m.nontax_sp_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value
            };
        }
        public static AcDayBranchgoodsJournalAccount C(this ac_day_branchgoods_journal_account m)
        {
            return new AcDayBranchgoodsJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcDate = m.ac_date,
                bCode = m.b_code,
                GoodsCode = m.goods_code,
                OpCode = m.op_code,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SupplyQty = m.supply_qty.Value,
                SupplyMoney = m.supply_money.Value,
                NontaxSupplyMoney = m.nontax_supply_money.Value,
                SpReturnQty = m.sp_return_qty.Value,
                SpReturnMoney = m.sp_return_money.Value,
                NontaxSpReturnMoney = m.nontax_sp_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value,
                SupCode = m.sup_code
            };
        }
        public static AcDayClassJournalAccount C(this ac_day_class_journal_account m)
        {
            return new AcDayClassJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcDate = m.ac_date,
                GoodsClassCode = m.goods_class_code,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value
            };
        }
        public static AcDayGoodsJournalAccount C(this ac_day_goods_journal_account m)
        {
            return new AcDayGoodsJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcDate = m.ac_date,
                GoodsCode = m.goods_code,
                OpCode = m.op_code,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustQty = m.adjust_qty.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value,
                SupCode = m.sup_code
            };
        }
        public static AcDayGoodsJournalAccountTemp C(this ac_day_goods_journal_account_temp m)
        {
            return new AcDayGoodsJournalAccountTemp
            {
                AcDate = m.ac_date,
                GoodsCode = m.goods_code,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value,
                Id = m.Id
            };
        }
        public static AcDayGoodsstockJournalAccount C(this ac_day_goodsstock_journal_account m)
        {
            return new AcDayGoodsstockJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcDate = m.ac_date,
                GoodsCode = m.goods_code,
                OpCode = m.op_code,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                SalePrice = m.sale_price.Value,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                InitSaleMoney = m.init_sale_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                PurchaseSaleMoney = m.purchase_sale_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                ReturnSaleMoney = m.return_sale_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                SupplyQty = m.supply_qty.Value,
                SupplyMoney = m.supply_money.Value,
                SupplySaleMoney = m.supply_sale_money.Value,
                SreturnQty = m.sreturn_qty.Value,
                SreturnMoney = m.sreturn_money.Value,
                SreturnSaleMoney = m.sreturn_sale_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                LossSaleMoney = m.loss_sale_money.Value,
                AdjustQty = m.adjust_qty.Value,
                AdjustMoney = m.adjust_money.Value,
                AdjustSaleMoney = m.adjust_sale_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                AdjustsaleMoney = m.adjustsale_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                StockSaleMoney = m.stock_sale_money.Value,
                SupCode = m.sup_code
            };
        }
        public static AcDayGoodsstockJournalAccountTemp C(this ac_day_goodsstock_journal_account_temp m)
        {
            return new AcDayGoodsstockJournalAccountTemp
            {
                AcDate = m.ac_date,
                GoodsCode = m.goods_code,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                StockSaleMoney = m.stock_sale_money.Value,
                Id = m.Id
            };
        }
        public static AcGoodssaleAccount C(this ac_goodssale_account m)
        {
            return new AcGoodssaleAccount
            {
                Id = m.rt_flow_number.ToInt32(),
                EnCode = m.en_code,
                WhCode = m.wh_code,
                RtDate = m.rt_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                OpCode = m.op_code,
                SalePrice = m.sale_price,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                CostMoney = m.cost_money.Value,
                NontaxCostMoney = m.nontax_cost_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                SupCode = m.sup_code,
                PoolRate = m.pool_rate.Value,
                OutputTax = m.output_tax.Value,
                IfPromotion = m.if_promotion
            };
        }
        public static AcGoodssaleAccountTg C(this ac_goodssale_account_tg m)
        {
            return new AcGoodssaleAccountTg
            {
                Id = m.rt_flow_number.ToInt32(),
                EnCode = m.en_code,
                WhCode = m.wh_code,
                RtDate = m.rt_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                OpCode = m.op_code,
                SalePrice = m.sale_price,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                CostMoney = m.cost_money.Value,
                NontaxCostMoney = m.nontax_cost_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                SupCode = m.sup_code,
                PoolRate = m.pool_rate.Value,
                OutputTax = m.output_tax.Value,
                IfPromotion = m.if_promotion
            };
        }
        public static AcMonthClassJournalAccount C(this ac_month_class_journal_account m)
        {
            return new AcMonthClassJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                AcMonth = m.ac_month,
                GoodsClassCode = m.goods_class_code,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value
            };
        }
        public static AcMonthGoodsJournalAccount C(this ac_month_goods_journal_account m)
        {
            return new AcMonthGoodsJournalAccount
            {
                Id = m.ac_flow_number.ToInt32(),
                OpCode = m.op_code,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                InitQty = m.init_qty.Value,
                InitMoney = m.init_money.Value,
                NontaxInitMoney = m.nontax_init_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value,
                SupCode = m.sup_code
            };
        }
        public static AcPaDayaccount C(this ac_pa_dayaccount m)
        {
            return new AcPaDayaccount
            {
                LastTyDate = m.last_ty_date,
                LastRtFlowNumber = m.last_rt_flow_number.Value,
                CurrentRtFlowNumber = m.current_rt_flow_number.Value,
                LastWsFlowNumber = m.last_ws_flow_number.Value,
                CurrentWsFlowNumber = m.current_ws_flow_number.Value,
                LastPiFlowNumber = m.last_pi_flow_number.Value,
                CurrentPiFlowNumber = m.current_pi_flow_number.Value,
                LastPoFlowNumber = m.last_po_flow_number.Value,
                CurrentPoFlowNumber = m.current_po_flow_number.Value,
                LastAlFlowNumber = m.last_al_flow_number.Value,
                CurrentAlFlowNumber = m.current_al_flow_number.Value,
                LastLoFlowNumber = m.last_lo_flow_number.Value,
                CurrentLoFlowNumber = m.current_lo_flow_number.Value,
                LastAdFlowNumber = m.last_ad_flow_number.Value,
                CurrentAdFlowNumber = m.current_ad_flow_number.Value,
                LastExFlowNumber = m.last_ex_flow_number.Value,
                CurrentExFlowNumber = m.current_ex_flow_number.Value,
                LastScFlowNumber = m.last_sc_flow_number.Value,
                CurrentScFlowNumber = m.current_sc_flow_number.Value,
                LastSpFlowNumber = m.last_sp_flow_number.Value,
                CurrentSpFlowNumber = m.current_sp_flow_number.Value,
                LastReFlowNumber = m.last_re_flow_number.Value,
                CurrentReFlowNumber = m.current_re_flow_number.Value,
                Id = m.Id
            };
        }
        public static AcPaDayaccountStock C(this ac_pa_dayaccount_stock m)
        {
            return new AcPaDayaccountStock
            {
                LastTyDate = m.last_ty_date,
                Id = m.Id
            };
        }
        public static AcPaSaleset C(this ac_pa_saleset m)
        {
            return new AcPaSaleset
            {
                LastTyDate = m.last_ty_date,
                LastSaFlowNumber = m.last_sa_flow_number.Value,
                CurrentSaFlowNumber = m.current_sa_flow_number.Value,
                Id = m.Id
            };
        }
        public static AcPeriodTimeSummary C(this ac_period_time_summary m)
        {
            return new AcPeriodTimeSummary
            {
                Id = m.rt_flow_number.ToInt32(),
                RtDate = m.rt_date,
                PeriodTime = m.period_time,
                WhCode = m.wh_code,
                bCode = m.b_code,
                PassengerFlow = m.passenger_flow.Value,
                AvgSalePrice = m.avg_sale_price.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value
            };
        }
        public static AcSalesmanSummary C(this ac_salesman_summary m)
        {
            return new AcSalesmanSummary
            {
                Id = m.rt_flow_number.ToInt32(),
                RtDate = m.rt_date,
                Salesman = m.salesman,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                bCode = m.b_code,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value
            };
        }
        public static AcStockAccount C(this ac_stock_account m)
        {
            return new AcStockAccount
            {
                EnCode = m.en_code,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                SupCode = m.sup_code,
                StockQty = m.stock_qty.Value,
                StockMoney = m.stock_money.Value,
                NontaxStockMoney = m.nontax_stock_money.Value,
                Id = m.Id
            };
        }
        public static AcSupplierJournal C(this ac_supplier_journal m)
        {
            return new AcSupplierJournal
            {
                Id = m.sup_flow_number.ToInt32(),
                SupCode = m.sup_code,
                AcDate = m.ac_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ReturnQty = m.return_qty.Value,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                AlinQty = m.alin_qty.Value,
                AlinMoney = m.alin_money.Value,
                NontaxAlinMoney = m.nontax_alin_money.Value,
                AloutQty = m.alout_qty.Value,
                AloutMoney = m.alout_money.Value,
                NontaxAloutMoney = m.nontax_alout_money.Value,
                LossQty = m.loss_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value
            };
        }
        public static BaBranchBalance C(this ba_branch_balance m)
        {
            return new BaBranchBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                bCode = m.b_code,
                PaywayCode = m.payway_code,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaBranchDetail C(this ba_branch_detail m)
        {
            return new BaBranchDetail
            {
                BaNumber = m.ba_number,
                OperatNumber = m.operat_number,
                OperatType = m.operat_type,
                ReceivableMoney = m.receivable_money.Value,
                ReceivedMoney = m.received_money.Value,
                UnreceivedMoney = m.unreceived_money.Value,
                PayMoney = m.pay_money.Value,
                PayMargin = m.pay_margin.Value,
                MarginDeal = m.margin_deal,
                TableName = m.table_name,
                ColumnName = m.column_name,
                Id = m.Id
            };
        }
        public static BaBranchOfferAccount C(this ba_branch_offer_account m)
        {
            return new BaBranchOfferAccount
            {
                Id = m.ac_number,
                AcDate = m.ac_date,
                EnCode = m.en_code,
                bCode = m.b_code,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                AccountMoney = m.account_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaBranchOfferDetail C(this ba_branch_offer_detail m)
        {
            return new BaBranchOfferDetail
            {
                AcNumber = m.ac_number,
                GoodsCode = m.goods_code,
                RtDate = m.rt_date,
                SaleQty = m.sale_qty.Value,
                SupplyPrice = m.supply_price.Value,
                SaleMoney = m.sale_money.Value,
                SupplyMoney = m.supply_money.Value,
                Id = m.Id
            };
        }
        public static BaChargeDetail C(this ba_charge_detail m)
        {
            return new BaChargeDetail
            {
                ChargeNumber = m.charge_number,
                Id = m.number_flow.ToInt32(),
                ChargeCode = m.charge_code,
                ChargeName = m.charge_name,
                ChargeStandard = m.charge_standard.Value,
                Comment = m.comment
            };
        }
        public static BaChargeManage C(this ba_charge_manage m)
        {
            return new BaChargeManage
            {
                Id = m.charge_number,
                ChargeDate = m.charge_date,
                ChargeObject = m.charge_object,
                ObjectCode = m.object_code,
                ObjectName = m.object_name,
                ChargeType = m.charge_type,
                ChargeMoney = m.charge_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaCustomerBalance C(this ba_customer_balance m)
        {
            return new BaCustomerBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                CustCode = m.cust_code,
                PaywayCode = m.payway_code,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaCustomerDetail C(this ba_customer_detail m)
        {
            return new BaCustomerDetail
            {
                BaNumber = m.ba_number,
                OperatNumber = m.operat_number,
                OperatType = m.operat_type,
                ReceivableMoney = m.receivable_money.Value,
                ReceivedMoney = m.received_money.Value,
                UnreceivedMoney = m.unreceived_money.Value,
                PayMoney = m.pay_money.Value,
                PayMargin = m.pay_margin.Value,
                MarginDeal = m.margin_deal,
                TableName = m.table_name,
                ColumnName = m.column_name,
                Id = m.Id
            };
        }
        public static BaLeaseAccount C(this ba_lease_account m)
        {
            return new BaLeaseAccount
            {
                Id = m.ac_number,
                AcDate = m.ac_date,
                EnCode = m.en_code,
                SupCode = m.sup_code,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                AccountMoney = m.account_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaLeaseDetail C(this ba_lease_detail m)
        {
            return new BaLeaseDetail
            {
                AcNumber = m.ac_number,
                GoodsCode = m.goods_code,
                RtDate = m.rt_date,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                PayableMoney = m.payable_money.Value,
                Id = m.Id
            };
        }
        public static BaOfferAccount C(this ba_offer_account m)
        {
            return new BaOfferAccount
            {
                Id = m.ac_number,
                AcDate = m.ac_date,
                EnCode = m.en_code,
                SupCode = m.sup_code,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                AccountMoney = m.account_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaOfferDetail C(this ba_offer_detail m)
        {
            return new BaOfferDetail
            {
                AcNumber = m.ac_number,
                GoodsCode = m.goods_code,
                RtDate = m.rt_date,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                PayableMoney = m.payable_money.Value,
                Id = m.Id
            };
        }
        public static BaPaAccount C(this ba_pa_account m)
        {
            return new BaPaAccount
            {
                SupCode = m.sup_code,
                LastRtFlowNumber = m.last_rt_flow_number.Value,
                CurrentRtFlowNumber = m.current_rt_flow_number.Value,
                Id = m.Id
            };
        }
        public static BaPaBranchAccount C(this ba_pa_branch_account m)
        {
            return new BaPaBranchAccount
            {
                bCode = m.b_code,
                LastRtFlowNumber = m.last_rt_flow_number.Value,
                CurrentRtFlowNumber = m.current_rt_flow_number.Value,
                Id = m.Id
            };
        }
        public static BaPaCharge C(this ba_pa_charge m)
        {
            return new BaPaCharge
            {
                Id = m.charge_code,
                ChargeName = m.charge_name,
                ChargeStandard = m.charge_standard.Value
            };
        }
        public static BaPaSubject C(this ba_pa_subject m)
        {
            return new BaPaSubject
            {
                Id = m.ba_flow_number.ToInt32(),
                OperatType = m.operat_type,
                OpCode = m.op_code,
                sNumber = m.s_number,
                DebitCredit = m.debit_credit,
                InputTax = m.input_tax.Value,
                SubjectCode = m.subject_code,
                IfTax = m.if_tax,
                IfDept = m.if_dept,
                IfSupplier = m.if_supplier,
                IfKind = m.if_kind,
                IfRate = m.if_rate,
                IfAntitone = m.if_antitone
            };
        }
        public static BaPoolAccount C(this ba_pool_account m)
        {
            return new BaPoolAccount
            {
                Id = m.ac_number,
                AcDate = m.ac_date,
                EnCode = m.en_code,
                SupCode = m.sup_code,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                AccountMoney = m.account_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaPoolDetail C(this ba_pool_detail m)
        {
            return new BaPoolDetail
            {
                AcNumber = m.ac_number,
                GoodsCode = m.goods_code,
                RtDate = m.rt_date,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                PoolRate = m.pool_rate.Value,
                PayableMoney = m.payable_money.Value,
                IfPromotion = m.if_promotion,
                Id = m.Id
            };
        }
        public static BaSupplierBalance C(this ba_supplier_balance m)
        {
            return new BaSupplierBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                SupCode = m.sup_code,
                PaywayCode = m.payway_code,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BaSupplierDetail C(this ba_supplier_detail m)
        {
            return new BaSupplierDetail
            {
                BaNumber = m.ba_number,
                OperatNumber = m.operat_number,
                OperatType = m.operat_type,
                PayableMoney = m.payable_money.Value,
                PaidMoney = m.paid_money.Value,
                UnpaidMoney = m.unpaid_money.Value,
                PayMoney = m.pay_money.Value,
                PayMargin = m.pay_margin.Value,
                MarginDeal = m.margin_deal,
                TableName = m.table_name,
                ColumnName = m.column_name,
                Id = m.Id
            };
        }
        public static BsAdjustSaleprice C(this bs_adjust_saleprice m)
        {
            return new BsAdjustSaleprice
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                AdjustType = m.adjust_type,
                bCode = m.b_code,
                ClassCode = m.class_code,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsAdjustSalepriceGoods C(this bs_adjust_saleprice_goods m)
        {
            return new BsAdjustSalepriceGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SalePriceOld = m.sale_price_old.Value,
                SalePrice = m.sale_price.Value,
                VipPriceOld = m.vip_price_old.Value,
                VipPrice = m.vip_price.Value,
                TradePriceOld = m.trade_price_old.Value,
                TradePrice = m.trade_price.Value,
                Id = m.Id
            };
        }
        public static BsBranchAllotDetail C(this bs_branch_allot_detail m)
        {
            return new BsBranchAllotDetail
            {
                AlNumber = m.al_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                StockQty = m.stock_qty.Value,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                AllotQty = m.allot_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                AllotMoney = m.allot_money.Value,
                NontaxAllotMoney = m.nontax_allot_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static BsBranchAllotManage C(this bs_branch_allot_manage m)
        {
            return new BsBranchAllotManage
            {
                Id = m.al_number,
                bCodeOut = m.b_code_out,
                WhCodeOut = m.wh_code_out,
                bCodeIn = m.b_code_in,
                WhCodeIn = m.wh_code_in,
                AlDate = m.al_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsBranchArchives C(this bs_branch_archives m)
        {
            return new BsBranchArchives
            {
                Id = m.b_code,
                bName = m.b_name,
                PyCode = m.py_code,
                bType = m.b_type,
                bState = m.b_state,
                AreaCode = m.area_code,
                ClassCode = m.class_code,
                Functionary = m.functionary,
                FunctionaryPhone = m.functionary_phone,
                ContactAddress = m.contact_address,
                OfficePhone = m.office_phone,
                FaxPhone = m.fax_phone,
                eMail = m.e_mail,
                Postalcode = m.postalcode,
                OpenAccount = m.open_account,
                BankAccount = m.bank_account,
                TaxNumber = m.tax_number,
                OpCode = m.op_code,
                StockVoucher = m.stock_voucher,
                InputTax = m.input_tax.Value,
                BalanceMode = m.balance_mode,
                PayMode = m.pay_mode,
                BalancePeriod = m.balance_period,
                BalanceDay = m.balance_day.Value,
                DeliveryDays = m.delivery_days.Value,
                SupplyPriceType = m.supply_price_type,
                GrossRate = m.gross_rate.Value,
                WhCode = m.wh_code,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsBranchPrice C(this bs_branch_price m)
        {
            return new BsBranchPrice
            {
                bCode = m.b_code,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SalePrice = m.sale_price.Value,
                VipPrice = m.vip_price.Value,
                TradePrice = m.trade_price.Value,
                ModifyDate = m.modify_date,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static BsPaArea C(this bs_pa_area m)
        {
            return new BsPaArea
            {
                AreaCode = m.area_code,
                AreaName = m.area_name,
                Functionary = m.functionary,
                Id = m.Id
            };
        }
        public static BsPaBranchWarehouse C(this bs_pa_branch_warehouse m)
        {
            return new BsPaBranchWarehouse
            {
                Id = m.wh_code,
                WhName = m.wh_name,
                WhArea = m.wh_area.Value,
                SysGuid = m.sys_guid
            };
        }
        public static BsPaClass C(this bs_pa_class m)
        {
            return new BsPaClass
            {
                ClassCode = m.class_code,
                ClassName = m.class_name,
                Id = m.Id
            };
        }
        public static BsReturnDetail C(this bs_return_detail m)
        {
            return new BsReturnDetail
            {
                ReNumber = m.re_number,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                ReturnQty = m.return_qty.Value,
                SupplyPrice = m.supply_price.Value,
                SupplyMoney = m.supply_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static BsReturnManage C(this bs_return_manage m)
        {
            return new BsReturnManage
            {
                Id = m.re_number,
                SpNumber = m.sp_number,
                bCode = m.b_code,
                EnCode = m.en_code,
                WhCode = m.wh_code,
                WhCodeIn = m.wh_code_in,
                SpType = m.sp_type,
                ReturnDate = m.return_date,
                ReturnMoney = m.return_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsReturnManageFlow C(this bs_return_manage_flow m)
        {
            return new BsReturnManageFlow
            {
                Id = m.re_flow_number.ToInt32(),
                bCode = m.b_code,
                EnCode = m.en_code,
                WhCode = m.wh_code,
                WhCodeIn = m.wh_code_in,
                SpType = m.sp_type,
                ReturnDate = m.return_date,
                ReturnMoney = m.return_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsSupplyDetail C(this bs_supply_detail m)
        {
            return new BsSupplyDetail
            {
                SpNumber = m.sp_number,
                WhCode = m.wh_code,
                bCode = m.b_code,
                SpState = m.sp_state,
                WhCodeOut = m.wh_code_out,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PurchasePackQty = m.purchase_pack_qty.Value,
                SupplyPackQty = m.supply_pack_qty.Value,
                PutinPackQty = m.putin_pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                PurchaseQty = m.purchase_qty.Value,
                SupplyQty = m.supply_qty.Value,
                PutinQty = m.putin_qty.Value,
                SupplyPrice = m.supply_price.Value,
                SupplyMoney = m.supply_money.Value,
                DiscountMoney = m.discount_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static BsSupplyManage C(this bs_supply_manage m)
        {
            return new BsSupplyManage
            {
                Id = m.sp_number,
                bCode = m.b_code,
                EnCode = m.en_code,
                WhCode = m.wh_code,
                WhCodeOut = m.wh_code_out,
                SpType = m.sp_type,
                SpState = m.sp_state,
                PurchaseDate = m.purchase_date,
                ExpectArriveDate = m.expect_arrive_date,
                SupplyDate = m.supply_date,
                PutinDate = m.putin_date,
                SupplyMoney = m.supply_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                PurchaseAssessor = m.purchase_assessor,
                PurchaseIfExamine = m.purchase_if_examine,
                PurchaseExamineDate = m.purchase_examine_date,
                SupplyAssessor = m.supply_assessor,
                SupplyIfExamine = m.supply_if_examine,
                SupplyExamineDate = m.supply_examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsSupplyManageFlow C(this bs_supply_manage_flow m)
        {
            return new BsSupplyManageFlow
            {
                Id = m.sp_flow_number.ToInt32(),
                bCode = m.b_code,
                EnCode = m.en_code,
                WhCode = m.wh_code,
                WhCodeOut = m.wh_code_out,
                SpType = m.sp_type,
                SpState = m.sp_state,
                PurchaseDate = m.purchase_date,
                ExpectArriveDate = m.expect_arrive_date,
                SupplyDate = m.supply_date,
                PutinDate = m.putin_date,
                SupplyMoney = m.supply_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                PurchaseAssessor = m.purchase_assessor,
                PurchaseIfExamine = m.purchase_if_examine,
                PurchaseExamineDate = m.purchase_examine_date,
                SupplyAssessor = m.supply_assessor,
                SupplyIfExamine = m.supply_if_examine,
                SupplyExamineDate = m.supply_examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsSupplyPresentPromotion C(this bs_supply_present_promotion m)
        {
            return new BsSupplyPresentPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                AdjustReason = m.adjust_reason,
                SpBranch = m.sp_branch,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsSupplyPresentPromotionBranch C(this bs_supply_present_promotion_branch m)
        {
            return new BsSupplyPresentPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static BsSupplyPresentPromotionGoods C(this bs_supply_present_promotion_goods m)
        {
            return new BsSupplyPresentPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                SupplyQty = m.supply_qty.Value,
                SupplyPrice = m.supply_price.Value,
                GoodsBarCodePresent = m.goods_bar_code_present,
                GoodsCodePresent = m.goods_code_present,
                PresentQty = m.present_qty.Value,
                PresentMoney = m.present_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static BsSupplyPromotion C(this bs_supply_promotion m)
        {
            return new BsSupplyPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                AdjustReason = m.adjust_reason,
                SpBranch = m.sp_branch,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static BsSupplyPromotionBranch C(this bs_supply_promotion_branch m)
        {
            return new BsSupplyPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static BsSupplyPromotionGoods C(this bs_supply_promotion_goods m)
        {
            return new BsSupplyPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                IfSalePrice = m.if_sale_price,
                SupplyPriceOld = m.supply_price_old.Value,
                SupplyPriceDiscount = m.supply_price_discount.Value,
                SupplyPrice = m.supply_price.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static EmEmployeeArchives C(this em_employee_archives m)
        {
            return new EmEmployeeArchives
            {
                Id = m.em_code,
                EmName = m.em_name,
                NameUsed = m.name_used,
                Birthday = m.birthday,
                Sex = m.sex,
                PoliticsCode = m.politics_code,
                NationCode = m.nation_code,
                EducationCode = m.education_code,
                ProfessionalTitleCode = m.Professional_title_code,
                IfMarried = m.if_married,
                NativePlace = m.native_place,
                Idcard = m.idcard,
                AccedeDay = m.accede_day,
                FamilyPhone = m.family_phone,
                Handset = m.handset,
                eMail = m.e_mail,
                FamilyAddress = m.family_address,
                Postalcode = m.postalcode,
                GraduateAcademy = m.graduate_academy,
                GraduateDay = m.graduate_day,
                dCode = m.d_code,
                bCode = m.b_code,
                DutyCode = m.duty_code,
                BankAccount = m.bank_account,
                PensionAccount = m.pension_account,
                EmState = m.em_state,
                Stature = m.stature.Value,
                Width = m.width.Value
            };
        }
        public static EmEmployeeFamily C(this em_employee_family m)
        {
            return new EmEmployeeFamily
            {
                EmCode = m.em_code,
                sNumber = m.s_number,
                MemberName = m.member_name,
                Relationship = m.relationship,
                Birthday = m.birthday,
                PoliticsCode = m.politics_code,
                DutyCode = m.duty_code,
                WorkDepartment = m.work_department,
                Id = m.Id
            };
        }
        public static EmEmployeePhoto C(this em_employee_photo m)
        {
            return new EmEmployeePhoto
            {
                EmCode = m.em_code,
                EmPhoto = m.em_photo,
                PhotoType = m.photo_type,
                Id = m.Id
            };
        }
        public static EmPaDuty C(this em_pa_duty m)
        {
            return new EmPaDuty
            {
                DutyCode = m.duty_code,
                DutyName = m.duty_name,
                Id = m.Id
            };
        }
        public static EmPaEducation C(this em_pa_education m)
        {
            return new EmPaEducation
            {
                EducationCode = m.education_code,
                EducationName = m.education_name,
                Id = m.Id
            };
        }
        public static EmPaNation C(this em_pa_nation m)
        {
            return new EmPaNation
            {
                NationCode = m.nation_code,
                NationName = m.nation_name,
                Id = m.Id
            };
        }
        public static EmPaPolitics C(this em_pa_politics m)
        {
            return new EmPaPolitics
            {
                PoliticsCode = m.politics_code,
                PoliticsName = m.politics_name,
                Id = m.Id
            };
        }
        public static EmPaProfessionalTitle C(this em_pa_Professional_title m)
        {
            return new EmPaProfessionalTitle
            {
                ProfessionalTitleCode = m.Professional_title_code,
                ProfessionalTitleName = m.Professional_title_name,
                Id = m.Id
            };
        }
        public static FbAdjustClass C(this fb_adjust_class m)
        {
            return new FbAdjustClass
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbAdjustClassGoods C(this fb_adjust_class_goods m)
        {
            return new FbAdjustClassGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                GbCodeOld = m.gb_code_old,
                GmCodeOld = m.gm_code_old,
                GsCodeOld = m.gs_code_old,
                GlCodeOld = m.gl_code_old,
                GbCode = m.gb_code,
                GmCode = m.gm_code,
                GsCode = m.gs_code,
                GlCode = m.gl_code,
                Id = m.Id
            };
        }
        public static FbAdjustPoolrate C(this fb_adjust_poolrate m)
        {
            return new FbAdjustPoolrate
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbAdjustPoolrateGoods C(this fb_adjust_poolrate_goods m)
        {
            return new FbAdjustPoolrateGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                SupCode = m.sup_code,
                PoolRateOld = m.pool_rate_old.Value,
                PoolRate = m.pool_rate.Value,
                Id = m.Id
            };
        }
        public static FbAdjustPurchaseprice C(this fb_adjust_purchaseprice m)
        {
            return new FbAdjustPurchaseprice
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbAdjustPurchasepriceGoods C(this fb_adjust_purchaseprice_goods m)
        {
            return new FbAdjustPurchasepriceGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                SupCode = m.sup_code,
                InputTax = m.input_tax.Value,
                PurchasePriceOld = m.purchase_price_old,
                NontaxPurchasePriceOld = m.nontax_purchase_price_old,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                Id = m.Id
            };
        }
        public static FbAdjustSaleprice C(this fb_adjust_saleprice m)
        {
            return new FbAdjustSaleprice
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbAdjustSalepriceGoods C(this fb_adjust_saleprice_goods m)
        {
            return new FbAdjustSalepriceGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SalePriceOld = m.sale_price_old.Value,
                SalePrice = m.sale_price.Value,
                VipPriceOld = m.vip_price_old.Value,
                VipPrice = m.vip_price.Value,
                TradePriceOld = m.trade_price_old.Value,
                TradePrice = m.trade_price.Value,
                StockQty = m.stock_qty.Value,
                LossMoney = m.loss_money.Value,
                NontaxLossMoney = m.nontax_loss_money.Value,
                Id = m.Id
            };
        }
        public static FbAdjustSupplier C(this fb_adjust_supplier m)
        {
            return new FbAdjustSupplier
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbAdjustSupplierGoods C(this fb_adjust_supplier_goods m)
        {
            return new FbAdjustSupplierGoods
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                SupCodeOld = m.sup_code_old,
                OpCodeOld = m.op_code_old,
                SupCode = m.sup_code,
                SupName = m.sup_name,
                PyCode = m.py_code,
                OpCode = m.op_code,
                PoolRate = m.pool_rate.Value,
                OfferMode = m.offer_mode,
                OfferMin = m.offer_min.Value,
                InputTax = m.input_tax.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price,
                Id = m.Id
            };
        }
        public static FbGoodsArchives C(this fb_goods_archives m)
        {
            return new FbGoodsArchives
            {
                Id = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsSubCode = m.goods_sub_code,
                GbCode = m.gb_code,
                GmCode = m.gm_code,
                GsCode = m.gs_code,
                GlCode = m.gl_code,
                GoodsType = m.goods_type,
                CheckMode = m.check_mode,
                SupCode = m.sup_code,
                OpCode = m.op_code,
                PoolRate = m.pool_rate.Value,
                GoodsName = m.goods_name,
                GoodsSubName = m.goods_sub_name,
                PyCode = m.py_code,
                GoodsState = m.goods_state,
                ProducingArea = m.producing_area,
                ArticleNumber = m.article_number,
                Specification = m.specification,
                ShelfLife = m.shelf_life,
                PackUnitCode = m.pack_unit_code,
                OfferMode = m.offer_mode,
                PackCoef = m.pack_coef.Value,
                OfferMin = m.offer_min.Value,
                InputTax = m.input_tax.Value,
                OutputTax = m.output_tax.Value,
                StockUpperLimit = m.stock_upper_limit.Value,
                StockLowerLimit = m.stock_lower_limit.Value,
                UnderFloorCode = m.under_floor_code,
                UnderCounterCode = m.under_counter_code,
                BrandCode = m.brand_code,
                CheckUnitCode = m.check_unit_code,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                AvgCost = m.avg_cost.Value,
                NontaxAvgCost = m.nontax_avg_cost.Value,
                GrossRate = m.gross_rate.Value,
                SupplyPrice = m.supply_price.Value,
                SalePrice = m.sale_price.Value,
                VipPrice = m.vip_price.Value,
                TradePrice = m.trade_price.Value,
                PushRate = m.push_rate.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbGoodsArchivesBar C(this fb_goods_archives_bar m)
        {
            return new FbGoodsArchivesBar
            {
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsBarName = m.goods_bar_name,
                PackUnitCode = m.pack_unit_code,
                PackCoef = m.pack_coef.Value,
                QtyType = m.qty_type,
                PriceType = m.price_type,
                SalePrice = m.sale_price.Value,
                VipPrice = m.vip_price.Value,
                TradePrice = m.trade_price.Value,
                PushRate = m.push_rate.Value,
                IfMainBar = m.if_main_bar,
                IfExamine = m.if_examine,
                Id = m.Id
            };
        }
        public static FbGoodsArchivesBind C(this fb_goods_archives_bind m)
        {
            return new FbGoodsArchivesBind
            {
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsCodeBind = m.goods_code_bind,
                GoodsBarCodeBind = m.goods_bar_code_bind,
                GoodsBarName = m.goods_bar_name,
                PackUnitCode = m.pack_unit_code,
                BindCoef = m.bind_coef.Value,
                SalePrice = m.sale_price.Value,
                BindSalePrice = m.bind_sale_price.Value,
                IfExamine = m.if_examine,
                SaleMoney = m.sale_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static FbGoodsArchivesLibrary C(this fb_goods_archives_library m)
        {
            return new FbGoodsArchivesLibrary
            {
                Id = m.goods_bar_code,
                GoodsName = m.goods_name,
                GoodsSubName = m.goods_sub_name,
                ProducingArea = m.producing_area,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                OwnerType = m.owner_type
            };
        }
        public static FbGoodsArchivesParts C(this fb_goods_archives_parts m)
        {
            return new FbGoodsArchivesParts
            {
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsCodePart = m.goods_code_part,
                GoodsBarCodePart = m.goods_bar_code_part,
                GoodsBarName = m.goods_bar_name,
                PackUnitCode = m.pack_unit_code,
                PartCoef = m.part_coef.Value,
                IfExamine = m.if_examine,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static FbGoodsArchivesPhoto C(this fb_goods_archives_photo m)
        {
            return new FbGoodsArchivesPhoto
            {
                GoodsCode = m.goods_code,
                sNumber = m.s_number,
                PhotoType = m.photo_type,
                Id = m.Id
            };
        }
        public static FbGoodsArchivesSupplier C(this fb_goods_archives_supplier m)
        {
            return new FbGoodsArchivesSupplier
            {
                GoodsCode = m.goods_code,
                SupCode = m.sup_code,
                SupName = m.sup_name,
                PyCode = m.py_code,
                OpCode = m.op_code,
                PoolRate = m.pool_rate.Value,
                OfferMode = m.offer_mode,
                OfferMin = m.offer_min.Value,
                InputTax = m.input_tax.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price,
                IfMainSupplier = m.if_main_supplier,
                IfExamine = m.if_examine,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static FbGoodsBarCode C(this fb_goods_bar_code m)
        {
            return new FbGoodsBarCode
            {
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsSubCode = m.goods_sub_code,
                GoodsName = m.goods_name,
                GoodsSubName = m.goods_sub_name,
                PyCode = m.py_code,
                GbCode = m.gb_code,
                GmCode = m.gm_code,
                GsCode = m.gs_code,
                GlCode = m.gl_code,
                OwnerType = m.owner_type,
                SupCode = m.sup_code,
                OpCode = m.op_code,
                PoolRate = m.pool_rate.Value,
                PackCoef = m.pack_coef.Value,
                PackUnitCode = m.pack_unit_code,
                QtyType = m.qty_type,
                PriceType = m.price_type,
                SalePrice = m.sale_price.Value,
                VipPrice = m.vip_price.Value,
                TradePrice = m.trade_price.Value,
                GoodsState = m.goods_state,
                ModifyDate = m.modify_date,
                Id = m.Id
            };
        }
        public static FbPaBaseSet C(this fb_pa_base_set m)
        {
            return new FbPaBaseSet
            {
                GoodsGbLen = m.goods_gb_len.Value,
                GoodsGmLen = m.goods_gm_len.Value,
                GoodsGsLen = m.goods_gs_len.Value,
                GoodsGlLen = m.goods_gl_len.Value,
                GoodsClassLevel = m.goods_class_level.Value,
                GoodsLen = m.goods_len.Value,
                GoodsPrefix = m.goods_prefix,
                SupLen = m.sup_len.Value,
                SupPrefixType = m.sup_prefix_type,
                SupPrefixContent = m.sup_prefix_content,
                PurchasePreciseLen = m.purchase_precise_len.Value,
                SalePreciseLen = m.sale_precise_len.Value,
                Operator = m.@operator,
                OperatorDate = m.@operator_date,
                Id = m.Id,
                IfChangePurchasePriceInArchives = m.if_change_purchase_price_in_archives
            };
        }
        public static FbPaGoodsBrand C(this fb_pa_goods_brand m)
        {
            return new FbPaGoodsBrand
            {
                BrandCode = m.brand_code,
                BrandName = m.brand_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsCheckUnit C(this fb_pa_goods_check_unit m)
        {
            return new FbPaGoodsCheckUnit
            {
                CheckUnitCode = m.check_unit_code,
                CheckUnitName = m.check_unit_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsCounter C(this fb_pa_goods_counter m)
        {
            return new FbPaGoodsCounter
            {
                CounterCode = m.counter_code,
                CounterName = m.counter_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsGb C(this fb_pa_goods_gb m)
        {
            return new FbPaGoodsGb
            {
                GbCode = m.gb_code,
                GbName = m.gb_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsGl C(this fb_pa_goods_gl m)
        {
            return new FbPaGoodsGl
            {
                GsCode = m.gs_code,
                GlCode = m.gl_code,
                GlName = m.gl_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsGm C(this fb_pa_goods_gm m)
        {
            return new FbPaGoodsGm
            {
                GbCode = m.gb_code,
                GmCode = m.gm_code,
                GmName = m.gm_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsGs C(this fb_pa_goods_gs m)
        {
            return new FbPaGoodsGs
            {
                GmCode = m.gm_code,
                GsCode = m.gs_code,
                GsName = m.gs_name,
                Id = m.Id
            };
        }
        public static FbPaGoodsPackUnit C(this fb_pa_goods_pack_unit m)
        {
            return new FbPaGoodsPackUnit
            {
                PackUnitCode = m.pack_unit_code,
                PackUnitName = m.pack_unit_name,
                Id = m.Id
            };
        }
        public static FbPaSupType C(this fb_pa_sup_type m)
        {
            return new FbPaSupType
            {
                SupTypeCode = m.sup_type_code,
                SupTypeName = m.sup_type_name,
                Id = m.Id
            };
        }
        public static FbSupplierArchives C(this fb_supplier_archives m)
        {
            return new FbSupplierArchives
            {
                Id = m.sup_code,
                SupName = m.sup_name,
                PyCode = m.py_code,
                SupTypeCode = m.sup_type_code,
                Functionary = m.functionary,
                FunctionaryPhone = m.functionary_phone,
                Linkman = m.linkman,
                ContactPhone = m.contact_phone,
                ContactAddress = m.contact_address,
                OfficePhone = m.office_phone,
                FaxPhone = m.fax_phone,
                eMail = m.e_mail,
                Postalcode = m.postalcode,
                OpenAccount = m.open_account,
                BankAccount = m.bank_account,
                TaxNumber = m.tax_number,
                OpCode = m.op_code,
                StockVoucher = m.stock_voucher,
                InputTax = m.input_tax.Value,
                BalanceMode = m.balance_mode,
                PayMode = m.pay_mode,
                BalancePeriod = m.balance_period,
                BalanceDay = m.balance_day.Value,
                OfferMode = m.offer_mode,
                DeliveryDays = m.delivery_days.Value,
                PoolRate = m.pool_rate.Value,
                FloorsMoney = m.floors_money.Value,
                ExcessRate = m.excess_rate.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static FbSupplierLease C(this fb_supplier_lease m)
        {
            return new FbSupplierLease
            {
                Id = m.le_number,
                SupCode = m.sup_code,
                UnderCounterCode = m.under_counter_code,
                LeaseBeginDate = m.lease_begin_date,
                LeaseEndDate = m.lease_end_date,
                RentalMoney = m.rental_money.Value,
                SaleMoney = m.sale_money.Value,
                FloorsMoney = m.floors_money.Value,
                RentRate = m.rent_rate.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static MsAdjustPoints C(this ms_adjust_points m)
        {
            return new MsAdjustPoints
            {
                Id = m.number_flow.ToInt32(),
                AdjustDate = m.adjust_date,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                MsName = m.ms_name,
                CardCode = m.card_code,
                CardName = m.card_name,
                CurrentPoints = m.current_points.Value,
                AdjustPoints = m.adjust_points.Value,
                SurplusPoints = m.surplus_points.Value,
                CurrentMoney = m.current_money.Value,
                AdjustMoney = m.adjust_money.Value,
                SurplusMoney = m.surplus_money.Value,
                IfModifyPw = m.if_modify_pw,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsCancelCardManage C(this ms_cancel_card_manage m)
        {
            return new MsCancelCardManage
            {
                Id = m.cancel_number,
                EnCode = m.en_code,
                CancelDate = m.cancel_date,
                CancelReason = m.cancel_reason,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsCardArchives C(this ms_card_archives m)
        {
            return new MsCardArchives
            {
                Id = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                MsName = m.ms_name,
                CardState = m.card_state,
                CreateDate = m.create_date,
                GrantDate = m.grant_date,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                TotalMoney = m.total_money.Value,
                TotalExpendTimes = m.total_expend_times.Value,
                LastExpendMoney = m.last_expend_money.Value,
                TotalPoints = m.total_points.Value,
                ExchangePoints = m.exchange_points.Value,
                CurrentPoints = m.current_points.Value,
                ClearPoints = m.clear_points.Value,
                PrepaidPassword = m.prepaid_password,
                TotalPrepaid = m.total_prepaid.Value,
                CurrentPrepaid = m.current_prepaid.Value,
                CurrentPrepaidEncrypt = m.current_prepaid_encrypt,
                UsePrepaid = m.use_prepaid.Value,
                LimitTimes = m.limit_times.Value,
                SaleTimes = m.sale_times.Value,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsCardtypeDiscount C(this ms_cardtype_discount m)
        {
            return new MsCardtypeDiscount
            {
                CardCode = m.card_code,
                GoodsClassCode = m.goods_class_code,
                GoodsClassName = m.goods_class_name,
                DiscountBase = m.discount_base.Value,
                ClassDiscountRate = m.class_discount_rate.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static MsCardtypeGoodsDiscount C(this ms_cardtype_goods_discount m)
        {
            return new MsCardtypeGoodsDiscount
            {
                CardCode = m.card_code,
                GoodsCode = m.goods_code,
                GoodsName = m.goods_name,
                DiscountBase = m.discount_base.Value,
                GoodsDiscountRate = m.goods_discount_rate.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static MsCardtypeGoodsPoints C(this ms_cardtype_goods_points m)
        {
            return new MsCardtypeGoodsPoints
            {
                CardCode = m.card_code,
                GoodsCode = m.goods_code,
                GoodsName = m.goods_name,
                ExpendBase = m.expend_base.Value,
                PointsValues = m.points_values.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static MsCardtypeManage C(this ms_cardtype_manage m)
        {
            return new MsCardtypeManage
            {
                Id = m.card_code,
                CardName = m.card_name,
                CardType = m.card_type,
                CardMedium = m.card_medium,
                CardUsefulLife = m.card_useful_life.Value,
                PointsUsefulLife = m.points_useful_life.Value,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                IfVip = m.if_vip,
                IfDiscount = m.if_discount,
                DiscountBase = m.discount_base.Value,
                DiscountRate = m.discount_rate.Value,
                IfPoints = m.if_points,
                ExpendBase = m.expend_base.Value,
                PointsValues = m.points_values.Value,
                BirthdayPoints = m.birthday_points.Value,
                IfPrepaid = m.if_prepaid,
                IfPrepaidPassword = m.if_prepaid_password,
                LimitTimes = m.limit_times.Value,
                PrestoreMoney = m.prestore_money.Value,
                PrestorePw = m.prestore_pw,
                PrepaidMin = m.prepaid_min.Value,
                PrepaidMax = m.prepaid_max.Value,
                IfPointToPrepaid = m.if_point_to_prepaid,
                PointsBase = m.points_base.Value,
                PrepaidMoney = m.prepaid_money.Value,
                CardNumberPrefix = m.card_number_prefix,
                CardNumberLen = m.card_number_len.Value,
                RandLen = m.rand_len.Value,
                UpgradeType = m.upgrade_type,
                PointsNeeds = m.points_needs.Value,
                IfDeductPoints = m.if_deduct_points,
                IfAutoup = m.if_autoup,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static MsCardtypePoints C(this ms_cardtype_points m)
        {
            return new MsCardtypePoints
            {
                CardCode = m.card_code,
                GoodsClassCode = m.goods_class_code,
                GoodsClassName = m.goods_class_name,
                ExpendBase = m.expend_base.Value,
                PointsValues = m.points_values.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static MsExchangeDetail C(this ms_exchange_detail m)
        {
            return new MsExchangeDetail
            {
                ExchangeNumber = m.exchange_number,
                sNumber = m.s_number.Value,
                GoodsCode = m.goods_code,
                GoodsName = m.goods_name,
                ExchangeQty = m.exchange_qty.Value,
                ExchangePoints = m.exchange_points.Value,
                PointsTotal = m.points_total.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static MsExchangeManage C(this ms_exchange_manage m)
        {
            return new MsExchangeManage
            {
                Id = m.ex_flow_number.ToInt32(),
                ExchangeNumber = m.exchange_number,
                ExchangeDate = m.exchange_date,
                CardNumber = m.card_number,
                MsCode = m.ms_code,
                MsName = m.ms_name,
                CurrentPoints = m.current_points.Value,
                ExchangePoints = m.exchange_points.Value,
                SurplusPoints = m.surplus_points.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsFreezeCardManage C(this ms_freeze_card_manage m)
        {
            return new MsFreezeCardManage
            {
                Id = m.freeze_number,
                EnCode = m.en_code,
                FreezeDate = m.freeze_date,
                FreezeReason = m.freeze_reason,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsGiftArchives C(this ms_gift_archives m)
        {
            return new MsGiftArchives
            {
                GoodsCode = m.goods_code,
                GoodsName = m.goods_name,
                ExchangePoints = m.exchange_points.Value,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                WhCode = m.wh_code,
                Operator = m.@operator,
                OperatorDate = m.@operator_date,
                Id = m.Id
            };
        }
        public static MsGrantCardManage C(this ms_grant_card_manage m)
        {
            return new MsGrantCardManage
            {
                Id = m.grant_number,
                EnCode = m.en_code,
                GrantDate = m.grant_date,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsLossCardManage C(this ms_loss_card_manage m)
        {
            return new MsLossCardManage
            {
                Id = m.loss_number,
                EnCode = m.en_code,
                LossDate = m.loss_date,
                LossType = m.loss_type,
                LossReason = m.loss_reason,
                LossPerson = m.loss_person,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsMadecardManage C(this ms_madecard_manage m)
        {
            return new MsMadecardManage
            {
                Id = m.md_number,
                MdDate = m.md_date,
                CardCode = m.card_code,
                BeginCardNumber = m.begin_card_number.Value,
                EndCardNumber = m.end_card_number.Value,
                MadeQty = m.made_qty.Value,
                EffectiveType = m.effective_type,
                EffectiveDate = m.effective_date,
                IfMade = m.if_made,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static MsMemberArchives C(this ms_member_archives m)
        {
            return new MsMemberArchives
            {
                CardNumber = m.card_number,
                Id = m.ms_code,
                MsName = m.ms_name,
                Birthday = m.birthday,
                Sex = m.sex,
                PoliticsCode = m.politics_code,
                NationCode = m.nation_code,
                EducationCode = m.education_code,
                ProfessionalTitleCode = m.Professional_title_code,
                IfMarried = m.if_married,
                NativePlace = m.native_place,
                Idcard = m.idcard,
                FamilyPhone = m.family_phone,
                Handset = m.handset,
                eMail = m.e_mail,
                FamilyAddress = m.family_address,
                Postalcode = m.postalcode,
                Stature = m.stature.Value,
                Width = m.width.Value
            };
        }
        public static MsPointsClear C(this ms_points_clear m)
        {
            return new MsPointsClear
            {
                Id = m.number_flow.ToInt32(),
                ClearDate = m.clear_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsPointtoprepaidManage C(this ms_pointtoprepaid_manage m)
        {
            return new MsPointtoprepaidManage
            {
                Id = m.number_flow.ToInt32(),
                ExchangeDate = m.exchange_date,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                MsName = m.ms_name,
                CardCode = m.card_code,
                CardName = m.card_name,
                CurrentPoints = m.current_points.Value,
                ExchangePoints = m.exchange_points.Value,
                SurplusPoints = m.surplus_points.Value,
                PrepaidMoney = m.prepaid_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsPrepaidCardManage C(this ms_prepaid_card_manage m)
        {
            return new MsPrepaidCardManage
            {
                Id = m.prepaid_number,
                EnCode = m.en_code,
                PrepaidDate = m.prepaid_date,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                PrepaidMoney = m.prepaid_money.Value,
                TotalPrepaid = m.total_prepaid.Value,
                CurrentPrepaid = m.current_prepaid.Value,
                UsePrepaid = m.use_prepaid.Value,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsReclaimCardManage C(this ms_reclaim_card_manage m)
        {
            return new MsReclaimCardManage
            {
                Id = m.reclaim_number,
                EnCode = m.en_code,
                ReclaimDate = m.reclaim_date,
                ReclaimReason = m.reclaim_reason,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static MsUpdateCardManage C(this ms_update_card_manage m)
        {
            return new MsUpdateCardManage
            {
                UpdateNumber = m.update_number,
                EnCode = m.en_code,
                UpdateDate = m.update_date,
                UpdateReason = m.update_reason,
                CardNumberOld = m.card_number_old,
                SurfaceNumberOld = m.surface_number_old,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                MsCode = m.ms_code,
                CardCode = m.card_code,
                CardName = m.card_name,
                CardState = m.card_state,
                EffectiveDate = m.effective_date,
                PointsUsefulLifeDate = m.points_useful_life_date,
                CardUsefulLifeDate = m.card_useful_life_date,
                TransactCharge = m.transact_charge.Value,
                DepositMoney = m.deposit_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date,
                Id = m.Id
            };
        }
        public static MsUpgradeCardDetail C(this ms_upgrade_card_detail m)
        {
            return new MsUpgradeCardDetail
            {
                UpgradeNumber = m.upgrade_number,
                CardNumber = m.card_number,
                SurfaceNumber = m.surface_number,
                CardCodeOld = m.card_code_old,
                CardNameOld = m.card_name_old,
                CardCode = m.card_code,
                CardName = m.card_name,
                DeductPoints = m.deduct_points.Value,
                TotalPoints = m.total_points.Value,
                ExchangePoints = m.exchange_points.Value,
                CurrentPoints = m.current_points.Value,
                ClearPoints = m.clear_points.Value,
                CardState = m.card_state,
                Id = m.Id
            };
        }
        public static MsUpgradeCardManage C(this ms_upgrade_card_manage m)
        {
            return new MsUpgradeCardManage
            {
                Id = m.upgrade_number,
                EnCode = m.en_code,
                UpgradeDate = m.upgrade_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                OperatorDate = m.@operator_date
            };
        }
        public static OpAdjustDetail C(this op_adjust_detail m)
        {
            return new OpAdjustDetail
            {
                AdjustNumber = m.adjust_number,
                GoodsCode = m.goods_code,
                AdjustQty = m.adjust_qty.Value,
                AdjustPrice = m.adjust_price.Value,
                NontaxAdjustPrice = m.nontax_adjust_price.Value,
                AdjustMoney = m.adjust_money.Value,
                NontaxAdjustMoney = m.nontax_adjust_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static OpAdjustManage C(this op_adjust_manage m)
        {
            return new OpAdjustManage
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                EnCode = m.en_code,
                AdjustType = m.adjust_type,
                AdjustOperat = m.adjust_operat,
                WhCode = m.wh_code,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpAdjustManageFlow C(this op_adjust_manage_flow m)
        {
            return new OpAdjustManageFlow
            {
                Id = m.ad_flow_number.ToInt32(),
                AdjustDate = m.adjust_date,
                EnCode = m.en_code,
                AdjustType = m.adjust_type,
                AdjustOperat = m.adjust_operat,
                WhCode = m.wh_code,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpAdjustPurchaseDetail C(this op_adjust_purchase_detail m)
        {
            return new OpAdjustPurchaseDetail
            {
                AdjustNumber = m.adjust_number,
                AdjustDate = m.adjust_date,
                WhCode = m.wh_code,
                BatchNumber = m.batch_number,
                PiNumber = m.pi_number,
                PutinDate = m.putin_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SupCode = m.sup_code,
                InputTax = m.input_tax.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                SalePrice = m.sale_price.Value,
                NontaxSalePrice = m.nontax_sale_price.Value,
                PurchaseQty = m.purchase_qty.Value,
                StockoutQty = m.stockout_qty.Value,
                StockQty = m.stock_qty.Value,
                AdjustQty = m.adjust_qty.Value,
                AdjustPrice = m.adjust_price.Value,
                AdjustDiff = m.adjust_diff.Value,
                AdjustMoney = m.adjust_money.Value,
                IfAblebalance = m.if_ablebalance,
                AdjustBaMoney = m.adjust_ba_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                ProduceDate = m.produce_date,
                Id = m.Id
            };
        }
        public static OpAdjustPurchaseManage C(this op_adjust_purchase_manage m)
        {
            return new OpAdjustPurchaseManage
            {
                Id = m.adjust_number,
                AdjustDate = m.adjust_date,
                EnCode = m.en_code,
                GoodsCode = m.goods_code,
                AdjustReason = m.adjust_reason,
                AdjustMoney = m.adjust_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpAllotDetail C(this op_allot_detail m)
        {
            return new OpAllotDetail
            {
                AlNumber = m.al_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                StockQty = m.stock_qty.Value,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                AllotQty = m.allot_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                AllotMoney = m.allot_money.Value,
                NontaxAllotMoney = m.nontax_allot_money.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                Id = m.Id
            };
        }
        public static OpAllotManage C(this op_allot_manage m)
        {
            return new OpAllotManage
            {
                Id = m.al_number,
                AlType = m.al_type,
                OrganOut = m.organ_out,
                OrganNameOut = m.organ_name_out,
                WhCodeOut = m.wh_code_out,
                OrganIn = m.organ_in,
                OrganNameIn = m.organ_name_in,
                WhCodeIn = m.wh_code_in,
                AlDate = m.al_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpAllotManageFlow C(this op_allot_manage_flow m)
        {
            return new OpAllotManageFlow
            {
                Id = m.al_flow_number.ToInt32(),
                AlType = m.al_type,
                OrganOut = m.organ_out,
                OrganNameOut = m.organ_name_out,
                WhCodeOut = m.wh_code_out,
                OrganIn = m.organ_in,
                OrganNameIn = m.organ_name_in,
                WhCodeIn = m.wh_code_in,
                AlDate = m.al_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpCheckDetail C(this op_check_detail m)
        {
            return new OpCheckDetail
            {
                Id = m.ck_flow_number.ToInt32(),
                CkNumber = m.ck_number,
                bCode = m.b_code,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                PurchasePrice = m.purchase_price,
                SalePrice = m.sale_price.Value,
                PackCoef = m.pack_coef.Value,
                PackQty = m.pack_qty.Value,
                CheckQty = m.check_qty.Value,
                StockQty = m.stock_qty.Value,
                Operator = m.@operator,
                SysGuid = m.sys_guid
            };
        }
        public static OpCheckManage C(this op_check_manage m)
        {
            return new OpCheckManage
            {
                Id = m.ck_number,
                CkDate = m.ck_date,
                CkType = m.ck_type,
                CkOrgan = m.ck_organ,
                WhCode = m.wh_code,
                CkArea = m.ck_area,
                IfTransfer = m.if_transfer,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpCheckStock C(this op_check_stock m)
        {
            return new OpCheckStock
            {
                CkNumber = m.ck_number,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                StockQty = m.stock_qty.Value,
                Id = m.Id
            };
        }
        public static OpCheckTransfer C(this op_check_transfer m)
        {
            return new OpCheckTransfer
            {
                Id = m.ck_flow_number.ToInt32(),
                bCode = m.b_code,
                WhCode = m.wh_code,
                //go= m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                PurchasePrice = m.purchase_price,
                SalePrice = m.sale_price.Value,
                PackCoef = m.pack_coef.Value,
                PackQty = m.pack_qty.Value,
                CheckQty = m.check_qty.Value,
                StockQty = m.stock_qty.Value,
                DifferQty = m.differ_qty.Value,
                SysGuid = m.sys_guid
            };
        }
        public static OpDynamicStock C(this op_dynamic_stock m)
        {
            return new OpDynamicStock
            {
                Id = m.goods_code,
                StockQty = m.stock_qty.Value,
                OrderQty = m.order_qty.Value,
                IfModify = m.if_modify.Value
            };
        }
        public static OpDynamicStockBranch C(this op_dynamic_stock_branch m)
        {
            return new OpDynamicStockBranch
            {
                EnCode = m.en_code,

                Id = m.b_code,
                StockQty = m.stock_qty
            };
        }
        public static OpDynamicStockWh C(this op_dynamic_stock_wh m)
        {
            return new OpDynamicStockWh
            {

                Id = m.en_code,
                StockQty = m.stock_qty.Value
            };
        }
        public static OpGoodsBatch C(this op_goods_batch m)
        {
            return new OpGoodsBatch
            {
                Id = m.ba_flow_number.ToInt32(),
                GoodsBarCode = m.goods_bar_code,
                SupCode = m.sup_code,
                OpCode = m.op_code,
                InputTax = m.input_tax.Value,
                PurchasePrice = m.purchase_price.Value,
                NontaxPurchasePrice = m.nontax_purchase_price.Value,
                SalePrice = m.sale_price.Value,
                NontaxSalePrice = m.nontax_sale_price.Value,
                PurchaseQty = m.purchase_qty.Value,
                StockoutQty = m.stockout_qty.Value,
                StockQty = m.stock_qty.Value,
                PiNumber = m.pi_number,
                PutinDate = m.putin_date,
                ProduceDate = m.produce_date,
                IfModify = m.if_modify.Value
            };
        }
        public static OpLossDetail C(this op_loss_detail m)
        {
            return new OpLossDetail
            {
                LoNumber = m.lo_number,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                PurchasePrice = m.purchase_price,
                SalePrice = m.sale_price.Value,
                StockQty = m.stock_qty.Value,
                DifferQty = m.differ_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                Id = m.Id
            };
        }
        public static OpLossManage C(this op_loss_manage m)
        {
            return new OpLossManage
            {
                Id = m.lo_number,
                LoDate = m.lo_date,
                CkNumber = m.ck_number,
                LoType = m.lo_type,
                LoOrgan = m.lo_organ,
                WhCode = m.wh_code,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpLossManageFlow C(this op_loss_manage_flow m)
        {
            return new OpLossManageFlow
            {
                Id = m.lo_flow_number.ToInt32(),
                LoDate = m.lo_date,
                CkNumber = m.ck_number,
                LoType = m.lo_type,
                LoOrgan = m.lo_organ,
                WhCode = m.wh_code,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpPaWarehouse C(this op_pa_warehouse m)
        {
            return new OpPaWarehouse
            {
                WhCode = m.wh_code,
                WhName = m.wh_name,
                WhArea = m.wh_area.Value,
                IfMainWh = m.if_main_wh,
                Id = m.Id
            };
        }
        public static OpSplitComDetail C(this op_split_com_detail m)
        {
            return new OpSplitComDetail
            {
                ScNumber = m.sc_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PurchaseQty = m.purchase_qty.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                SalePrice = m.sale_price.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                Id = m.Id
            };
        }
        public static OpSplitComGoods C(this op_split_com_goods m)
        {
            return new OpSplitComGoods
            {
                GoodsCode = m.goods_code,
                GoodsCodeChild = m.goods_code_child,
                GoodsQty = m.goods_qty.Value,
                Id = m.Id
            };
        }
        public static OpSplitComManage C(this op_split_com_manage m)
        {
            return new OpSplitComManage
            {
                Id = m.sc_number,
                ScDate = m.sc_date,
                ScType = m.sc_type,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                SalePrice = m.sale_price.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static OpSplitComManageFlow C(this op_split_com_manage_flow m)
        {
            return new OpSplitComManageFlow
            {
                Id = m.sc_flow_number.ToInt32(),
                ScDate = m.sc_date,
                ScType = m.sc_type,
                WhCode = m.wh_code,
                GoodsCode = m.goods_code,
                PurchaseQty = m.purchase_qty.Value,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                SalePrice = m.sale_price.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }

        public static PcPurchaseDetail C(this pc_purchase_detail m)
        {
            return new PcPurchaseDetail
            {
                PcNumber = m.pc_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                OfferMin = m.offer_min.Value,
                StockQty = m.stock_qty.Value,
                OrderQty = m.order_qty.Value,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                PurchaseQty = m.purchase_qty.Value,
                PutinQty = m.putin_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ProduceDate = m.produce_date,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static PcPurchaseManage C(this pc_purchase_manage m)
        {
            return new PcPurchaseManage
            {
                Id = m.pc_number,
                SupCode = m.sup_code,
                EnCode = m.en_code,
                PcForm = m.pc_form,
                dCode = m.d_code,
                bCode = m.b_code,
                PcType = m.pc_type,
                PcMode = m.pc_mode,
                WhCode = m.wh_code,
                PurchaseDate = m.purchase_date,
                ExpectArriveDate = m.expect_arrive_date,
                IfCheck = m.if_check,
                CheckDate = m.check_date,
                IfPutin = m.if_putin,
                PutinDate = m.putin_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date,
                SupName = m.sup_name,
                dName = m.d_name,
                bName = m.b_name
            };
        }
        public static PcPutinDetail C(this pc_putin_detail m)
        {
            return new PcPutinDetail
            {
                PiNumber = m.pi_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                OfferMin = m.offer_min.Value,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                PurchaseQty = m.purchase_qty.Value,
                PutinQty = m.putin_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                PurchaseMoney = m.purchase_money.Value,
                NontaxPurchaseMoney = m.nontax_purchase_money.Value,
                ProduceDate = m.produce_date,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static PcPutinManage C(this pc_putin_manage m)
        {
            return new PcPutinManage
            {
                Id = m.pi_flow_number.ToInt32(),
                SupCode = m.sup_code,
                EnCode = m.en_code,
                PcForm = m.pc_form,
                dCode = m.d_code,
                bCode = m.b_code,
                PcType = m.pc_type,
                PcMode = m.pc_mode,
                WhCode = m.wh_code,
                PurchaseDate = m.purchase_date,
                ExpectArriveDate = m.expect_arrive_date,
                CheckDate = m.check_date,
                PutinDate = m.putin_date,
                PutinMoney = m.putin_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static PcPutoutDetail C(this pc_putout_detail m)
        {
            return new PcPutoutDetail
            {
                PoNumber = m.po_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                ReturnQty = m.return_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static PcPutoutManage C(this pc_putout_manage m)
        {
            return new PcPutoutManage
            {
                Id = m.po_flow_number.ToInt32(),
                SupCode = m.sup_code,
                EnCode = m.en_code,
                PcForm = m.pc_form,
                dCode = m.d_code,
                bCode = m.b_code,
                WhCode = m.wh_code,
                ReturnDate = m.return_date,
                PutoutDate = m.putout_date,
                ReturnMoney = m.return_money.Value,
                IfAblebalance = m.if_ablebalance,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static PcReturnDetail C(this pc_return_detail m)
        {
            return new PcReturnDetail
            {
                RtNumber = m.rt_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                ReturnQty = m.return_qty.Value,
                SalePrice = m.sale_price.Value,
                PurchasePrice = m.purchase_price,
                NontaxPurchasePrice = m.nontax_purchase_price,
                ReturnMoney = m.return_money.Value,
                NontaxReturnMoney = m.nontax_return_money.Value,
                SaleMoney = m.sale_money.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static PcReturnManage C(this pc_return_manage m)
        {
            return new PcReturnManage
            {
                Id = m.rt_number,
                PcNumber = m.pc_number,
                SupCode = m.sup_code,
                EnCode = m.en_code,
                PcForm = m.pc_form,
                dCode = m.d_code,
                bCode = m.b_code,
                WhCode = m.wh_code,
                ReturnDate = m.return_date,
                IfPutout = m.if_putout,
                PutoutDate = m.putout_date,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static RtClassPromotion C(this rt_class_promotion m)
        {
            return new RtClassPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static RtClassPromotionBranch C(this rt_class_promotion_branch m)
        {
            return new RtClassPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static RtClassPromotionGoods C(this rt_class_promotion_goods m)
        {
            return new RtClassPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                GoodsClassCode = m.goods_class_code,
                GoodsClassName = m.goods_class_name,
                SaleDiscountRate = m.sale_discount_rate.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static RtPaFunction C(this rt_pa_function m)
        {
            return new RtPaFunction
            {
                Id = m.func_code,
                FuncName = m.func_name,
                FuncValue = m.func_value,
                IfAble = m.if_able
            };
        }
        public static RtPaPayway C(this rt_pa_payway m)
        {
            return new RtPaPayway
            {
                Id = m.payway_code,
                PaywayName = m.payway_name,
                PaywaySubCode = m.payway_sub_code,
                PaywayType = m.payway_type,
                ExRate = m.ex_rate.Value,
                IfChange = m.if_change
            };
        }
        public static RtPaPos C(this rt_pa_pos m)
        {
            return new RtPaPos
            {
                Id = m.posid,
                PosName = m.pos_name,
                PosIp = m.pos_ip,
                PosState = m.pos_state,
                WhCode = m.wh_code,
                CdType = m.cd_type,
                CdPort = m.cd_port,
                pType = m.p_type,
                pPort = m.p_port,
                pWidth = m.p_width.Value,
                pType1 = m.p_type1,
                pPort1 = m.p_port1,
                pWidth1 = m.p_width1.Value,
                CbType = m.cb_type,
                CbPort = m.cb_port
            };
        }
        public static RtPaSaleset C(this rt_pa_saleset m)
        {
            return new RtPaSaleset
            {
                Mantissa = m.mantissa.Value,
                MantissaMode = m.mantissa_mode,
                IfReturnSale = m.if_return_sale,
                IfNegativeStock = m.if_negative_stock,
                IfReturnPayway = m.if_return_payway,
                IfSalesman = m.if_salesman,
                IfCounter = m.if_counter,
                PrintType = m.print_type,
                IfBind = m.if_bind,
                IfEntertopay = m.if_entertopay,
                IfEntertormb = m.if_entertormb,
                IfEnglishSale = m.if_english_sale,
                Title1 = m.title1,
                Title2 = m.title2,
                Title3 = m.title3,
                Title4 = m.title4,
                Title5 = m.title5,
                Pagefoot1 = m.pagefoot1,
                Pagefoot2 = m.pagefoot2,
                Pagefoot3 = m.pagefoot3,
                Pagefoot4 = m.pagefoot4,
                Pagefoot5 = m.pagefoot5,
                IfEnName = m.if_en_name,
                IfbName = m.if_b_name,
                IfGoodsCode = m.if_goods_code,
                IfGoodsBarCode = m.if_goods_bar_code,
                IfGoodsName = m.if_goods_name,
                IfGoodsSubName = m.if_goods_sub_name,
                IfPackUnit = m.if_pack_unit,
                IfPrepaid = m.if_prepaid,
                Id = m.Id
            };
        }
        public static RtPaShift C(this rt_pa_shift m)
        {
            return new RtPaShift
            {
                Id = m.shift_code,
                ShiftName = m.shift_name,
                BeginDate = m.begin_date,
                EndDate = m.end_date
            };
        }
        public static RtPluPromotion C(this rt_plu_promotion m)
        {
            return new RtPluPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static RtPluPromotionBranch C(this rt_plu_promotion_branch m)
        {
            return new RtPluPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static RtPluPromotionGoods C(this rt_plu_promotion_goods m)
        {
            return new RtPluPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                IfSalePrice = m.if_sale_price,
                SalePriceOld = m.sale_price_old.Value,
                SalePriceDiscount = m.sale_price_discount.Value,
                SalePrice = m.sale_price.Value,
                IfLimit = m.if_limit,
                TotalLimit = m.total_limit.Value,
                TotalLimitSale = m.total_limit_sale.Value,
                DayLimit = m.day_limit.Value,
                DayLimitDate = m.day_limit_date,
                DayLimitSale = m.day_limit_sale.Value,
                SheetLimit = m.sheet_limit.Value,
                IfPool = m.if_pool,
                PoolRateOld = m.pool_rate_old.Value,
                PoolRate = m.pool_rate.Value,
                IfVip = m.if_vip,
                VipPriceOld = m.vip_price_old.Value,
                VipPrice = m.vip_price.Value,
                VipSheetLimit = m.vip_sheet_limit.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static RtPresentPromotion C(this rt_present_promotion m)
        {
            return new RtPresentPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static RtPresentPromotionBranch C(this rt_present_promotion_branch m)
        {
            return new RtPresentPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static RtPresentPromotionGoods C(this rt_present_promotion_goods m)
        {
            return new RtPresentPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                GoodsBarCode = m.goods_bar_code,
                GoodsCode = m.goods_code,
                SaleQty = m.sale_qty.Value,
                SalePrice = m.sale_price.Value,
                GoodsBarCodePresent = m.goods_bar_code_present,
                GoodsCodePresent = m.goods_code_present,
                PresentQty = m.present_qty.Value,
                PresentMoney = m.present_money.Value,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static RtRetailDetail C(this rt_retail_detail m)
        {
            return new RtRetailDetail
            {
                Id = m.sa_flow_number.ToInt32(),
                RtNumber = m.rt_number,
                sNumber = m.s_number,
                RtDate = m.rt_date,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                bCode = m.b_code,
                Posid = m.posid,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                SalePrice = m.sale_price.Value,
                RealPrice = m.real_price.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                PurchaseQty = m.purchase_qty.Value,
                pSalePrice = m.p_sale_price.Value,
                pSaleMoney = m.p_sale_money.Value,
                pDiscountMoney = m.p_discount_money.Value,
                Cashier = m.cashier,
                Salesman = m.salesman,
                UnderCounterCode = m.under_counter_code,
                PoolRate = m.pool_rate.Value,
                ShiftDate = m.shift_date,
                IfPromotion = m.if_promotion,
                OwnerType = m.owner_type,
                SysGuid = m.sys_guid
            };
        }
        public static RtRetailLog C(this rt_retail_log m)
        {
            return new RtRetailLog
            {
                Id = m.sa_flow_number.ToInt32(),
                Cashier = m.cashier,
                EmName = m.em_name,
                OperatType = m.operat_type,
                RtDate = m.rt_date,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                GoodsBarName = m.goods_bar_name,
                RealPrice = m.real_price.Value,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value
            };
        }
        public static RtRetailManage C(this rt_retail_manage m)
        {
            return new RtRetailManage
            {
                Id = m.sa_flow_number.ToInt32(),
                RtDate = m.rt_date,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                Posid = m.posid,
                SaleQty = m.sale_qty.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                CardNumber = m.card_number,
                Cashier = m.cashier,
                CashierHigher = m.cashier_higher,
                Salesman = m.salesman,
                UnderCounterCode = m.under_counter_code,
                ShiftDate = m.shift_date,
                ReturnNumber = m.return_number,
                Comment = m.comment,
                SysGuid = m.sys_guid
            };
        }
        public static RtRetailPay C(this rt_retail_pay m)
        {
            return new RtRetailPay
            {
                Id = m.sa_flow_number.ToInt32(),
                RtNumber = m.rt_number,
                sNumber = m.s_number,
                RtDate = m.rt_date,
                RtType = m.rt_type,
                WhCode = m.wh_code,
                bCode = m.b_code,
                Posid = m.posid,
                PaywayCode = m.payway_code,
                SaleMoney = m.sale_money.Value,
                ExRate = m.ex_rate.Value,
                PayMoney = m.pay_money.Value,
                PayLoss = m.pay_loss.Value,
                BankcardNumber = m.bankcard_number,
                CardNumber = m.card_number,
                Cashier = m.cashier,
                Salesman = m.salesman,
                UnderCounterCode = m.under_counter_code,
                ShiftDate = m.shift_date,
                SysGuid = m.sys_guid
            };
        }
        public static RtSheetPromotion C(this rt_sheet_promotion m)
        {
            return new RtSheetPromotion
            {
                Id = m.sp_number,
                EnCode = m.en_code,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                AdjustReason = m.adjust_reason,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static RtSheetPromotionBranch C(this rt_sheet_promotion_branch m)
        {
            return new RtSheetPromotionBranch
            {
                SpNumber = m.sp_number,
                bCode = m.b_code,
                Id = m.Id
            };
        }
        public static RtSheetPromotionGoods C(this rt_sheet_promotion_goods m)
        {
            return new RtSheetPromotionGoods
            {
                SpNumber = m.sp_number,
                SpBeginDate = m.sp_begin_date,
                SpEndDate = m.sp_end_date,
                SpBeginTime = m.sp_begin_time,
                SpEndTime = m.sp_end_time,
                SpW1 = m.sp_w1,
                SpW2 = m.sp_w2,
                SpW3 = m.sp_w3,
                SpW4 = m.sp_w4,
                SpW5 = m.sp_w5,
                SpW6 = m.sp_w6,
                SpW7 = m.sp_w7,
                SaleMoney = m.sale_money.Value,
                SaleDiscountRate = m.sale_discount_rate.Value,
                Comment = m.comment,
                SysGuid = m.sys_guid,
                Id = m.Id
            };
        }
        public static SysClassPower C(this sys_class_power m)
        {
            return new SysClassPower
            {
                EmCode = m.em_code,
                ClassCode = m.class_code,
                Id = m.Id
            };
        }
        public static SysDepartPower C(this sys_depart_power m)
        {
            return new SysDepartPower
            {
                dCode = m.d_code,
                WindowName = m.window_name,
                FunctionCode = m.function_code,
                Selection = m.selection,
                ModuleCode = m.module_code,
                ModuleName = m.module_name,
                ModuleChild = m.module_child,
                Id = m.Id
            };
        }
        public static SysEnterpriseArchives C(this sys_enterprise_archives m)
        {
            return new SysEnterpriseArchives
            {
                EnCode = m.en_code,
                EnName = m.en_name,
                EnComName = m.en_com_name,
                EnType = m.en_type,
                EnCharacter = m.en_character,
                DealArea = m.deal_area.Value,
                RegisterAddress = m.register_address,
                CurrentVersion = m.current_version,
                LastVersion = m.last_version,
                Id = m.Id
            };
        }
        public static SysLoginPower C(this sys_login_power m)
        {
            return new SysLoginPower
            {
                Id = m.em_code,
                EmName = m.em_name,
                UserName = m.user_name,
                UserPw = m.user_pw,
                IfCash = m.if_cash,
                CashFunction = m.cash_function,
                UserState = m.user_state,
                MaxDiscount = m.max_discount.Value
            };
        }
        public static SysLoginPowerFunction C(this sys_login_power_function m)
        {
            return new SysLoginPowerFunction
            {
                Id = m.em_code,
                IfAble = m.if_able
            };
        }
        public static SysModule C(this sys_module m)
        {
            return new SysModule
            {
                WindowCode = m.window_code,
                Id = m.window_name,
                ModuleCode = m.module_code,
                ModuleName = m.module_name,
                ModuleChild = m.module_child,
                OpenMode = m.open_mode
            };
        }
        public static SysModuleContent C(this sys_module_content m)
        {
            return new SysModuleContent
            {
                WindowName = m.window_name,
                ColumnCode = m.column_code,
                OpenWindowName = m.open_window_name,
                Id = m.Id
            };
        }
        public static SysModulePic C(this sys_module_pic m)
        {
            return new SysModulePic
            {
                ModuleCode = m.module_code,
                ModuleName = m.module_name,
                PicName = m.pic_name,
                Id = m.Id
            };
        }
        public static SysOperationFlow C(this sys_operation_flow m)
        {
            return new SysOperationFlow
            {
                Id = m.operation_name,
                WindowName = m.window_name,
                FunctionCode = m.function_code,
                TurnsNumber = m.turn_s_number,
                Operation = m.operation,
                Condition = m.condition,
                Content = m.content.Value,
                Statement = m.statement
            };
        }
        public static SysOperationFlowDetail C(this sys_operation_flow_detail m)
        {
            return new SysOperationFlowDetail
            {
                Id = m.operation_number,
                OperationName = m.operation_name,
                WindowName = m.window_name,
                CurrentsNumber = m.current_s_number,
                FunctionCode = m.function_code,
                CurrentFunctionCode = m.current_function_code,
                ColumnName = m.column_name,
                NextsNumber = m.next_s_number,
                CurrentState = m.current_state,
                OperationState = m.operation_state,
                OperationResult = m.operation_result,
                OperationOpinion = m.operation_opinion,
                Operator = m.@operator,
                OperatorDate = m.@operator_date,
                Statement = m.statement,
                StatementState = m.statement_state
            };
        }
        public static SysOperationFlowDetailMax C(this sys_operation_flow_detail_max m)
        {
            return new SysOperationFlowDetailMax
            {
                OperationNumber = m.operation_number,
                Id = m.Id
            };
        }
        public static SysOperationWorker C(this sys_operation_worker m)
        {
            return new SysOperationWorker
            {
                OperationName = m.operation_name,
                sNumber = m.s_number,
                EmCode = m.em_code,
                Id = m.Id
            };
        }
        public static SysPaDepartment C(this sys_pa_department m)
        {
            return new SysPaDepartment
            {
                Id = m.d_code,
                dName = m.d_name,
                Higher = m.higher
            };
        }
        public static SysPrintDesign C(this sys_print_design m)
        {
            return new SysPrintDesign
            {
                DwObject = m.dw_object,
                TemplateName = m.template_name,
                IfMain = m.if_main,
                DataObject = m.data_object,
                ObContent = m.ob_content,
                ObFontFace = m.ob_font_face,
                ObFontHeight = m.ob_font_height.Value,
                ObFontWeight = m.ob_font_weight.Value,
                ObFontItalic = m.ob_font_italic,
                ObFontUnderline = m.ob_font_underline,
                ObColor = m.ob_color.Value,
                IfVisible = m.if_visible,
                Obx = m.ob_x.Value,
                Oby = m.ob_y.Value,
                ObWidth = m.ob_width.Value,
                ObHeight = m.ob_height.Value,
                Id = m.Id
            };
        }

        public static SysWorkerPower C(this sys_worker_power m)
        {
            return new SysWorkerPower
            {
                EmCode = m.em_code,
                WindowName = m.window_name,
                FunctionCode = m.function_code,
                Selection = m.selection,
                ModuleCode = m.module_code,
                ModuleName = m.module_name,
                ModuleChild = m.module_child,
                Id = m.Id
            };
        }
        public static TfDataDownload C(this tf_data_download m)
        {
            return new TfDataDownload
            {
                Id = m.download_id,
                DownloadTablename = m.download_tablename,
                DownloadBranchcode = m.download_branchcode,
                DownloadKeyvalue = m.download_keyvalue
            };
        }
        public static TfDataObject C(this tf_data_object m)
        {
            return new TfDataObject
            {
                ObjectId = m.object_id,
                ObjectName = m.object_name,
                ObjectMain = m.object_main,
                ObjectMaincolumn = m.object_maincolumn,
                ObjectForeigncolumn = m.object_foreigncolumn,
                ObjectIsinsert = m.object_isinsert.Value,
                ObjectIsdelete = m.object_isdelete.Value,
                ObjectIsupdate = m.object_isupdate.Value,
                ObjectDump = m.object_dump,
                ObjectKeycolumn = m.object_keycolumn,
                ObjectBranchcodecolumn = m.object_branchcodecolumn,
                ObjectIsdeletedump = m.object_isdeletedump.Value,
                ObjectDescription = m.object_description,
                ObjectDirection = m.object_direction,
                ObjectIstransfer = m.object_istransfer.Value,
                ObjectCondition = m.object_condition,
                ObjectOrder = m.object_order.Value,
                Id = m.Id
            };
        }
        public static TfDataProperty C(this tf_data_property m)
        {
            return new TfDataProperty
            {
                PropertyId = m.property_id,
                PropertyObject = m.property_object,
                PropertyName = m.property_name,
                PropertyType = m.property_type,
                PropertyIskey = m.property_iskey.Value,
                PropertyIsnullable = m.property_isnullable.Value,
                PropertyIsunqueindex = m.property_isunqueindex.Value,
                PropertyIstransfer = m.property_istransfer.Value,
                PropertyDescription = m.property_description,
                PropertyCondition = m.property_condition,
                Id = m.Id
            };
        }
        public static TgExpostorBalance C(this tg_expostor_balance m)
        {
            return new TgExpostorBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                PaywayCode = m.payway_code,
                ExpostorCode = m.expostor_code,
                ExpostorName = m.expostor_name,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static TgExpostorBalanceDetail C(this tg_expostor_balance_detail m)
        {
            return new TgExpostorBalanceDetail
            {
                BaNumber = m.ba_number,
                GroupNumber = m.group_number,
                sNumber = m.s_number,
                SaleDate = m.sale_date,
                SaleMoney = m.sale_money.Value,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value,
                PtimesMoney = m.ptimes_money.Value,
                TotalPushMoney = m.total_push_money.Value,
                Id = m.Id
            };
        }
        public static TgGroupBalance C(this tg_group_balance m)
        {
            return new TgGroupBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                PaywayCode = m.payway_code,
                EnCode = m.en_code,
                BeginDate = m.begin_date,
                EndDate = m.end_date,
                GroupNumber = m.group_number,
                TaCode = m.ta_code,
                PersonTimes = m.person_times.Value,
                SaleMoney = m.sale_money.Value,
                PushMoney = m.push_money.Value,
                AdjustMoney = m.adjust_money.Value,
                TaReturnsMoney = m.ta_returns_money.Value,
                GuideCode = m.guide_code,
                ContactPhone = m.contact_phone,
                GuidePushMoney = m.guide_push_money.Value,
                Expostor = m.expostor,
                ExpostorPushMoney = m.expostor_push_money.Value,
                Driver = m.driver,
                StopCharge = m.stop_charge.Value,
                NopayMoney = m.nopay_money.Value,
                RebalanceCause = m.rebalance_cause,
                IfBalance = m.if_balance,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static TgGroupBalanceDetail C(this tg_group_balance_detail m)
        {
            return new TgGroupBalanceDetail
            {
                BaNumber = m.ba_number,
                sNumber = m.s_number,
                BaItems = m.ba_items,
                GroupNumber = m.group_number,
                GuideCode = m.guide_code,
                GuideName = m.guide_name,
                GbCode = m.gb_code,
                SaleMoney = m.sale_money.Value,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value,
                PtimesMoney = m.ptimes_money.Value,
                TotalPushMoney = m.total_push_money.Value,
                BaState = m.ba_state,
                BaType = m.ba_type,
                IfBalance = m.if_balance,
                IfPrint = m.if_print,
                Id = m.Id
            };
        }
        public static TgGroupCall C(this tg_group_call m)
        {
            return new TgGroupCall
            {
                Id = m.tg_flow_number.ToInt32(),
                CallType = m.call_type,
                ItemsCode = m.items_code,
                ItemsName = m.items_name,
                CallContent = m.call_content
            };
        }
        public static TgGuideArchives C(this tg_guide_archives m)
        {
            return new TgGuideArchives
            {
                Id = m.tg_flow_number.ToInt32(),
                GuideName = m.guide_name,
                PyCode = m.py_code,
                GuideType = m.guide_type,
                GuideId = m.guide_id,
                ContactPhone = m.contact_phone,
                TaCode = m.ta_code,
                TaName = m.ta_name,
                TacCode = m.tac_code,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value,
                LicensePlate = m.license_plate,
                Comment = m.comment
            };
        }
        public static TgGuideBalance C(this tg_guide_balance m)
        {
            return new TgGuideBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                PaywayCode = m.payway_code,
                GuideCode = m.guide_code,
                GuideName = m.guide_name,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static TgGuideBalanceDetail C(this tg_guide_balance_detail m)
        {
            return new TgGuideBalanceDetail
            {
                BaNumber = m.ba_number,
                sNumber = m.s_number,
                BaNopayNumber = m.ba_nopay_number,
                GroupNumber = m.group_number,
                SaleDate = m.sale_date,
                BaItems = m.ba_items,
                GbCode = m.gb_code,
                TaCode = m.ta_code,
                SaleMoney = m.sale_money.Value,
                PushMoney = m.push_money.Value,
                AdjustMoney = m.adjust_money.Value,
                TotalPushMoney = m.total_push_money.Value,
                Id = m.Id
            };
        }
        public static TgPaCarsCharge C(this tg_pa_cars_charge m)
        {
            return new TgPaCarsCharge
            {
                CarsTypeCode = m.cars_type_code,
                PersonLower = m.person_lower.Value,
                PersonUpper = m.person_upper.Value,
                StopCharge = m.stop_charge.Value,
                Id = m.Id
            };
        }
        public static TgPaCarsType C(this tg_pa_cars_type m)
        {
            return new TgPaCarsType
            {
                CarsTypeCode = m.cars_type_code,
                CarsTypeName = m.cars_type_name,
                StopCharge = m.stop_charge.Value,
                Id = m.Id
            };
        }
        public static TgPaGroup C(this tg_pa_group m)
        {
            return new TgPaGroup
            {
                GroupDate = m.group_date,
                GroupNumber = m.group_number,
                GbCode = m.gb_code,
                LastRtFlowNumber = m.last_rt_flow_number.Value,
                CurrentRtFlowNumber = m.current_rt_flow_number.Value,
                Id = m.Id
            };
        }
        public static TgPaGroupType C(this tg_pa_group_type m)
        {
            return new TgPaGroupType
            {
                GroupTypeCode = m.group_type_code,
                GroupTypeName = m.group_type_name,
                Id = m.Id
            };
        }
        public static TgPaTaType C(this tg_pa_ta_type m)
        {
            return new TgPaTaType
            {
                Id = m.ta_type_code,
                TaTypeName = m.ta_type_name
            };
        }
        public static TgPushtacDetail C(this tg_pushtac_detail m)
        {
            return new TgPushtacDetail
            {
                TacCode = m.tac_code,
                GoodsClassCode = m.goods_class_code,
                GoodsClassName = m.goods_class_name,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value,
                Id = m.Id
            };
        }
        public static TgPushtacManage C(this tg_pushtac_manage m)
        {
            return new TgPushtacManage
            {
                Id = m.tac_code,
                TacName = m.tac_name,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value
            };
        }
        public static TgTourgroupManage C(this tg_tourgroup_manage m)
        {
            return new TgTourgroupManage
            {
                Id = m.tg_flow_number.ToInt32(),
                GroupNumber = m.group_number,
                GroupDate = m.group_date,
                GroupTypeCode = m.group_type_code,
                TaCode = m.ta_code,
                TaName = m.ta_name,
                TaTypeCode = m.ta_type_code,
                GuideCode = m.guide_code,
                GuideName = m.guide_name,
                GuideTacCode = m.guide_tac_code,
                GuidePushRate = m.guide_push_rate.Value,
                GuidePushMoney = m.guide_push_money.Value,
                PersonTimes = m.person_times.Value,
                DiscountRate = m.discount_rate.Value,
                ExpostorTacCode = m.expostor_tac_code,
                Expostor = m.expostor,
                ExpostorPushRate = m.expostor_push_rate.Value,
                ExpostorPushMoney = m.expostor_push_money.Value,
                Driver = m.driver,
                LicensePlate = m.license_plate,
                CarsGroup = m.cars_group,
                CarsTypeCode = m.cars_type_code,
                StopCharge = m.stop_charge.Value,
                CustomerFrom = m.customer_from,
                Comment = m.comment,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static TgTravelArchives C(this tg_travel_archives m)
        {
            return new TgTravelArchives
            {
                Id = m.ta_code,
                TaName = m.ta_name,
                PyCode = m.py_code,
                TaTypeCode = m.ta_type_code,
                PushRate = m.push_rate.Value,
                PushMoney = m.push_money.Value,
                PushMoneyAccount = m.push_money_account.Value,
                TaReturnsRate = m.ta_returns_rate.Value,
                Functionary = m.functionary,
                FunctionaryPhone = m.functionary_phone,
                Linkman = m.linkman,
                ContactPhone = m.contact_phone,
                ContactAddress = m.contact_address,
                OfficePhone = m.office_phone,
                FaxPhone = m.fax_phone,
                eMail = m.e_mail,
                Postalcode = m.postalcode,
                OpenAccount = m.open_account,
                BankAccount = m.bank_account,
                TaxNumber = m.tax_number,
                PrintType = m.print_type,
                IfPrint = m.if_print,
                CarsType = m.cars_type,
                Comment = m.comment
            };
        }
        public static TgTravelArchivesPushtac C(this tg_travel_archives_pushtac m)
        {
            return new TgTravelArchivesPushtac
            {
                TaCode = m.ta_code,
                GoodsClassCode = m.goods_class_code,
                GoodsClassName = m.goods_class_name,
                PushRate = m.push_rate.Value,
                AccountRate = m.account_rate.Value,
                Id = m.Id
            };
        }
        public static TgTravelBalance C(this tg_travel_balance m)
        {
            return new TgTravelBalance
            {
                Id = m.ba_number,
                BaDate = m.ba_date,
                EnCode = m.en_code,
                PaywayCode = m.payway_code,
                TaCode = m.ta_code,
                TaName = m.ta_name,
                BalanceMoney = m.balance_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static TgTravelBalanceDetail C(this tg_travel_balance_detail m)
        {
            return new TgTravelBalanceDetail
            {
                BaNumber = m.ba_number,
                sNumber = m.s_number,
                BaNopayNumber = m.ba_nopay_number,
                GroupNumber = m.group_number,
                SaleDate = m.sale_date,
                BaItems = m.ba_items,
                GbCode = m.gb_code,
                GuideCode = m.guide_code,
                SaleMoney = m.sale_money.Value,
                PushMoney = m.push_money.Value,
                AdjustMoney = m.adjust_money.Value,
                TotalPushMoney = m.total_push_money.Value,
                Id = m.Id
            };
        }
        public static WsCustomerArchives C(this ws_customer_archives m)
        {
            return new WsCustomerArchives
            {
                Id = m.cust_code,
                CustName = m.cust_name,
                PyCode = m.py_code,
                CustTypeCode = m.cust_type_code,
                Linkman = m.linkman,
                ContactPhone = m.contact_phone,
                ContactAddress = m.contact_address,
                OfficePhone = m.office_phone,
                FaxPhone = m.fax_phone,
                eMail = m.e_mail,
                Postalcode = m.postalcode,
                OpenAccount = m.open_account,
                BankAccount = m.bank_account,
                TaxNumber = m.tax_number,
                PayMode = m.pay_mode,
                BalanceMode = m.balance_mode,
                BalancePeriod = m.balance_period,
                BalanceDay = m.balance_day.Value,
                SalePeriod = m.sale_period,
                Comment = m.comment,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static WsCustomerGoods C(this ws_customer_goods m)
        {
            return new WsCustomerGoods
            {
                CustCode = m.cust_code,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                TradePrice = m.trade_price.Value,
                Id = m.Id
            };
        }
        public static WsOrderDetail C(this ws_order_detail m)
        {
            return new WsOrderDetail
            {
                OrderNumber = m.order_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                ReturnQty = m.return_qty.Value,
                TradePrice = m.trade_price.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                Id = m.Id
            };
        }
        public static WsOrderManage C(this ws_order_manage m)
        {
            return new WsOrderManage
            {
                Id = m.order_number,
                OrderDate = m.order_date,
                CustCode = m.cust_code,
                WsOrgan = m.ws_organ,
                WhCode = m.wh_code,
                Salesman = m.salesman,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static WsPaCustomerType C(this ws_pa_customer_type m)
        {
            return new WsPaCustomerType
            {
                CustTypeCode = m.cust_type_code,
                CustTypeName = m.cust_type_name,
                WsType = m.ws_type,
                DiscountRate = m.discount_rate.Value,
                Id = m.Id
            };
        }
        public static WsWholesaleDetail C(this ws_wholesale_detail m)
        {
            return new WsWholesaleDetail
            {
                WsNumber = m.ws_number,
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Specification = m.specification,
                PackUnitCode = m.pack_unit_code,
                PackQty = m.pack_qty.Value,
                PackCoef = m.pack_coef.Value,
                SaleQty = m.sale_qty.Value,
                TradePrice = m.trade_price.Value,
                SaleMoney = m.sale_money.Value,
                DiscountMoney = m.discount_money.Value,
                NontaxSalePrice = m.nontax_sale_price.Value,
                NontaxSaleMoney = m.nontax_sale_money.Value,
                CostMoney = m.cost_money.Value,
                NontaxCostMoney = m.nontax_cost_money.Value,
                GrossMoney = m.gross_money.Value,
                NontaxGrossMoney = m.nontax_gross_money.Value,
                SaleType = m.sale_type,
                Id = m.Id
            };
        }
        public static WsWholesaleGoodsSet C(this ws_wholesale_goods_set m)
        {
            return new WsWholesaleGoodsSet
            {
                GoodsCode = m.goods_code,
                GoodsBarCode = m.goods_bar_code,
                Id = m.Id
            };
        }
        public static WsWholesaleManage C(this ws_wholesale_manage m)
        {
            return new WsWholesaleManage
            {
                Id = m.ws_number,
                WsDate = m.ws_date,
                OrderNumber = m.order_number,
                CustCode = m.cust_code,
                WsType = m.ws_type,
                WsOrgan = m.ws_organ,
                PayMode = m.pay_mode,
                PayDate = m.pay_date,
                WhCode = m.wh_code,
                Salesman = m.salesman,
                Comment = m.comment,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }
        public static WsWholesaleManageFlow C(this ws_wholesale_manage_flow m)
        {
            return new WsWholesaleManageFlow
            {
                Id = m.ws_flow_number.ToInt32(),
                WsNumber = m.ws_number,
                WsDate = m.ws_date,
                OrderNumber = m.order_number,
                CustCode = m.cust_code,
                WsType = m.ws_type,
                WsOrgan = m.ws_organ,
                PayMode = m.pay_mode,
                PayDate = m.pay_date,
                WhCode = m.wh_code,
                Salesman = m.salesman,
                Comment = m.comment,
                WsMoney = m.ws_money.Value,
                IfBalance = m.if_balance,
                BaNumber = m.ba_number,
                BaMoney = m.ba_money.Value,
                CreateDate = m.create_date,
                Operator = m.@operator,
                Assessor = m.assessor,
                IfExamine = m.if_examine,
                ExamineDate = m.examine_date,
                OperatorDate = m.@operator_date
            };
        }



        public static ac_branch_goodssale_account D(this AcBranchGoodssaleAccount m)
        {
            return new ac_branch_goodssale_account
            {
                rt_flow_number = m.Id,
                en_code = m.EnCode,
                b_code = m.bCode,
                wh_code = m.WhCode,
                rt_date = m.RtDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                op_code = m.OpCode,
                sale_price = m.SalePrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                cost_money = m.CostMoney,
                nontax_cost_money = m.NontaxCostMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                sup_code = m.SupCode,
                pool_rate = m.PoolRate,
                output_tax = m.OutputTax,
                if_promotion = m.IfPromotion
            };
        }
        public static ac_cashier_summary D(this AcCashierSummary m)
        {
            return new ac_cashier_summary
            {
                rt_flow_number = m.Id,
                rt_date = m.RtDate,
                cashier = m.Cashier,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.bCode,
                payway_code = m.PaywayCode,
                sale_money = m.SaleMoney,
                ex_rate = m.ExRate,
                pay_money = m.PayMoney,
                pay_loss = m.PayLoss
            };
        }
        public static ac_counter_summary D(this AcCounterSummary m)
        {
            return new ac_counter_summary
            {
                rt_flow_number = m.Id,
                rt_date = m.RtDate,
                under_counter_code = m.UnderCounterCode,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.bCode,
                payway_code = m.PaywayCode,
                sale_money = m.SaleMoney,
                ex_rate = m.ExRate,
                pay_money = m.PayMoney,
                pay_loss = m.PayLoss
            };
        }
        public static ac_day_branchclass_journal_account D(this AcDayBranchclassJournalAccount m)
        {
            return new ac_day_branchclass_journal_account
            {
                ac_flow_number = m.Id,
                ac_date = m.AcDate,
                b_code = m.bCode,
                goods_class_code = m.GoodsClassCode,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                supply_qty = m.SupplyQty,
                supply_money = m.SupplyMoney,
                nontax_supply_money = m.NontaxSupplyMoney,
                sp_return_qty = m.SpReturnQty,
                sp_return_money = m.SpReturnMoney,
                nontax_sp_return_money = m.NontaxSpReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney
            };
        }
        public static ac_day_branchgoods_journal_account D(this AcDayBranchgoodsJournalAccount m)
        {
            return new ac_day_branchgoods_journal_account
            {
                ac_flow_number = m.Id,
                ac_date = m.AcDate,
                b_code = m.bCode,
                goods_code = m.GoodsCode,
                op_code = m.OpCode,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                supply_qty = m.SupplyQty,
                supply_money = m.SupplyMoney,
                nontax_supply_money = m.NontaxSupplyMoney,
                sp_return_qty = m.SpReturnQty,
                sp_return_money = m.SpReturnMoney,
                nontax_sp_return_money = m.NontaxSpReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney,
                sup_code = m.SupCode
            };
        }
        public static ac_day_class_journal_account D(this AcDayClassJournalAccount m)
        {
            return new ac_day_class_journal_account
            {
                ac_flow_number = m.Id,
                ac_date = m.AcDate,
                goods_class_code = m.GoodsClassCode,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney
            };
        }
        public static ac_day_goods_journal_account D(this AcDayGoodsJournalAccount m)
        {
            return new ac_day_goods_journal_account
            {
                ac_flow_number = m.Id,
                ac_date = m.AcDate,
                goods_code = m.GoodsCode,
                op_code = m.OpCode,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_qty = m.AdjustQty,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney,
                sup_code = m.SupCode
            };
        }
        public static ac_day_goods_journal_account_temp D(this AcDayGoodsJournalAccountTemp m)
        {
            return new ac_day_goods_journal_account_temp
            {
                ac_date = m.AcDate,
                goods_code = m.GoodsCode,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney,
                Id = m.Id
            };
        }
        public static ac_day_goodsstock_journal_account D(this AcDayGoodsstockJournalAccount m)
        {
            return new ac_day_goodsstock_journal_account
            {
                ac_flow_number = m.Id,
                ac_date = m.AcDate,
                goods_code = m.GoodsCode,
                op_code = m.OpCode,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                sale_price = m.SalePrice,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                init_sale_money = m.InitSaleMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                purchase_sale_money = m.PurchaseSaleMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                return_sale_money = m.ReturnSaleMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                supply_qty = m.SupplyQty,
                supply_money = m.SupplyMoney,
                supply_sale_money = m.SupplySaleMoney,
                sreturn_qty = m.SreturnQty,
                sreturn_money = m.SreturnMoney,
                sreturn_sale_money = m.SreturnSaleMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                loss_sale_money = m.LossSaleMoney,
                adjust_qty = m.AdjustQty,
                adjust_money = m.AdjustMoney,
                adjust_sale_money = m.AdjustSaleMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                adjustsale_money = m.AdjustsaleMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                stock_sale_money = m.StockSaleMoney,
                sup_code = m.SupCode
            };
        }
        public static ac_day_goodsstock_journal_account_temp D(this AcDayGoodsstockJournalAccountTemp m)
        {
            return new ac_day_goodsstock_journal_account_temp
            {
                ac_date = m.AcDate,
                goods_code = m.GoodsCode,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                stock_sale_money = m.StockSaleMoney,
                Id = m.Id
            };
        }
        public static ac_goodssale_account D(this AcGoodssaleAccount m)
        {
            return new ac_goodssale_account
            {
                rt_flow_number = m.Id,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                rt_date = m.RtDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                op_code = m.OpCode,
                sale_price = m.SalePrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                cost_money = m.CostMoney,
                nontax_cost_money = m.NontaxCostMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                sup_code = m.SupCode,
                pool_rate = m.PoolRate,
                output_tax = m.OutputTax,
                if_promotion = m.IfPromotion
            };
        }
        public static ac_goodssale_account_tg D(this AcGoodssaleAccountTg m)
        {
            return new ac_goodssale_account_tg
            {
                rt_flow_number = m.Id,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                rt_date = m.RtDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                op_code = m.OpCode,
                sale_price = m.SalePrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                cost_money = m.CostMoney,
                nontax_cost_money = m.NontaxCostMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                sup_code = m.SupCode,
                pool_rate = m.PoolRate,
                output_tax = m.OutputTax,
                if_promotion = m.IfPromotion
            };
        }
        public static ac_month_class_journal_account D(this AcMonthClassJournalAccount m)
        {
            return new ac_month_class_journal_account
            {
                ac_flow_number = m.Id,
                ac_month = m.AcMonth,
                goods_class_code = m.GoodsClassCode,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney
            };
        }
        public static ac_month_goods_journal_account D(this AcMonthGoodsJournalAccount m)
        {
            return new ac_month_goods_journal_account
            {
                ac_flow_number = m.Id,
                ac_month = m.Id.ToS(),
                goods_code = m.Id.ToS(),
                op_code = m.OpCode,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                init_qty = m.InitQty,
                init_money = m.InitMoney,
                nontax_init_money = m.NontaxInitMoney,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney,
                sup_code = m.SupCode
            };
        }
        public static ac_pa_dayaccount D(this AcPaDayaccount m)
        {
            return new ac_pa_dayaccount
            {
                last_ty_date = m.LastTyDate,
                last_rt_flow_number = m.LastRtFlowNumber,
                current_rt_flow_number = m.CurrentRtFlowNumber,
                last_ws_flow_number = m.LastWsFlowNumber,
                current_ws_flow_number = m.CurrentWsFlowNumber,
                last_pi_flow_number = m.LastPiFlowNumber,
                current_pi_flow_number = m.CurrentPiFlowNumber,
                last_po_flow_number = m.LastPoFlowNumber,
                current_po_flow_number = m.CurrentPoFlowNumber,
                last_al_flow_number = m.LastAlFlowNumber,
                current_al_flow_number = m.CurrentAlFlowNumber,
                last_lo_flow_number = m.LastLoFlowNumber,
                current_lo_flow_number = m.CurrentLoFlowNumber,
                last_ad_flow_number = m.LastAdFlowNumber,
                current_ad_flow_number = m.CurrentAdFlowNumber,
                last_ex_flow_number = m.LastExFlowNumber,
                current_ex_flow_number = m.CurrentExFlowNumber,
                last_sc_flow_number = m.LastScFlowNumber,
                current_sc_flow_number = m.CurrentScFlowNumber,
                last_sp_flow_number = m.LastSpFlowNumber,
                current_sp_flow_number = m.CurrentSpFlowNumber,
                last_re_flow_number = m.LastReFlowNumber,
                current_re_flow_number = m.CurrentReFlowNumber,
                Id = m.Id
            };
        }
        public static ac_pa_dayaccount_stock D(this AcPaDayaccountStock m)
        {
            return new ac_pa_dayaccount_stock
            {
                last_ty_date = m.LastTyDate,
                Id = m.Id
            };
        }
        public static ac_pa_saleset D(this AcPaSaleset m)
        {
            return new ac_pa_saleset
            {
                last_ty_date = m.LastTyDate,
                last_sa_flow_number = m.LastSaFlowNumber,
                current_sa_flow_number = m.CurrentSaFlowNumber,
                Id = m.Id
            };
        }
        public static ac_period_time_summary D(this AcPeriodTimeSummary m)
        {
            return new ac_period_time_summary
            {
                rt_flow_number = m.Id,
                rt_date = m.RtDate,
                period_time = m.PeriodTime,
                wh_code = m.WhCode,
                b_code = m.bCode,
                passenger_flow = m.PassengerFlow,
                avg_sale_price = m.AvgSalePrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney
            };
        }
        public static ac_salesman_summary D(this AcSalesmanSummary m)
        {
            return new ac_salesman_summary
            {
                rt_flow_number = m.Id,
                rt_date = m.RtDate,
                salesman = m.Salesman,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.bCode,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                push_rate = m.PushRate,
                push_money = m.PushMoney
            };
        }
        public static ac_stock_account D(this AcStockAccount m)
        {
            return new ac_stock_account
            {
                en_code = m.EnCode,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                sup_code = m.SupCode,
                stock_qty = m.StockQty,
                stock_money = m.StockMoney,
                nontax_stock_money = m.NontaxStockMoney,
                Id = m.Id
            };
        }
        public static ac_supplier_journal D(this AcSupplierJournal m)
        {
            return new ac_supplier_journal
            {
                sup_flow_number = m.Id,
                sup_code = m.SupCode,
                ac_date = m.AcDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                return_qty = m.ReturnQty,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                alin_qty = m.AlinQty,
                alin_money = m.AlinMoney,
                nontax_alin_money = m.NontaxAlinMoney,
                alout_qty = m.AloutQty,
                alout_money = m.AloutMoney,
                nontax_alout_money = m.NontaxAloutMoney,
                loss_qty = m.LossQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney
            };
        }
        public static ba_branch_balance D(this BaBranchBalance m)
        {
            return new ba_branch_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                b_code = m.bCode,
                payway_code = m.PaywayCode,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_branch_detail D(this BaBranchDetail m)
        {
            return new ba_branch_detail
            {
                ba_number = m.BaNumber,
                operat_number = m.OperatNumber,
                operat_type = m.OperatType,
                receivable_money = m.ReceivableMoney,
                received_money = m.ReceivedMoney,
                unreceived_money = m.UnreceivedMoney,
                pay_money = m.PayMoney,
                pay_margin = m.PayMargin,
                margin_deal = m.MarginDeal,
                table_name = m.TableName,
                column_name = m.ColumnName,
                Id = m.Id
            };
        }
        public static ba_branch_offer_account D(this BaBranchOfferAccount m)
        {
            return new ba_branch_offer_account
            {
                ac_number = m.Id,
                ac_date = m.AcDate,
                en_code = m.EnCode,
                b_code = m.bCode,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                account_money = m.AccountMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_branch_offer_detail D(this BaBranchOfferDetail m)
        {
            return new ba_branch_offer_detail
            {
                ac_number = m.AcNumber,
                goods_code = m.GoodsCode,
                rt_date = m.RtDate,
                sale_qty = m.SaleQty,
                supply_price = m.SupplyPrice,
                sale_money = m.SaleMoney,
                supply_money = m.SupplyMoney,
                Id = m.Id
            };
        }
        public static ba_charge_detail D(this BaChargeDetail m)
        {
            return new ba_charge_detail
            {
                charge_number = m.ChargeNumber,
                number_flow = m.Id,
                charge_code = m.ChargeCode,
                charge_name = m.ChargeName,
                charge_standard = m.ChargeStandard,
                comment = m.Comment
            };
        }
        public static ba_charge_manage D(this BaChargeManage m)
        {
            return new ba_charge_manage
            {
                charge_number = m.Id,
                charge_date = m.ChargeDate,
                charge_object = m.ChargeObject,
                object_code = m.ObjectCode,
                object_name = m.ObjectName,
                charge_type = m.ChargeType,
                charge_money = m.ChargeMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_customer_balance D(this BaCustomerBalance m)
        {
            return new ba_customer_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                cust_code = m.CustCode,
                payway_code = m.PaywayCode,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_customer_detail D(this BaCustomerDetail m)
        {
            return new ba_customer_detail
            {
                ba_number = m.BaNumber,
                operat_number = m.OperatNumber,
                operat_type = m.OperatType,
                receivable_money = m.ReceivableMoney,
                received_money = m.ReceivedMoney,
                unreceived_money = m.UnreceivedMoney,
                pay_money = m.PayMoney,
                pay_margin = m.PayMargin,
                margin_deal = m.MarginDeal,
                table_name = m.TableName,
                column_name = m.ColumnName,
                Id = m.Id
            };
        }
        public static ba_lease_account D(this BaLeaseAccount m)
        {
            return new ba_lease_account
            {
                ac_number = m.Id,
                ac_date = m.AcDate,
                en_code = m.EnCode,
                sup_code = m.SupCode,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                account_money = m.AccountMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_lease_detail D(this BaLeaseDetail m)
        {
            return new ba_lease_detail
            {
                ac_number = m.AcNumber,
                goods_code = m.GoodsCode,
                rt_date = m.RtDate,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                payable_money = m.PayableMoney,
                Id = m.Id
            };
        }
        public static ba_offer_account D(this BaOfferAccount m)
        {
            return new ba_offer_account
            {
                ac_number = m.Id,
                ac_date = m.AcDate,
                en_code = m.EnCode,
                sup_code = m.SupCode,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                account_money = m.AccountMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_offer_detail D(this BaOfferDetail m)
        {
            return new ba_offer_detail
            {
                ac_number = m.AcNumber,
                goods_code = m.GoodsCode,
                rt_date = m.RtDate,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                payable_money = m.PayableMoney,
                Id = m.Id
            };
        }
        public static ba_pa_account D(this BaPaAccount m)
        {
            return new ba_pa_account
            {
                sup_code = m.SupCode,
                last_rt_flow_number = m.LastRtFlowNumber,
                current_rt_flow_number = m.CurrentRtFlowNumber,
                Id = m.Id
            };
        }
        public static ba_pa_branch_account D(this BaPaBranchAccount m)
        {
            return new ba_pa_branch_account
            {
                b_code = m.bCode,
                last_rt_flow_number = m.LastRtFlowNumber,
                current_rt_flow_number = m.CurrentRtFlowNumber,
                Id = m.Id
            };
        }
        public static ba_pa_charge D(this BaPaCharge m)
        {
            return new ba_pa_charge
            {
                charge_code = m.Id,
                charge_name = m.ChargeName,
                charge_standard = m.ChargeStandard
            };
        }
        public static ba_pa_subject D(this BaPaSubject m)
        {
            return new ba_pa_subject
            {
                ba_flow_number = m.Id,
                operat_type = m.OperatType,
                op_code = m.OpCode,
                s_number = m.sNumber,
                debit_credit = m.DebitCredit,
                input_tax = m.InputTax,
                subject_code = m.SubjectCode,
                if_tax = m.IfTax,
                if_dept = m.IfDept,
                if_supplier = m.IfSupplier,
                if_kind = m.IfKind,
                if_rate = m.IfRate,
                if_antitone = m.IfAntitone
            };
        }
        public static ba_pool_account D(this BaPoolAccount m)
        {
            return new ba_pool_account
            {
                ac_number = m.Id,
                ac_date = m.AcDate,
                en_code = m.EnCode,
                sup_code = m.SupCode,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                account_money = m.AccountMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_pool_detail D(this BaPoolDetail m)
        {
            return new ba_pool_detail
            {
                ac_number = m.AcNumber,
                goods_code = m.GoodsCode,
                rt_date = m.RtDate,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                pool_rate = m.PoolRate,
                payable_money = m.PayableMoney,
                if_promotion = m.IfPromotion,
                Id = m.Id
            };
        }
        public static ba_supplier_balance D(this BaSupplierBalance m)
        {
            return new ba_supplier_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                sup_code = m.SupCode,
                payway_code = m.PaywayCode,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ba_supplier_detail D(this BaSupplierDetail m)
        {
            return new ba_supplier_detail
            {
                ba_number = m.BaNumber,
                operat_number = m.OperatNumber,
                operat_type = m.OperatType,
                payable_money = m.PayableMoney,
                paid_money = m.PaidMoney,
                unpaid_money = m.UnpaidMoney,
                pay_money = m.PayMoney,
                pay_margin = m.PayMargin,
                margin_deal = m.MarginDeal,
                table_name = m.TableName,
                column_name = m.ColumnName,
                Id = m.Id
            };
        }
        public static bs_adjust_saleprice D(this BsAdjustSaleprice m)
        {
            return new bs_adjust_saleprice
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                adjust_type = m.AdjustType,
                b_code = m.bCode,
                class_code = m.ClassCode,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_adjust_saleprice_goods D(this BsAdjustSalepriceGoods m)
        {
            return new bs_adjust_saleprice_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sale_price_old = m.SalePriceOld,
                sale_price = m.SalePrice,
                vip_price_old = m.VipPriceOld,
                vip_price = m.VipPrice,
                trade_price_old = m.TradePriceOld,
                trade_price = m.TradePrice,
                Id = m.Id
            };
        }
        public static bs_branch_allot_detail D(this BsBranchAllotDetail m)
        {
            return new bs_branch_allot_detail
            {
                al_number = m.AlNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                stock_qty = m.StockQty,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                allot_qty = m.AllotQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                allot_money = m.AllotMoney,
                nontax_allot_money = m.NontaxAllotMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static bs_branch_allot_manage D(this BsBranchAllotManage m)
        {
            return new bs_branch_allot_manage
            {
                al_number = m.Id,
                b_code_out = m.bCodeOut,
                wh_code_out = m.WhCodeOut,
                b_code_in = m.bCodeIn,
                wh_code_in = m.WhCodeIn,
                al_date = m.AlDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_branch_archives D(this BsBranchArchives m)
        {
            return new bs_branch_archives
            {
                b_code = m.Id,
                b_name = m.bName,
                py_code = m.PyCode,
                b_type = m.bType,
                b_state = m.bState,
                area_code = m.AreaCode,
                class_code = m.ClassCode,
                functionary = m.Functionary,
                functionary_phone = m.FunctionaryPhone,
                contact_address = m.ContactAddress,
                office_phone = m.OfficePhone,
                fax_phone = m.FaxPhone,
                e_mail = m.eMail,
                postalcode = m.Postalcode,
                open_account = m.OpenAccount,
                bank_account = m.BankAccount,
                tax_number = m.TaxNumber,
                op_code = m.OpCode,
                stock_voucher = m.StockVoucher,
                input_tax = m.InputTax,
                balance_mode = m.BalanceMode,
                pay_mode = m.PayMode,
                balance_period = m.BalancePeriod,
                balance_day = m.BalanceDay,
                delivery_days = m.DeliveryDays,
                supply_price_type = m.SupplyPriceType,
                gross_rate = m.GrossRate,
                wh_code = m.WhCode,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_branch_price D(this BsBranchPrice m)
        {
            return new bs_branch_price
            {
                b_code = m.bCode,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sale_price = m.SalePrice,
                vip_price = m.VipPrice,
                trade_price = m.TradePrice,
                modify_date = m.ModifyDate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static bs_pa_area D(this BsPaArea m)
        {
            return new bs_pa_area
            {
                area_code = m.AreaCode,
                area_name = m.AreaName,
                functionary = m.Functionary,
                Id = m.Id
            };
        }
        public static bs_pa_branch_warehouse D(this BsPaBranchWarehouse m)
        {
            return new bs_pa_branch_warehouse
            {
                b_code = m.Id,
                wh_code = m.Id,
                wh_name = m.WhName,
                wh_area = m.WhArea,
                sys_guid = m.SysGuid
            };
        }
        public static bs_pa_class D(this BsPaClass m)
        {
            return new bs_pa_class
            {
                class_code = m.ClassCode,
                class_name = m.ClassName,
                Id = m.Id
            };
        }
        public static bs_return_detail D(this BsReturnDetail m)
        {
            return new bs_return_detail
            {
                re_number = m.ReNumber,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                return_qty = m.ReturnQty,
                supply_price = m.SupplyPrice,
                supply_money = m.SupplyMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static bs_return_manage D(this BsReturnManage m)
        {
            return new bs_return_manage
            {
                re_number = m.Id,
                sp_number = m.SpNumber,
                b_code = m.bCode,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                wh_code_in = m.WhCodeIn,
                sp_type = m.SpType,
                return_date = m.ReturnDate,
                return_money = m.ReturnMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_return_manage_flow D(this BsReturnManageFlow m)
        {
            return new bs_return_manage_flow
            {
                re_flow_number = m.Id,
                re_number = m.Id.ToS(),
                b_code = m.bCode,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                wh_code_in = m.WhCodeIn,
                sp_type = m.SpType,
                return_date = m.ReturnDate,
                return_money = m.ReturnMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_supply_detail D(this BsSupplyDetail m)
        {
            return new bs_supply_detail
            {
                sp_number = m.SpNumber,
                wh_code = m.WhCode,
                b_code = m.bCode,
                sp_state = m.SpState,
                wh_code_out = m.WhCodeOut,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                purchase_pack_qty = m.PurchasePackQty,
                supply_pack_qty = m.SupplyPackQty,
                putin_pack_qty = m.PutinPackQty,
                pack_coef = m.PackCoef,
                purchase_qty = m.PurchaseQty,
                supply_qty = m.SupplyQty,
                putin_qty = m.PutinQty,
                supply_price = m.SupplyPrice,
                supply_money = m.SupplyMoney,
                discount_money = m.DiscountMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static bs_supply_manage D(this BsSupplyManage m)
        {
            return new bs_supply_manage
            {
                sp_number = m.Id,
                b_code = m.bCode,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                wh_code_out = m.WhCodeOut,
                sp_type = m.SpType,
                sp_state = m.SpState,
                purchase_date = m.PurchaseDate,
                expect_arrive_date = m.ExpectArriveDate,
                supply_date = m.SupplyDate,
                putin_date = m.PutinDate,
                supply_money = m.SupplyMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                purchase_assessor = m.PurchaseAssessor,
                purchase_if_examine = m.PurchaseIfExamine,
                purchase_examine_date = m.PurchaseExamineDate,
                supply_assessor = m.SupplyAssessor,
                supply_if_examine = m.SupplyIfExamine,
                supply_examine_date = m.SupplyExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_supply_manage_flow D(this BsSupplyManageFlow m)
        {
            return new bs_supply_manage_flow
            {
                sp_flow_number = m.Id,
                sp_number = m.Id.ToS(),
                b_code = m.bCode,
                en_code = m.EnCode,
                wh_code = m.WhCode,
                wh_code_out = m.WhCodeOut,
                sp_type = m.SpType,
                sp_state = m.SpState,
                purchase_date = m.PurchaseDate,
                expect_arrive_date = m.ExpectArriveDate,
                supply_date = m.SupplyDate,
                putin_date = m.PutinDate,
                supply_money = m.SupplyMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                purchase_assessor = m.PurchaseAssessor,
                purchase_if_examine = m.PurchaseIfExamine,
                purchase_examine_date = m.PurchaseExamineDate,
                supply_assessor = m.SupplyAssessor,
                supply_if_examine = m.SupplyIfExamine,
                supply_examine_date = m.SupplyExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_supply_present_promotion D(this BsSupplyPresentPromotion m)
        {
            return new bs_supply_present_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                adjust_reason = m.AdjustReason,
                sp_branch = m.SpBranch,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_supply_present_promotion_branch D(this BsSupplyPresentPromotionBranch m)
        {
            return new bs_supply_present_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static bs_supply_present_promotion_goods D(this BsSupplyPresentPromotionGoods m)
        {
            return new bs_supply_present_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                supply_qty = m.SupplyQty,
                supply_price = m.SupplyPrice,
                goods_bar_code_present = m.GoodsBarCodePresent,
                goods_code_present = m.GoodsCodePresent,
                present_qty = m.PresentQty,
                present_money = m.PresentMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static bs_supply_promotion D(this BsSupplyPromotion m)
        {
            return new bs_supply_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                adjust_reason = m.AdjustReason,
                sp_branch = m.SpBranch,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static bs_supply_promotion_branch D(this BsSupplyPromotionBranch m)
        {
            return new bs_supply_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static bs_supply_promotion_goods D(this BsSupplyPromotionGoods m)
        {
            return new bs_supply_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                if_sale_price = m.IfSalePrice,
                supply_price_old = m.SupplyPriceOld,
                supply_price_discount = m.SupplyPriceDiscount,
                supply_price = m.SupplyPrice,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static em_employee_archives D(this EmEmployeeArchives m)
        {
            return new em_employee_archives
            {
                em_code = m.Id,
                em_name = m.EmName,
                name_used = m.NameUsed,
                birthday = m.Birthday,
                sex = m.Sex,
                politics_code = m.PoliticsCode,
                nation_code = m.NationCode,
                education_code = m.EducationCode,
                Professional_title_code = m.ProfessionalTitleCode,
                if_married = m.IfMarried,
                native_place = m.NativePlace,
                idcard = m.Idcard,
                accede_day = m.AccedeDay,
                family_phone = m.FamilyPhone,
                handset = m.Handset,
                e_mail = m.eMail,
                family_address = m.FamilyAddress,
                postalcode = m.Postalcode,
                graduate_academy = m.GraduateAcademy,
                graduate_day = m.GraduateDay,
                d_code = m.dCode,
                b_code = m.bCode,
                duty_code = m.DutyCode,
                bank_account = m.BankAccount,
                pension_account = m.PensionAccount,
                em_state = m.EmState,
                stature = m.Stature,
                width = m.Width
            };
        }
        public static em_employee_family D(this EmEmployeeFamily m)
        {
            return new em_employee_family
            {
                em_code = m.EmCode,
                s_number = m.sNumber,
                member_name = m.MemberName,
                relationship = m.Relationship,
                birthday = m.Birthday,
                politics_code = m.PoliticsCode,
                duty_code = m.DutyCode,
                work_department = m.WorkDepartment,
                Id = m.Id
            };
        }
        public static em_employee_photo D(this EmEmployeePhoto m)
        {
            return new em_employee_photo
            {
                em_code = m.EmCode,
                em_photo = m.EmPhoto,
                photo_type = m.PhotoType,
                Id = m.Id
            };
        }
        public static em_pa_duty D(this EmPaDuty m)
        {
            return new em_pa_duty
            {
                duty_code = m.DutyCode,
                duty_name = m.DutyName,
                Id = m.Id
            };
        }
        public static em_pa_education D(this EmPaEducation m)
        {
            return new em_pa_education
            {
                education_code = m.EducationCode,
                education_name = m.EducationName,
                Id = m.Id
            };
        }
        public static em_pa_nation D(this EmPaNation m)
        {
            return new em_pa_nation
            {
                nation_code = m.NationCode,
                nation_name = m.NationName,
                Id = m.Id
            };
        }
        public static em_pa_politics D(this EmPaPolitics m)
        {
            return new em_pa_politics
            {
                politics_code = m.PoliticsCode,
                politics_name = m.PoliticsName,
                Id = m.Id
            };
        }
        public static em_pa_Professional_title D(this EmPaProfessionalTitle m)
        {
            return new em_pa_Professional_title
            {
                Professional_title_code = m.ProfessionalTitleCode,
                Professional_title_name = m.ProfessionalTitleName,
                Id = m.Id
            };
        }
        public static fb_adjust_class D(this FbAdjustClass m)
        {
            return new fb_adjust_class
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_adjust_class_goods D(this FbAdjustClassGoods m)
        {
            return new fb_adjust_class_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                gb_code_old = m.GbCodeOld,
                gm_code_old = m.GmCodeOld,
                gs_code_old = m.GsCodeOld,
                gl_code_old = m.GlCodeOld,
                gb_code = m.GbCode,
                gm_code = m.GmCode,
                gs_code = m.GsCode,
                gl_code = m.GlCode,
                Id = m.Id
            };
        }
        public static fb_adjust_poolrate D(this FbAdjustPoolrate m)
        {
            return new fb_adjust_poolrate
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_adjust_poolrate_goods D(this FbAdjustPoolrateGoods m)
        {
            return new fb_adjust_poolrate_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                sup_code = m.SupCode,
                pool_rate_old = m.PoolRateOld,
                pool_rate = m.PoolRate,
                Id = m.Id
            };
        }
        public static fb_adjust_purchaseprice D(this FbAdjustPurchaseprice m)
        {
            return new fb_adjust_purchaseprice
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_adjust_purchaseprice_goods D(this FbAdjustPurchasepriceGoods m)
        {
            return new fb_adjust_purchaseprice_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                sup_code = m.SupCode,
                input_tax = m.InputTax,
                purchase_price_old = m.PurchasePriceOld,
                nontax_purchase_price_old = m.NontaxPurchasePriceOld,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                Id = m.Id
            };
        }
        public static fb_adjust_saleprice D(this FbAdjustSaleprice m)
        {
            return new fb_adjust_saleprice
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_adjust_saleprice_goods D(this FbAdjustSalepriceGoods m)
        {
            return new fb_adjust_saleprice_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sale_price_old = m.SalePriceOld,
                sale_price = m.SalePrice,
                vip_price_old = m.VipPriceOld,
                vip_price = m.VipPrice,
                trade_price_old = m.TradePriceOld,
                trade_price = m.TradePrice,
                stock_qty = m.StockQty,
                loss_money = m.LossMoney,
                nontax_loss_money = m.NontaxLossMoney,
                Id = m.Id
            };
        }
        public static fb_adjust_supplier D(this FbAdjustSupplier m)
        {
            return new fb_adjust_supplier
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_adjust_supplier_goods D(this FbAdjustSupplierGoods m)
        {
            return new fb_adjust_supplier_goods
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                sup_code_old = m.SupCodeOld,
                op_code_old = m.OpCodeOld,
                sup_code = m.SupCode,
                sup_name = m.SupName,
                py_code = m.PyCode,
                op_code = m.OpCode,
                pool_rate = m.PoolRate,
                offer_mode = m.OfferMode,
                offer_min = m.OfferMin,
                input_tax = m.InputTax,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                Id = m.Id
            };
        }
        public static fb_goods_archives D(this FbGoodsArchives m)
        {
            return new fb_goods_archives
            {
                goods_code = m.Id,
                goods_bar_code = m.GoodsBarCode,
                goods_sub_code = m.GoodsSubCode,
                gb_code = m.GbCode,
                gm_code = m.GmCode,
                gs_code = m.GsCode,
                gl_code = m.GlCode,
                goods_type = m.GoodsType,
                check_mode = m.CheckMode,
                sup_code = m.SupCode,
                op_code = m.OpCode,
                pool_rate = m.PoolRate,
                goods_name = m.GoodsName,
                goods_sub_name = m.GoodsSubName,
                py_code = m.PyCode,
                goods_state = m.GoodsState,
                producing_area = m.ProducingArea,
                article_number = m.ArticleNumber,
                specification = m.Specification,
                shelf_life = m.ShelfLife,
                pack_unit_code = m.PackUnitCode,
                offer_mode = m.OfferMode,
                pack_coef = m.PackCoef,
                offer_min = m.OfferMin,
                input_tax = m.InputTax,
                output_tax = m.OutputTax,
                stock_upper_limit = m.StockUpperLimit,
                stock_lower_limit = m.StockLowerLimit,
                under_floor_code = m.UnderFloorCode,
                under_counter_code = m.UnderCounterCode,
                brand_code = m.BrandCode,
                check_unit_code = m.CheckUnitCode,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                avg_cost = m.AvgCost,
                nontax_avg_cost = m.NontaxAvgCost,
                gross_rate = m.GrossRate,
                supply_price = m.SupplyPrice,
                sale_price = m.SalePrice,
                vip_price = m.VipPrice,
                trade_price = m.TradePrice,
                push_rate = m.PushRate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_goods_archives_bar D(this FbGoodsArchivesBar m)
        {
            return new fb_goods_archives_bar
            {
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                goods_bar_name = m.GoodsBarName,
                pack_unit_code = m.PackUnitCode,
                pack_coef = m.PackCoef,
                qty_type = m.QtyType,
                price_type = m.PriceType,
                sale_price = m.SalePrice,
                vip_price = m.VipPrice,
                trade_price = m.TradePrice,
                push_rate = m.PushRate,
                if_main_bar = m.IfMainBar,
                if_examine = m.IfExamine,
                Id = m.Id
            };
        }
        public static fb_goods_archives_bind D(this FbGoodsArchivesBind m)
        {
            return new fb_goods_archives_bind
            {
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                goods_code_bind = m.GoodsCodeBind,
                goods_bar_code_bind = m.GoodsBarCodeBind,
                goods_bar_name = m.GoodsBarName,
                pack_unit_code = m.PackUnitCode,
                bind_coef = m.BindCoef,
                sale_price = m.SalePrice,
                bind_sale_price = m.BindSalePrice,
                if_examine = m.IfExamine,
                sale_money = m.SaleMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static fb_goods_archives_library D(this FbGoodsArchivesLibrary m)
        {
            return new fb_goods_archives_library
            {
                goods_bar_code = m.Id,
                goods_name = m.GoodsName,
                goods_sub_name = m.GoodsSubName,
                producing_area = m.ProducingArea,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                owner_type = m.OwnerType
            };
        }
        public static fb_goods_archives_parts D(this FbGoodsArchivesParts m)
        {
            return new fb_goods_archives_parts
            {
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                goods_code_part = m.GoodsCodePart,
                goods_bar_code_part = m.GoodsBarCodePart,
                goods_bar_name = m.GoodsBarName,
                pack_unit_code = m.PackUnitCode,
                part_coef = m.PartCoef,
                if_examine = m.IfExamine,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static fb_goods_archives_photo D(this FbGoodsArchivesPhoto m)
        {
            return new fb_goods_archives_photo
            {
                goods_code = m.GoodsCode,
                s_number = m.sNumber,
                photo_type = m.PhotoType,
                Id = m.Id
            };
        }
        public static fb_goods_archives_supplier D(this FbGoodsArchivesSupplier m)
        {
            return new fb_goods_archives_supplier
            {
                goods_code = m.GoodsCode,
                sup_code = m.SupCode,
                sup_name = m.SupName,
                py_code = m.PyCode,
                op_code = m.OpCode,
                pool_rate = m.PoolRate,
                offer_mode = m.OfferMode,
                offer_min = m.OfferMin,
                input_tax = m.InputTax,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                if_main_supplier = m.IfMainSupplier,
                if_examine = m.IfExamine,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static fb_goods_bar_code D(this FbGoodsBarCode m)
        {
            return new fb_goods_bar_code
            {
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                goods_sub_code = m.GoodsSubCode,
                goods_name = m.GoodsName,
                goods_sub_name = m.GoodsSubName,
                py_code = m.PyCode,
                gb_code = m.GbCode,
                gm_code = m.GmCode,
                gs_code = m.GsCode,
                gl_code = m.GlCode,
                owner_type = m.OwnerType,
                sup_code = m.SupCode,
                op_code = m.OpCode,
                pool_rate = m.PoolRate,
                pack_coef = m.PackCoef,
                pack_unit_code = m.PackUnitCode,
                qty_type = m.QtyType,
                price_type = m.PriceType,
                sale_price = m.SalePrice,
                vip_price = m.VipPrice,
                trade_price = m.TradePrice,
                goods_state = m.GoodsState,
                modify_date = m.ModifyDate,
                Id = m.Id
            };
        }
        public static fb_pa_base_set D(this FbPaBaseSet m)
        {
            return new fb_pa_base_set
            {
                goods_gb_len = m.GoodsGbLen,
                goods_gm_len = m.GoodsGmLen,
                goods_gs_len = m.GoodsGsLen,
                goods_gl_len = m.GoodsGlLen,
                goods_class_level = m.GoodsClassLevel,
                goods_len = m.GoodsLen,
                goods_prefix = m.GoodsPrefix,
                sup_len = m.SupLen,
                sup_prefix_type = m.SupPrefixType,
                sup_prefix_content = m.SupPrefixContent,
                purchase_precise_len = m.PurchasePreciseLen,
                sale_precise_len = m.SalePreciseLen,
                @operator = m.Operator,
                @operator_date = m.OperatorDate,
                Id = m.Id,
                if_change_purchase_price_in_archives = m.IfChangePurchasePriceInArchives
            };
        }
        public static fb_pa_goods_brand D(this FbPaGoodsBrand m)
        {
            return new fb_pa_goods_brand
            {
                brand_code = m.BrandCode,
                brand_name = m.BrandName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_check_unit D(this FbPaGoodsCheckUnit m)
        {
            return new fb_pa_goods_check_unit
            {
                check_unit_code = m.CheckUnitCode,
                check_unit_name = m.CheckUnitName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_counter D(this FbPaGoodsCounter m)
        {
            return new fb_pa_goods_counter
            {
                counter_code = m.CounterCode,
                counter_name = m.CounterName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_gb D(this FbPaGoodsGb m)
        {
            return new fb_pa_goods_gb
            {
                gb_code = m.GbCode,
                gb_name = m.GbName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_gl D(this FbPaGoodsGl m)
        {
            return new fb_pa_goods_gl
            {
                gs_code = m.GsCode,
                gl_code = m.GlCode,
                gl_name = m.GlName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_gm D(this FbPaGoodsGm m)
        {
            return new fb_pa_goods_gm
            {
                gb_code = m.GbCode,
                gm_code = m.GmCode,
                gm_name = m.GmName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_gs D(this FbPaGoodsGs m)
        {
            return new fb_pa_goods_gs
            {
                gm_code = m.GmCode,
                gs_code = m.GsCode,
                gs_name = m.GsName,
                Id = m.Id
            };
        }
        public static fb_pa_goods_pack_unit D(this FbPaGoodsPackUnit m)
        {
            return new fb_pa_goods_pack_unit
            {
                pack_unit_code = m.PackUnitCode,
                pack_unit_name = m.PackUnitName,
                Id = m.Id
            };
        }
        public static fb_pa_sup_type D(this FbPaSupType m)
        {
            return new fb_pa_sup_type
            {
                sup_type_code = m.SupTypeCode,
                sup_type_name = m.SupTypeName,
                Id = m.Id
            };
        }
        public static fb_supplier_archives D(this FbSupplierArchives m)
        {
            return new fb_supplier_archives
            {
                sup_code = m.Id,
                sup_name = m.SupName,
                py_code = m.PyCode,
                sup_type_code = m.SupTypeCode,
                functionary = m.Functionary,
                functionary_phone = m.FunctionaryPhone,
                linkman = m.Linkman,
                contact_phone = m.ContactPhone,
                contact_address = m.ContactAddress,
                office_phone = m.OfficePhone,
                fax_phone = m.FaxPhone,
                e_mail = m.eMail,
                postalcode = m.Postalcode,
                open_account = m.OpenAccount,
                bank_account = m.BankAccount,
                tax_number = m.TaxNumber,
                op_code = m.OpCode,
                stock_voucher = m.StockVoucher,
                input_tax = m.InputTax,
                balance_mode = m.BalanceMode,
                pay_mode = m.PayMode,
                balance_period = m.BalancePeriod,
                balance_day = m.BalanceDay,
                offer_mode = m.OfferMode,
                delivery_days = m.DeliveryDays,
                pool_rate = m.PoolRate,
                floors_money = m.FloorsMoney,
                excess_rate = m.ExcessRate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static fb_supplier_lease D(this FbSupplierLease m)
        {
            return new fb_supplier_lease
            {
                le_number = m.Id,
                sup_code = m.SupCode,
                under_counter_code = m.UnderCounterCode,
                lease_begin_date = m.LeaseBeginDate,
                lease_end_date = m.LeaseEndDate,
                rental_money = m.RentalMoney,
                sale_money = m.SaleMoney,
                floors_money = m.FloorsMoney,
                rent_rate = m.RentRate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_adjust_points D(this MsAdjustPoints m)
        {
            return new ms_adjust_points
            {
                number_flow = m.Id,
                adjust_date = m.AdjustDate,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                ms_name = m.MsName,
                card_code = m.CardCode,
                card_name = m.CardName,
                current_points = m.CurrentPoints,
                adjust_points = m.AdjustPoints,
                surplus_points = m.SurplusPoints,
                current_money = m.CurrentMoney,
                adjust_money = m.AdjustMoney,
                surplus_money = m.SurplusMoney,
                if_modify_pw = m.IfModifyPw,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_cancel_card_manage D(this MsCancelCardManage m)
        {
            return new ms_cancel_card_manage
            {
                cancel_number = m.Id,
                en_code = m.EnCode,
                cancel_date = m.CancelDate,
                cancel_reason = m.CancelReason,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_card_archives D(this MsCardArchives m)
        {
            return new ms_card_archives
            {
                card_number = m.Id,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                ms_name = m.MsName,
                card_state = m.CardState,
                create_date = m.CreateDate,
                grant_date = m.GrantDate,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                total_money = m.TotalMoney,
                total_expend_times = m.TotalExpendTimes,
                last_expend_money = m.LastExpendMoney,
                total_points = m.TotalPoints,
                exchange_points = m.ExchangePoints,
                current_points = m.CurrentPoints,
                clear_points = m.ClearPoints,
                prepaid_password = m.PrepaidPassword,
                total_prepaid = m.TotalPrepaid,
                current_prepaid = m.CurrentPrepaid,
                current_prepaid_encrypt = m.CurrentPrepaidEncrypt,
                use_prepaid = m.UsePrepaid,
                limit_times = m.LimitTimes,
                sale_times = m.SaleTimes,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_cardtype_discount D(this MsCardtypeDiscount m)
        {
            return new ms_cardtype_discount
            {
                card_code = m.CardCode,
                goods_class_code = m.GoodsClassCode,
                goods_class_name = m.GoodsClassName,
                discount_base = m.DiscountBase,
                class_discount_rate = m.ClassDiscountRate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static ms_cardtype_goods_discount D(this MsCardtypeGoodsDiscount m)
        {
            return new ms_cardtype_goods_discount
            {
                card_code = m.CardCode,
                goods_code = m.GoodsCode,
                goods_name = m.GoodsName,
                discount_base = m.DiscountBase,
                goods_discount_rate = m.GoodsDiscountRate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static ms_cardtype_goods_points D(this MsCardtypeGoodsPoints m)
        {
            return new ms_cardtype_goods_points
            {
                card_code = m.CardCode,
                goods_code = m.GoodsCode,
                goods_name = m.GoodsName,
                expend_base = m.ExpendBase,
                points_values = m.PointsValues,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static ms_cardtype_manage D(this MsCardtypeManage m)
        {
            return new ms_cardtype_manage
            {
                card_code = m.Id,
                card_name = m.CardName,
                card_type = m.CardType,
                card_medium = m.CardMedium,
                card_useful_life = m.CardUsefulLife,
                points_useful_life = m.PointsUsefulLife,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                if_vip = m.IfVip,
                if_discount = m.IfDiscount,
                discount_base = m.DiscountBase,
                discount_rate = m.DiscountRate,
                if_points = m.IfPoints,
                expend_base = m.ExpendBase,
                points_values = m.PointsValues,
                birthday_points = m.BirthdayPoints,
                if_prepaid = m.IfPrepaid,
                if_prepaid_password = m.IfPrepaidPassword,
                limit_times = m.LimitTimes,
                prestore_money = m.PrestoreMoney,
                prestore_pw = m.PrestorePw,
                prepaid_min = m.PrepaidMin,
                prepaid_max = m.PrepaidMax,
                if_point_to_prepaid = m.IfPointToPrepaid,
                points_base = m.PointsBase,
                prepaid_money = m.PrepaidMoney,
                card_number_prefix = m.CardNumberPrefix,
                card_number_len = m.CardNumberLen,
                rand_len = m.RandLen,
                upgrade_type = m.UpgradeType,
                points_needs = m.PointsNeeds,
                if_deduct_points = m.IfDeductPoints,
                if_autoup = m.IfAutoup,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_cardtype_points D(this MsCardtypePoints m)
        {
            return new ms_cardtype_points
            {
                card_code = m.CardCode,
                goods_class_code = m.GoodsClassCode,
                goods_class_name = m.GoodsClassName,
                expend_base = m.ExpendBase,
                points_values = m.PointsValues,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static ms_exchange_detail D(this MsExchangeDetail m)
        {
            return new ms_exchange_detail
            {
                exchange_number = m.ExchangeNumber,
                s_number = m.sNumber,
                goods_code = m.GoodsCode,
                goods_name = m.GoodsName,
                exchange_qty = m.ExchangeQty,
                exchange_points = m.ExchangePoints,
                points_total = m.PointsTotal,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static ms_exchange_manage D(this MsExchangeManage m)
        {
            return new ms_exchange_manage
            {
                ex_flow_number = m.Id,
                exchange_number = m.ExchangeNumber,
                exchange_date = m.ExchangeDate,
                card_number = m.CardNumber,
                ms_code = m.MsCode,
                ms_name = m.MsName,
                current_points = m.CurrentPoints,
                exchange_points = m.ExchangePoints,
                surplus_points = m.SurplusPoints,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_freeze_card_manage D(this MsFreezeCardManage m)
        {
            return new ms_freeze_card_manage
            {
                freeze_number = m.Id,
                en_code = m.EnCode,
                freeze_date = m.FreezeDate,
                freeze_reason = m.FreezeReason,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_gift_archives D(this MsGiftArchives m)
        {
            return new ms_gift_archives
            {
                goods_code = m.GoodsCode,
                goods_name = m.GoodsName,
                exchange_points = m.ExchangePoints,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                wh_code = m.WhCode,
                @operator = m.Operator,
                @operator_date = m.OperatorDate,
                Id = m.Id
            };
        }
        public static ms_grant_card_manage D(this MsGrantCardManage m)
        {
            return new ms_grant_card_manage
            {
                grant_number = m.Id,
                en_code = m.EnCode,
                grant_date = m.GrantDate,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_loss_card_manage D(this MsLossCardManage m)
        {
            return new ms_loss_card_manage
            {
                loss_number = m.Id,
                en_code = m.EnCode,
                loss_date = m.LossDate,
                loss_type = m.LossType,
                loss_reason = m.LossReason,
                loss_person = m.LossPerson,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_madecard_manage D(this MsMadecardManage m)
        {
            return new ms_madecard_manage
            {
                md_number = m.Id,
                md_date = m.MdDate,
                card_code = m.CardCode,
                begin_card_number = m.BeginCardNumber,
                end_card_number = m.EndCardNumber,
                made_qty = m.MadeQty,
                effective_type = m.EffectiveType,
                effective_date = m.EffectiveDate,
                if_made = m.IfMade,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_member_archives D(this MsMemberArchives m)
        {
            return new ms_member_archives
            {
                card_number = m.CardNumber,
                ms_code = m.Id,
                ms_name = m.MsName,
                birthday = m.Birthday,
                sex = m.Sex,
                politics_code = m.PoliticsCode,
                nation_code = m.NationCode,
                education_code = m.EducationCode,
                Professional_title_code = m.ProfessionalTitleCode,
                if_married = m.IfMarried,
                native_place = m.NativePlace,
                idcard = m.Idcard,
                family_phone = m.FamilyPhone,
                handset = m.Handset,
                e_mail = m.eMail,
                family_address = m.FamilyAddress,
                postalcode = m.Postalcode,
                stature = m.Stature,
                width = m.Width
            };
        }
        public static ms_points_clear D(this MsPointsClear m)
        {
            return new ms_points_clear
            {
                number_flow = m.Id,
                clear_date = m.ClearDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_pointtoprepaid_manage D(this MsPointtoprepaidManage m)
        {
            return new ms_pointtoprepaid_manage
            {
                number_flow = m.Id,
                exchange_date = m.ExchangeDate,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                ms_name = m.MsName,
                card_code = m.CardCode,
                card_name = m.CardName,
                current_points = m.CurrentPoints,
                exchange_points = m.ExchangePoints,
                surplus_points = m.SurplusPoints,
                prepaid_money = m.PrepaidMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_prepaid_card_manage D(this MsPrepaidCardManage m)
        {
            return new ms_prepaid_card_manage
            {
                prepaid_number = m.Id,
                en_code = m.EnCode,
                prepaid_date = m.PrepaidDate,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                prepaid_money = m.PrepaidMoney,
                total_prepaid = m.TotalPrepaid,
                current_prepaid = m.CurrentPrepaid,
                use_prepaid = m.UsePrepaid,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_reclaim_card_manage D(this MsReclaimCardManage m)
        {
            return new ms_reclaim_card_manage
            {
                reclaim_number = m.Id,
                en_code = m.EnCode,
                reclaim_date = m.ReclaimDate,
                reclaim_reason = m.ReclaimReason,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static ms_update_card_manage D(this MsUpdateCardManage m)
        {
            return new ms_update_card_manage
            {
                update_number = m.UpdateNumber,
                en_code = m.EnCode,
                update_date = m.UpdateDate,
                update_reason = m.UpdateReason,
                card_number_old = m.CardNumberOld,
                surface_number_old = m.SurfaceNumberOld,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                ms_code = m.MsCode,
                card_code = m.CardCode,
                card_name = m.CardName,
                card_state = m.CardState,
                effective_date = m.EffectiveDate,
                points_useful_life_date = m.PointsUsefulLifeDate,
                card_useful_life_date = m.CardUsefulLifeDate,
                transact_charge = m.TransactCharge,
                deposit_money = m.DepositMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate,
                Id = m.Id
            };
        }
        public static ms_upgrade_card_detail D(this MsUpgradeCardDetail m)
        {
            return new ms_upgrade_card_detail
            {
                upgrade_number = m.UpgradeNumber,
                card_number = m.CardNumber,
                surface_number = m.SurfaceNumber,
                card_code_old = m.CardCodeOld,
                card_name_old = m.CardNameOld,
                card_code = m.CardCode,
                card_name = m.CardName,
                deduct_points = m.DeductPoints,
                total_points = m.TotalPoints,
                exchange_points = m.ExchangePoints,
                current_points = m.CurrentPoints,
                clear_points = m.ClearPoints,
                card_state = m.CardState,
                Id = m.Id
            };
        }
        public static ms_upgrade_card_manage D(this MsUpgradeCardManage m)
        {
            return new ms_upgrade_card_manage
            {
                upgrade_number = m.Id,
                en_code = m.EnCode,
                upgrade_date = m.UpgradeDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                @operator_date = m.OperatorDate
            };
        }
        public static op_adjust_detail D(this OpAdjustDetail m)
        {
            return new op_adjust_detail
            {
                adjust_number = m.AdjustNumber,
                goods_code = m.GoodsCode,
                adjust_qty = m.AdjustQty,
                adjust_price = m.AdjustPrice,
                nontax_adjust_price = m.NontaxAdjustPrice,
                adjust_money = m.AdjustMoney,
                nontax_adjust_money = m.NontaxAdjustMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static op_adjust_manage D(this OpAdjustManage m)
        {
            return new op_adjust_manage
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                en_code = m.EnCode,
                adjust_type = m.AdjustType,
                adjust_operat = m.AdjustOperat,
                wh_code = m.WhCode,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_adjust_manage_flow D(this OpAdjustManageFlow m)
        {
            return new op_adjust_manage_flow
            {
                ad_flow_number = m.Id,
                adjust_number = m.Id.ToS(),
                adjust_date = m.AdjustDate,
                en_code = m.EnCode,
                adjust_type = m.AdjustType,
                adjust_operat = m.AdjustOperat,
                wh_code = m.WhCode,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_adjust_purchase_detail D(this OpAdjustPurchaseDetail m)
        {
            return new op_adjust_purchase_detail
            {
                adjust_number = m.AdjustNumber,
                adjust_date = m.AdjustDate,
                wh_code = m.WhCode,
                batch_number = m.BatchNumber,
                pi_number = m.PiNumber,
                putin_date = m.PutinDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sup_code = m.SupCode,
                input_tax = m.InputTax,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                sale_price = m.SalePrice,
                nontax_sale_price = m.NontaxSalePrice,
                purchase_qty = m.PurchaseQty,
                stockout_qty = m.StockoutQty,
                stock_qty = m.StockQty,
                adjust_qty = m.AdjustQty,
                adjust_price = m.AdjustPrice,
                adjust_diff = m.AdjustDiff,
                adjust_money = m.AdjustMoney,
                if_ablebalance = m.IfAblebalance,
                adjust_ba_money = m.AdjustBaMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                produce_date = m.ProduceDate,
                Id = m.Id
            };
        }
        public static op_adjust_purchase_manage D(this OpAdjustPurchaseManage m)
        {
            return new op_adjust_purchase_manage
            {
                adjust_number = m.Id,
                adjust_date = m.AdjustDate,
                en_code = m.EnCode,
                goods_code = m.GoodsCode,
                adjust_reason = m.AdjustReason,
                adjust_money = m.AdjustMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_allot_detail D(this OpAllotDetail m)
        {
            return new op_allot_detail
            {
                al_number = m.AlNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                stock_qty = m.StockQty,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                allot_qty = m.AllotQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                allot_money = m.AllotMoney,
                nontax_allot_money = m.NontaxAllotMoney,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                Id = m.Id
            };
        }
        public static op_allot_manage D(this OpAllotManage m)
        {
            return new op_allot_manage
            {
                al_number = m.Id,
                al_type = m.AlType,
                organ_out = m.OrganOut,
                organ_name_out = m.OrganNameOut,
                wh_code_out = m.WhCodeOut,
                organ_in = m.OrganIn,
                organ_name_in = m.OrganNameIn,
                wh_code_in = m.WhCodeIn,
                al_date = m.AlDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_allot_manage_flow D(this OpAllotManageFlow m)
        {
            return new op_allot_manage_flow
            {
                al_flow_number = m.Id,
                al_number = m.Id.ToS(),
                al_type = m.AlType,
                organ_out = m.OrganOut,
                organ_name_out = m.OrganNameOut,
                wh_code_out = m.WhCodeOut,
                organ_in = m.OrganIn,
                organ_name_in = m.OrganNameIn,
                wh_code_in = m.WhCodeIn,
                al_date = m.AlDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_check_detail D(this OpCheckDetail m)
        {
            return new op_check_detail
            {
                ck_flow_number = m.Id,
                ck_number = m.CkNumber,
                b_code = m.bCode,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                purchase_price = m.PurchasePrice,
                sale_price = m.SalePrice,
                pack_coef = m.PackCoef,
                pack_qty = m.PackQty,
                check_qty = m.CheckQty,
                stock_qty = m.StockQty,
                @operator = m.Operator,
                sys_guid = m.SysGuid
            };
        }
        public static op_check_manage D(this OpCheckManage m)
        {
            return new op_check_manage
            {
                ck_number = m.Id,
                ck_date = m.CkDate,
                ck_type = m.CkType,
                ck_organ = m.CkOrgan,
                wh_code = m.WhCode,
                ck_area = m.CkArea,
                if_transfer = m.IfTransfer,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_check_stock D(this OpCheckStock m)
        {
            return new op_check_stock
            {
                ck_number = m.CkNumber,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                stock_qty = m.StockQty,
                Id = m.Id
            };
        }
        public static op_check_transfer D(this OpCheckTransfer m)
        {
            return new op_check_transfer
            {
                ck_flow_number = m.Id,
                ck_number = m.Id.ToS(),
                b_code = m.bCode,
                wh_code = m.WhCode,
                goods_code = m.Id.ToS(),
                goods_bar_code = m.GoodsBarCode,
                purchase_price = m.PurchasePrice,
                sale_price = m.SalePrice,
                pack_coef = m.PackCoef,
                pack_qty = m.PackQty,
                check_qty = m.CheckQty,
                stock_qty = m.StockQty,
                differ_qty = m.DifferQty,
                sys_guid = m.SysGuid
            };
        }
        public static op_dynamic_stock D(this OpDynamicStock m)
        {
            return new op_dynamic_stock
            {
                goods_code = m.Id,
                stock_qty = m.StockQty,
                order_qty = m.OrderQty,
                if_modify = m.IfModify
            };
        }
        public static op_dynamic_stock_branch D(this OpDynamicStockBranch m)
        {
            return new op_dynamic_stock_branch
            {
                en_code = m.EnCode,
                b_code = m.Id,
                wh_code = m.Id,
                goods_code = m.Id,
                stock_qty = m.StockQty
            };
        }
        public static op_dynamic_stock_wh D(this OpDynamicStockWh m)
        {
            return new op_dynamic_stock_wh
            {
                en_code = m.Id,
                wh_code = m.Id,
                goods_code = m.Id,
                stock_qty = m.StockQty
            };
        }
        public static op_goods_batch D(this OpGoodsBatch m)
        {
            return new op_goods_batch
            {
                ba_flow_number = m.Id,
                en_code = m.Id.ToS(),
                wh_code = m.Id.ToS(),
                goods_code = m.Id.ToS(),
                batch_number = m.Id,
                goods_bar_code = m.GoodsBarCode,
                sup_code = m.SupCode,
                op_code = m.OpCode,
                input_tax = m.InputTax,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                sale_price = m.SalePrice,
                nontax_sale_price = m.NontaxSalePrice,
                purchase_qty = m.PurchaseQty,
                stockout_qty = m.StockoutQty,
                stock_qty = m.StockQty,
                pi_number = m.PiNumber,
                putin_date = m.PutinDate,
                produce_date = m.ProduceDate,
                if_modify = m.IfModify
            };
        }
        public static op_loss_detail D(this OpLossDetail m)
        {
            return new op_loss_detail
            {
                lo_number = m.LoNumber,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                purchase_price = m.PurchasePrice,
                sale_price = m.SalePrice,
                stock_qty = m.StockQty,
                differ_qty = m.DifferQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                Id = m.Id
            };
        }
        public static op_loss_manage D(this OpLossManage m)
        {
            return new op_loss_manage
            {
                lo_number = m.Id,
                lo_date = m.LoDate,
                ck_number = m.CkNumber,
                lo_type = m.LoType,
                lo_organ = m.LoOrgan,
                wh_code = m.WhCode,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_loss_manage_flow D(this OpLossManageFlow m)
        {
            return new op_loss_manage_flow
            {
                lo_flow_number = m.Id,
                lo_number = m.Id.ToS(),
                lo_date = m.LoDate,
                ck_number = m.CkNumber,
                lo_type = m.LoType,
                lo_organ = m.LoOrgan,
                wh_code = m.WhCode,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_pa_warehouse D(this OpPaWarehouse m)
        {
            return new op_pa_warehouse
            {
                wh_code = m.WhCode,
                wh_name = m.WhName,
                wh_area = m.WhArea,
                if_main_wh = m.IfMainWh,
                Id = m.Id
            };
        }
        public static op_split_com_detail D(this OpSplitComDetail m)
        {
            return new op_split_com_detail
            {
                sc_number = m.ScNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                purchase_qty = m.PurchaseQty,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                sale_price = m.SalePrice,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                Id = m.Id
            };
        }
        public static op_split_com_goods D(this OpSplitComGoods m)
        {
            return new op_split_com_goods
            {
                goods_code = m.GoodsCode,
                goods_code_child = m.GoodsCodeChild,
                goods_qty = m.GoodsQty,
                Id = m.Id
            };
        }
        public static op_split_com_manage D(this OpSplitComManage m)
        {
            return new op_split_com_manage
            {
                sc_number = m.Id,
                sc_date = m.ScDate,
                sc_type = m.ScType,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                sale_price = m.SalePrice,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static op_split_com_manage_flow D(this OpSplitComManageFlow m)
        {
            return new op_split_com_manage_flow
            {
                sc_flow_number = m.Id,
                sc_number = m.Id.ToS(),
                sc_date = m.ScDate,
                sc_type = m.ScType,
                wh_code = m.WhCode,
                goods_code = m.GoodsCode,
                purchase_qty = m.PurchaseQty,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                sale_price = m.SalePrice,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }

        public static pc_purchase_detail D(this PcPurchaseDetail m)
        {
            return new pc_purchase_detail
            {
                pc_number = m.PcNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                offer_min = m.OfferMin,
                stock_qty = m.StockQty,
                order_qty = m.OrderQty,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                purchase_qty = m.PurchaseQty,
                putin_qty = m.PutinQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                produce_date = m.ProduceDate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static pc_purchase_manage D(this PcPurchaseManage m)
        {
            return new pc_purchase_manage
            {
                pc_number = m.Id,
                sup_code = m.SupCode,
                en_code = m.EnCode,
                pc_form = m.PcForm,
                d_code = m.dCode,
                b_code = m.bCode,
                pc_type = m.PcType,
                pc_mode = m.PcMode,
                wh_code = m.WhCode,
                purchase_date = m.PurchaseDate,
                expect_arrive_date = m.ExpectArriveDate,
                if_check = m.IfCheck,
                check_date = m.CheckDate,
                if_putin = m.IfPutin,
                putin_date = m.PutinDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate,
                sup_name = m.SupName,
                d_name = m.dName,
                b_name = m.bName
            };
        }
        public static pc_putin_detail D(this PcPutinDetail m)
        {
            return new pc_putin_detail
            {
                pi_number = m.PiNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                offer_min = m.OfferMin,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                purchase_qty = m.PurchaseQty,
                putin_qty = m.PutinQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                purchase_money = m.PurchaseMoney,
                nontax_purchase_money = m.NontaxPurchaseMoney,
                produce_date = m.ProduceDate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static pc_putin_manage D(this PcPutinManage m)
        {
            return new pc_putin_manage
            {
                pi_flow_number = m.Id,
                pi_number = m.Id.ToS(),
                sup_code = m.SupCode,
                en_code = m.EnCode,
                pc_form = m.PcForm,
                d_code = m.dCode,
                b_code = m.bCode,
                pc_type = m.PcType,
                pc_mode = m.PcMode,
                wh_code = m.WhCode,
                purchase_date = m.PurchaseDate,
                expect_arrive_date = m.ExpectArriveDate,
                check_date = m.CheckDate,
                putin_date = m.PutinDate,
                putin_money = m.PutinMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static pc_putout_detail D(this PcPutoutDetail m)
        {
            return new pc_putout_detail
            {
                po_number = m.PoNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                return_qty = m.ReturnQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static pc_putout_manage D(this PcPutoutManage m)
        {
            return new pc_putout_manage
            {
                po_flow_number = m.Id,
                po_number = m.Id.ToS(),
                sup_code = m.SupCode,
                en_code = m.EnCode,
                pc_form = m.PcForm,
                d_code = m.dCode,
                b_code = m.bCode,
                wh_code = m.WhCode,
                return_date = m.ReturnDate,
                putout_date = m.PutoutDate,
                return_money = m.ReturnMoney,
                if_ablebalance = m.IfAblebalance,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static pc_return_detail D(this PcReturnDetail m)
        {
            return new pc_return_detail
            {
                rt_number = m.RtNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                return_qty = m.ReturnQty,
                sale_price = m.SalePrice,
                purchase_price = m.PurchasePrice,
                nontax_purchase_price = m.NontaxPurchasePrice,
                return_money = m.ReturnMoney,
                nontax_return_money = m.NontaxReturnMoney,
                sale_money = m.SaleMoney,
                nontax_sale_money = m.NontaxSaleMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static pc_return_manage D(this PcReturnManage m)
        {
            return new pc_return_manage
            {
                rt_number = m.Id,
                pc_number = m.PcNumber,
                sup_code = m.SupCode,
                en_code = m.EnCode,
                pc_form = m.PcForm,
                d_code = m.dCode,
                b_code = m.bCode,
                wh_code = m.WhCode,
                return_date = m.ReturnDate,
                if_putout = m.IfPutout,
                putout_date = m.PutoutDate,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static rt_class_promotion D(this RtClassPromotion m)
        {
            return new rt_class_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static rt_class_promotion_branch D(this RtClassPromotionBranch m)
        {
            return new rt_class_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static rt_class_promotion_goods D(this RtClassPromotionGoods m)
        {
            return new rt_class_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                goods_class_code = m.GoodsClassCode,
                goods_class_name = m.GoodsClassName,
                sale_discount_rate = m.SaleDiscountRate,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static rt_pa_function D(this RtPaFunction m)
        {
            return new rt_pa_function
            {
                func_code = m.Id,
                func_name = m.FuncName,
                func_value = m.FuncValue,
                if_able = m.IfAble
            };
        }
        public static rt_pa_payway D(this RtPaPayway m)
        {
            return new rt_pa_payway
            {
                payway_code = m.Id,
                payway_name = m.PaywayName,
                payway_sub_code = m.PaywaySubCode,
                payway_type = m.PaywayType,
                ex_rate = m.ExRate,
                if_change = m.IfChange
            };
        }
        public static rt_pa_pos D(this RtPaPos m)
        {
            return new rt_pa_pos
            {
                posid = m.Id,
                pos_name = m.PosName,
                pos_ip = m.PosIp,
                pos_state = m.PosState,
                wh_code = m.WhCode,
                cd_type = m.CdType,
                cd_port = m.CdPort,
                p_type = m.pType,
                p_port = m.pPort,
                p_width = m.pWidth,
                p_type1 = m.pType1,
                p_port1 = m.pPort1,
                p_width1 = m.pWidth1,
                cb_type = m.CbType,
                cb_port = m.CbPort
            };
        }
        public static rt_pa_saleset D(this RtPaSaleset m)
        {
            return new rt_pa_saleset
            {
                mantissa = m.Mantissa,
                mantissa_mode = m.MantissaMode,
                if_return_sale = m.IfReturnSale,
                if_negative_stock = m.IfNegativeStock,
                if_return_payway = m.IfReturnPayway,
                if_salesman = m.IfSalesman,
                if_counter = m.IfCounter,
                print_type = m.PrintType,
                if_bind = m.IfBind,
                if_entertopay = m.IfEntertopay,
                if_entertormb = m.IfEntertormb,
                if_english_sale = m.IfEnglishSale,
                title1 = m.Title1,
                title2 = m.Title2,
                title3 = m.Title3,
                title4 = m.Title4,
                title5 = m.Title5,
                pagefoot1 = m.Pagefoot1,
                pagefoot2 = m.Pagefoot2,
                pagefoot3 = m.Pagefoot3,
                pagefoot4 = m.Pagefoot4,
                pagefoot5 = m.Pagefoot5,
                if_en_name = m.IfEnName,
                if_b_name = m.IfbName,
                if_goods_code = m.IfGoodsCode,
                if_goods_bar_code = m.IfGoodsBarCode,
                if_goods_name = m.IfGoodsName,
                if_goods_sub_name = m.IfGoodsSubName,
                if_pack_unit = m.IfPackUnit,
                if_prepaid = m.IfPrepaid,
                Id = m.Id
            };
        }
        public static rt_pa_shift D(this RtPaShift m)
        {
            return new rt_pa_shift
            {
                shift_code = m.Id,
                shift_name = m.ShiftName,
                begin_date = m.BeginDate,
                end_date = m.EndDate
            };
        }
        public static rt_plu_promotion D(this RtPluPromotion m)
        {
            return new rt_plu_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static rt_plu_promotion_branch D(this RtPluPromotionBranch m)
        {
            return new rt_plu_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static rt_plu_promotion_goods D(this RtPluPromotionGoods m)
        {
            return new rt_plu_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                if_sale_price = m.IfSalePrice,
                sale_price_old = m.SalePriceOld,
                sale_price_discount = m.SalePriceDiscount,
                sale_price = m.SalePrice,
                if_limit = m.IfLimit,
                total_limit = m.TotalLimit,
                total_limit_sale = m.TotalLimitSale,
                day_limit = m.DayLimit,
                day_limit_date = m.DayLimitDate,
                day_limit_sale = m.DayLimitSale,
                sheet_limit = m.SheetLimit,
                if_pool = m.IfPool,
                pool_rate_old = m.PoolRateOld,
                pool_rate = m.PoolRate,
                if_vip = m.IfVip,
                vip_price_old = m.VipPriceOld,
                vip_price = m.VipPrice,
                vip_sheet_limit = m.VipSheetLimit,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static rt_present_promotion D(this RtPresentPromotion m)
        {
            return new rt_present_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static rt_present_promotion_branch D(this RtPresentPromotionBranch m)
        {
            return new rt_present_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static rt_present_promotion_goods D(this RtPresentPromotionGoods m)
        {
            return new rt_present_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                goods_bar_code = m.GoodsBarCode,
                goods_code = m.GoodsCode,
                sale_qty = m.SaleQty,
                sale_price = m.SalePrice,
                goods_bar_code_present = m.GoodsBarCodePresent,
                goods_code_present = m.GoodsCodePresent,
                present_qty = m.PresentQty,
                present_money = m.PresentMoney,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static rt_retail_detail D(this RtRetailDetail m)
        {
            return new rt_retail_detail
            {
                sa_flow_number = m.Id,
                rt_number = m.RtNumber,
                s_number = m.sNumber,
                rt_date = m.RtDate,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.bCode,
                posid = m.Posid,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                sale_price = m.SalePrice,
                real_price = m.RealPrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                purchase_qty = m.PurchaseQty,
                p_sale_price = m.pSalePrice,
                p_sale_money = m.pSaleMoney,
                p_discount_money = m.pDiscountMoney,
                cashier = m.Cashier,
                salesman = m.Salesman,
                under_counter_code = m.UnderCounterCode,
                pool_rate = m.PoolRate,
                shift_date = m.ShiftDate,
                if_promotion = m.IfPromotion,
                owner_type = m.OwnerType,
                sys_guid = m.SysGuid
            };
        }
        public static rt_retail_log D(this RtRetailLog m)
        {
            return new rt_retail_log
            {
                sa_flow_number = m.Id,
                cashier = m.Cashier,
                em_name = m.EmName,
                operat_type = m.OperatType,
                rt_date = m.RtDate,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                goods_bar_name = m.GoodsBarName,
                real_price = m.RealPrice,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney
            };
        }
        public static rt_retail_manage D(this RtRetailManage m)
        {
            return new rt_retail_manage
            {
                sa_flow_number = m.Id,
                rt_number = m.Id.ToS(),
                rt_date = m.RtDate,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.Id.ToS(),
                posid = m.Posid,
                sale_qty = m.SaleQty,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                card_number = m.CardNumber,
                cashier = m.Cashier,
                cashier_higher = m.CashierHigher,
                salesman = m.Salesman,
                under_counter_code = m.UnderCounterCode,
                shift_date = m.ShiftDate,
                return_number = m.ReturnNumber,
                comment = m.Comment,
                sys_guid = m.SysGuid
            };
        }
        public static rt_retail_pay D(this RtRetailPay m)
        {
            return new rt_retail_pay
            {
                sa_flow_number = m.Id,
                rt_number = m.RtNumber,
                s_number = m.sNumber,
                rt_date = m.RtDate,
                rt_type = m.RtType,
                wh_code = m.WhCode,
                b_code = m.bCode,
                posid = m.Posid,
                payway_code = m.PaywayCode,
                sale_money = m.SaleMoney,
                ex_rate = m.ExRate,
                pay_money = m.PayMoney,
                pay_loss = m.PayLoss,
                bankcard_number = m.BankcardNumber,
                card_number = m.CardNumber,
                cashier = m.Cashier,
                salesman = m.Salesman,
                under_counter_code = m.UnderCounterCode,
                shift_date = m.ShiftDate,
                sys_guid = m.SysGuid
            };
        }
        public static rt_sheet_promotion D(this RtSheetPromotion m)
        {
            return new rt_sheet_promotion
            {
                sp_number = m.Id,
                en_code = m.EnCode,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                adjust_reason = m.AdjustReason,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static rt_sheet_promotion_branch D(this RtSheetPromotionBranch m)
        {
            return new rt_sheet_promotion_branch
            {
                sp_number = m.SpNumber,
                b_code = m.bCode,
                Id = m.Id
            };
        }
        public static rt_sheet_promotion_goods D(this RtSheetPromotionGoods m)
        {
            return new rt_sheet_promotion_goods
            {
                sp_number = m.SpNumber,
                sp_begin_date = m.SpBeginDate,
                sp_end_date = m.SpEndDate,
                sp_begin_time = m.SpBeginTime,
                sp_end_time = m.SpEndTime,
                sp_w1 = m.SpW1,
                sp_w2 = m.SpW2,
                sp_w3 = m.SpW3,
                sp_w4 = m.SpW4,
                sp_w5 = m.SpW5,
                sp_w6 = m.SpW6,
                sp_w7 = m.SpW7,
                sale_money = m.SaleMoney,
                sale_discount_rate = m.SaleDiscountRate,
                comment = m.Comment,
                sys_guid = m.SysGuid,
                Id = m.Id
            };
        }
        public static sys_class_power D(this SysClassPower m)
        {
            return new sys_class_power
            {
                em_code = m.EmCode,
                class_code = m.ClassCode,
                Id = m.Id
            };
        }
        public static sys_depart_power D(this SysDepartPower m)
        {
            return new sys_depart_power
            {
                d_code = m.dCode,
                window_name = m.WindowName,
                function_code = m.FunctionCode,
                selection = m.Selection,
                module_code = m.ModuleCode,
                module_name = m.ModuleName,
                module_child = m.ModuleChild,
                Id = m.Id
            };
        }
        public static sys_enterprise_archives D(this SysEnterpriseArchives m)
        {
            return new sys_enterprise_archives
            {
                en_code = m.EnCode,
                en_name = m.EnName,
                en_com_name = m.EnComName,
                en_type = m.EnType,
                en_character = m.EnCharacter,
                deal_area = m.DealArea,
                register_address = m.RegisterAddress,
                current_version = m.CurrentVersion,
                last_version = m.LastVersion,
                Id = m.Id
            };
        }
        public static sys_login_power D(this SysLoginPower m)
        {
            return new sys_login_power
            {
                em_code = m.Id,
                em_name = m.EmName,
                user_name = m.UserName,
                user_pw = m.UserPw,
                if_cash = m.IfCash,
                cash_function = m.CashFunction,
                user_state = m.UserState,
                max_discount = m.MaxDiscount
            };
        }
        public static sys_login_power_function D(this SysLoginPowerFunction m)
        {
            return new sys_login_power_function
            {
                em_code = m.Id,
                func_code = m.Id,
                if_able = m.IfAble
            };
        }
        public static sys_module D(this SysModule m)
        {
            return new sys_module
            {
                window_code = m.WindowCode,
                window_name = m.Id,
                module_code = m.ModuleCode,
                module_name = m.ModuleName,
                module_child = m.ModuleChild,
                function_code = m.Id,
                open_mode = m.OpenMode
            };
        }
        public static sys_module_content D(this SysModuleContent m)
        {
            return new sys_module_content
            {
                window_name = m.WindowName,
                column_code = m.ColumnCode,
                open_window_name = m.OpenWindowName,
                Id = m.Id
            };
        }
        public static sys_module_pic D(this SysModulePic m)
        {
            return new sys_module_pic
            {
                module_code = m.ModuleCode,
                module_name = m.ModuleName,
                pic_name = m.PicName,
                Id = m.Id
            };
        }
        public static sys_operation_flow D(this SysOperationFlow m)
        {
            return new sys_operation_flow
            {
                operation_name = m.Id,
                window_name = m.WindowName,
                s_number = m.Id,
                function_code = m.FunctionCode,
                turn_s_number = m.TurnsNumber,
                operation = m.Operation,
                condition = m.Condition,
                content = m.Content,
                statement = m.Statement
            };
        }
        public static sys_operation_flow_detail D(this SysOperationFlowDetail m)
        {
            return new sys_operation_flow_detail
            {
                operation_number = m.Id,
                operation_name = m.OperationName,
                s_number = m.Id,
                window_name = m.WindowName,
                current_s_number = m.CurrentsNumber,
                function_code = m.FunctionCode,
                current_function_code = m.CurrentFunctionCode,
                column_name = m.ColumnName,
                next_s_number = m.NextsNumber,
                current_state = m.CurrentState,
                operation_state = m.OperationState,
                operation_result = m.OperationResult,
                operation_opinion = m.OperationOpinion,
                @operator = m.Operator,
                @operator_date = m.OperatorDate,
                statement = m.Statement,
                statement_state = m.StatementState
            };
        }
        public static sys_operation_flow_detail_max D(this SysOperationFlowDetailMax m)
        {
            return new sys_operation_flow_detail_max
            {
                operation_number = m.OperationNumber,
                Id = m.Id
            };
        }
        public static sys_operation_worker D(this SysOperationWorker m)
        {
            return new sys_operation_worker
            {
                operation_name = m.OperationName,
                s_number = m.sNumber,
                em_code = m.EmCode,
                Id = m.Id
            };
        }
        public static sys_pa_department D(this SysPaDepartment m)
        {
            return new sys_pa_department
            {
                d_code = m.Id,
                d_name = m.dName,
                higher = m.Higher
            };
        }
        public static sys_print_design D(this SysPrintDesign m)
        {
            return new sys_print_design
            {
                dw_object = m.DwObject,
                template_name = m.TemplateName,
                if_main = m.IfMain,
                data_object = m.DataObject,
                ob_content = m.ObContent,
                ob_font_face = m.ObFontFace,
                ob_font_height = m.ObFontHeight,
                ob_font_weight = m.ObFontWeight,
                ob_font_italic = m.ObFontItalic,
                ob_font_underline = m.ObFontUnderline,
                ob_color = m.ObColor,
                if_visible = m.IfVisible,
                ob_x = m.Obx,
                ob_y = m.Oby,
                ob_width = m.ObWidth,
                ob_height = m.ObHeight,
                Id = m.Id
            };
        }


        public static sys_worker_power D(this SysWorkerPower m)
        {
            return new sys_worker_power
            {
                em_code = m.EmCode,
                window_name = m.WindowName,
                function_code = m.FunctionCode,
                selection = m.Selection,
                module_code = m.ModuleCode,
                module_name = m.ModuleName,
                module_child = m.ModuleChild,
                Id = m.Id
            };
        }
        public static tf_data_download D(this TfDataDownload m)
        {
            return new tf_data_download
            {
                download_id = m.Id,
                download_tablename = m.DownloadTablename,
                download_branchcode = m.DownloadBranchcode,
                download_keyvalue = m.DownloadKeyvalue
            };
        }
        public static tf_data_object D(this TfDataObject m)
        {
            return new tf_data_object
            {
                object_id = m.ObjectId,
                object_name = m.ObjectName,
                object_main = m.ObjectMain,
                object_maincolumn = m.ObjectMaincolumn,
                object_foreigncolumn = m.ObjectForeigncolumn,
                object_isinsert = m.ObjectIsinsert,
                object_isdelete = m.ObjectIsdelete,
                object_isupdate = m.ObjectIsupdate,
                object_dump = m.ObjectDump,
                object_keycolumn = m.ObjectKeycolumn,
                object_branchcodecolumn = m.ObjectBranchcodecolumn,
                object_isdeletedump = m.ObjectIsdeletedump,
                object_description = m.ObjectDescription,
                object_direction = m.ObjectDirection,
                object_istransfer = m.ObjectIstransfer,
                object_condition = m.ObjectCondition,
                object_order = m.ObjectOrder,
                Id = m.Id
            };
        }
        public static tf_data_property D(this TfDataProperty m)
        {
            return new tf_data_property
            {
                property_id = m.PropertyId,
                property_object = m.PropertyObject,
                property_name = m.PropertyName,
                property_type = m.PropertyType,
                property_iskey = m.PropertyIskey,
                property_isnullable = m.PropertyIsnullable,
                property_isunqueindex = m.PropertyIsunqueindex,
                property_istransfer = m.PropertyIstransfer,
                property_description = m.PropertyDescription,
                property_condition = m.PropertyCondition,
                Id = m.Id
            };
        }
        public static tg_expostor_balance D(this TgExpostorBalance m)
        {
            return new tg_expostor_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                payway_code = m.PaywayCode,
                expostor_code = m.ExpostorCode,
                expostor_name = m.ExpostorName,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static tg_expostor_balance_detail D(this TgExpostorBalanceDetail m)
        {
            return new tg_expostor_balance_detail
            {
                ba_number = m.BaNumber,
                group_number = m.GroupNumber,
                s_number = m.sNumber,
                sale_date = m.SaleDate,
                sale_money = m.SaleMoney,
                push_rate = m.PushRate,
                push_money = m.PushMoney,
                ptimes_money = m.PtimesMoney,
                total_push_money = m.TotalPushMoney,
                Id = m.Id
            };
        }
        public static tg_group_balance D(this TgGroupBalance m)
        {
            return new tg_group_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                payway_code = m.PaywayCode,
                en_code = m.EnCode,
                begin_date = m.BeginDate,
                end_date = m.EndDate,
                group_number = m.GroupNumber,
                ta_code = m.TaCode,
                person_times = m.PersonTimes,
                sale_money = m.SaleMoney,
                push_money = m.PushMoney,
                adjust_money = m.AdjustMoney,
                ta_returns_money = m.TaReturnsMoney,
                guide_code = m.GuideCode,
                contact_phone = m.ContactPhone,
                guide_push_money = m.GuidePushMoney,
                expostor = m.Expostor,
                expostor_push_money = m.ExpostorPushMoney,
                driver = m.Driver,
                stop_charge = m.StopCharge,
                nopay_money = m.NopayMoney,
                rebalance_cause = m.RebalanceCause,
                if_balance = m.IfBalance,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static tg_group_balance_detail D(this TgGroupBalanceDetail m)
        {
            return new tg_group_balance_detail
            {
                ba_number = m.BaNumber,
                s_number = m.sNumber,
                ba_items = m.BaItems,
                group_number = m.GroupNumber,
                guide_code = m.GuideCode,
                guide_name = m.GuideName,
                gb_code = m.GbCode,
                sale_money = m.SaleMoney,
                push_rate = m.PushRate,
                push_money = m.PushMoney,
                ptimes_money = m.PtimesMoney,
                total_push_money = m.TotalPushMoney,
                ba_state = m.BaState,
                ba_type = m.BaType,
                if_balance = m.IfBalance,
                if_print = m.IfPrint,
                Id = m.Id
            };
        }
        public static tg_group_call D(this TgGroupCall m)
        {
            return new tg_group_call
            {
                tg_flow_number = m.Id,
                call_type = m.CallType,
                items_code = m.ItemsCode,
                items_name = m.ItemsName,
                call_content = m.CallContent
            };
        }
        public static tg_guide_archives D(this TgGuideArchives m)
        {
            return new tg_guide_archives
            {
                tg_flow_number = m.Id,
                guide_code = m.Id.ToS(),
                guide_name = m.GuideName,
                py_code = m.PyCode,
                guide_type = m.GuideType,
                guide_id = m.GuideId,
                contact_phone = m.ContactPhone,
                ta_code = m.TaCode,
                ta_name = m.TaName,
                tac_code = m.TacCode,
                push_rate = m.PushRate,
                push_money = m.PushMoney,
                license_plate = m.LicensePlate,
                comment = m.Comment
            };
        }
        public static tg_guide_balance D(this TgGuideBalance m)
        {
            return new tg_guide_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                payway_code = m.PaywayCode,
                guide_code = m.GuideCode,
                guide_name = m.GuideName,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static tg_guide_balance_detail D(this TgGuideBalanceDetail m)
        {
            return new tg_guide_balance_detail
            {
                ba_number = m.BaNumber,
                s_number = m.sNumber,
                ba_nopay_number = m.BaNopayNumber,
                group_number = m.GroupNumber,
                sale_date = m.SaleDate,
                ba_items = m.BaItems,
                gb_code = m.GbCode,
                ta_code = m.TaCode,
                sale_money = m.SaleMoney,
                push_money = m.PushMoney,
                adjust_money = m.AdjustMoney,
                total_push_money = m.TotalPushMoney,
                Id = m.Id
            };
        }
        public static tg_pa_cars_charge D(this TgPaCarsCharge m)
        {
            return new tg_pa_cars_charge
            {
                cars_type_code = m.CarsTypeCode,
                person_lower = m.PersonLower,
                person_upper = m.PersonUpper,
                stop_charge = m.StopCharge,
                Id = m.Id
            };
        }
        public static tg_pa_cars_type D(this TgPaCarsType m)
        {
            return new tg_pa_cars_type
            {
                cars_type_code = m.CarsTypeCode,
                cars_type_name = m.CarsTypeName,
                stop_charge = m.StopCharge,
                Id = m.Id
            };
        }
        public static tg_pa_group D(this TgPaGroup m)
        {
            return new tg_pa_group
            {
                group_date = m.GroupDate,
                group_number = m.GroupNumber,
                gb_code = m.GbCode,
                last_rt_flow_number = m.LastRtFlowNumber,
                current_rt_flow_number = m.CurrentRtFlowNumber,
                Id = m.Id
            };
        }
        public static tg_pa_group_type D(this TgPaGroupType m)
        {
            return new tg_pa_group_type
            {
                group_type_code = m.GroupTypeCode,
                group_type_name = m.GroupTypeName,
                Id = m.Id
            };
        }
        public static tg_pa_ta_type D(this TgPaTaType m)
        {
            return new tg_pa_ta_type
            {
                ta_type_code = m.Id,
                ta_type_name = m.TaTypeName
            };
        }
        public static tg_pushtac_detail D(this TgPushtacDetail m)
        {
            return new tg_pushtac_detail
            {
                tac_code = m.TacCode,
                goods_class_code = m.GoodsClassCode,
                goods_class_name = m.GoodsClassName,
                push_rate = m.PushRate,
                push_money = m.PushMoney,
                Id = m.Id
            };
        }
        public static tg_pushtac_manage D(this TgPushtacManage m)
        {
            return new tg_pushtac_manage
            {
                tac_code = m.Id,
                tac_name = m.TacName,
                push_rate = m.PushRate,
                push_money = m.PushMoney
            };
        }
        public static tg_tourgroup_manage D(this TgTourgroupManage m)
        {
            return new tg_tourgroup_manage
            {
                tg_flow_number = m.Id,
                group_number = m.GroupNumber,
                group_date = m.GroupDate,
                group_type_code = m.GroupTypeCode,
                ta_code = m.TaCode,
                ta_name = m.TaName,
                ta_type_code = m.TaTypeCode,
                guide_code = m.GuideCode,
                guide_name = m.GuideName,
                guide_tac_code = m.GuideTacCode,
                guide_push_rate = m.GuidePushRate,
                guide_push_money = m.GuidePushMoney,
                person_times = m.PersonTimes,
                discount_rate = m.DiscountRate,
                expostor_tac_code = m.ExpostorTacCode,
                expostor = m.Expostor,
                expostor_push_rate = m.ExpostorPushRate,
                expostor_push_money = m.ExpostorPushMoney,
                driver = m.Driver,
                license_plate = m.LicensePlate,
                cars_group = m.CarsGroup,
                cars_type_code = m.CarsTypeCode,
                stop_charge = m.StopCharge,
                customer_from = m.CustomerFrom,
                comment = m.Comment,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static tg_travel_archives D(this TgTravelArchives m)
        {
            return new tg_travel_archives
            {
                ta_code = m.Id,
                ta_name = m.TaName,
                py_code = m.PyCode,
                ta_type_code = m.TaTypeCode,
                push_rate = m.PushRate,
                push_money = m.PushMoney,
                push_money_account = m.PushMoneyAccount,
                ta_returns_rate = m.TaReturnsRate,
                functionary = m.Functionary,
                functionary_phone = m.FunctionaryPhone,
                linkman = m.Linkman,
                contact_phone = m.ContactPhone,
                contact_address = m.ContactAddress,
                office_phone = m.OfficePhone,
                fax_phone = m.FaxPhone,
                e_mail = m.eMail,
                postalcode = m.Postalcode,
                open_account = m.OpenAccount,
                bank_account = m.BankAccount,
                tax_number = m.TaxNumber,
                print_type = m.PrintType,
                if_print = m.IfPrint,
                cars_type = m.CarsType,
                comment = m.Comment
            };
        }
        public static tg_travel_archives_pushtac D(this TgTravelArchivesPushtac m)
        {
            return new tg_travel_archives_pushtac
            {
                ta_code = m.TaCode,
                goods_class_code = m.GoodsClassCode,
                goods_class_name = m.GoodsClassName,
                push_rate = m.PushRate,
                account_rate = m.AccountRate,
                Id = m.Id
            };
        }
        public static tg_travel_balance D(this TgTravelBalance m)
        {
            return new tg_travel_balance
            {
                ba_number = m.Id,
                ba_date = m.BaDate,
                en_code = m.EnCode,
                payway_code = m.PaywayCode,
                ta_code = m.TaCode,
                ta_name = m.TaName,
                balance_money = m.BalanceMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static tg_travel_balance_detail D(this TgTravelBalanceDetail m)
        {
            return new tg_travel_balance_detail
            {
                ba_number = m.BaNumber,
                s_number = m.sNumber,
                ba_nopay_number = m.BaNopayNumber,
                group_number = m.GroupNumber,
                sale_date = m.SaleDate,
                ba_items = m.BaItems,
                gb_code = m.GbCode,
                guide_code = m.GuideCode,
                sale_money = m.SaleMoney,
                push_money = m.PushMoney,
                adjust_money = m.AdjustMoney,
                total_push_money = m.TotalPushMoney,
                Id = m.Id
            };
        }
        public static ws_customer_archives D(this WsCustomerArchives m)
        {
            return new ws_customer_archives
            {
                cust_code = m.Id,
                cust_name = m.CustName,
                py_code = m.PyCode,
                cust_type_code = m.CustTypeCode,
                linkman = m.Linkman,
                contact_phone = m.ContactPhone,
                contact_address = m.ContactAddress,
                office_phone = m.OfficePhone,
                fax_phone = m.FaxPhone,
                e_mail = m.eMail,
                postalcode = m.Postalcode,
                open_account = m.OpenAccount,
                bank_account = m.BankAccount,
                tax_number = m.TaxNumber,
                pay_mode = m.PayMode,
                balance_mode = m.BalanceMode,
                balance_period = m.BalancePeriod,
                balance_day = m.BalanceDay,
                sale_period = m.SalePeriod,
                comment = m.Comment,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ws_customer_goods D(this WsCustomerGoods m)
        {
            return new ws_customer_goods
            {
                cust_code = m.CustCode,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                trade_price = m.TradePrice,
                Id = m.Id
            };
        }
        public static ws_order_detail D(this WsOrderDetail m)
        {
            return new ws_order_detail
            {
                order_number = m.OrderNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                return_qty = m.ReturnQty,
                trade_price = m.TradePrice,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                Id = m.Id
            };
        }
        public static ws_order_manage D(this WsOrderManage m)
        {
            return new ws_order_manage
            {
                order_number = m.Id,
                order_date = m.OrderDate,
                cust_code = m.CustCode,
                ws_organ = m.WsOrgan,
                wh_code = m.WhCode,
                salesman = m.Salesman,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ws_pa_customer_type D(this WsPaCustomerType m)
        {
            return new ws_pa_customer_type
            {
                cust_type_code = m.CustTypeCode,
                cust_type_name = m.CustTypeName,
                ws_type = m.WsType,
                discount_rate = m.DiscountRate,
                Id = m.Id
            };
        }
        public static ws_wholesale_detail D(this WsWholesaleDetail m)
        {
            return new ws_wholesale_detail
            {
                ws_number = m.WsNumber,
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                specification = m.Specification,
                pack_unit_code = m.PackUnitCode,
                pack_qty = m.PackQty,
                pack_coef = m.PackCoef,
                sale_qty = m.SaleQty,
                trade_price = m.TradePrice,
                sale_money = m.SaleMoney,
                discount_money = m.DiscountMoney,
                nontax_sale_price = m.NontaxSalePrice,
                nontax_sale_money = m.NontaxSaleMoney,
                cost_money = m.CostMoney,
                nontax_cost_money = m.NontaxCostMoney,
                gross_money = m.GrossMoney,
                nontax_gross_money = m.NontaxGrossMoney,
                sale_type = m.SaleType,
                Id = m.Id
            };
        }
        public static ws_wholesale_goods_set D(this WsWholesaleGoodsSet m)
        {
            return new ws_wholesale_goods_set
            {
                goods_code = m.GoodsCode,
                goods_bar_code = m.GoodsBarCode,
                Id = m.Id
            };
        }
        public static ws_wholesale_manage D(this WsWholesaleManage m)
        {
            return new ws_wholesale_manage
            {
                ws_number = m.Id,
                ws_date = m.WsDate,
                order_number = m.OrderNumber,
                cust_code = m.CustCode,
                ws_type = m.WsType,
                ws_organ = m.WsOrgan,
                pay_mode = m.PayMode,
                pay_date = m.PayDate,
                wh_code = m.WhCode,
                salesman = m.Salesman,
                comment = m.Comment,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }
        public static ws_wholesale_manage_flow D(this WsWholesaleManageFlow m)
        {
            return new ws_wholesale_manage_flow
            {
                ws_flow_number = m.Id,
                ws_number = m.WsNumber,
                ws_date = m.WsDate,
                order_number = m.OrderNumber,
                cust_code = m.CustCode,
                ws_type = m.WsType,
                ws_organ = m.WsOrgan,
                pay_mode = m.PayMode,
                pay_date = m.PayDate,
                wh_code = m.WhCode,
                salesman = m.Salesman,
                comment = m.Comment,
                ws_money = m.WsMoney,
                if_balance = m.IfBalance,
                ba_number = m.BaNumber,
                ba_money = m.BaMoney,
                create_date = m.CreateDate,
                @operator = m.Operator,
                assessor = m.Assessor,
                if_examine = m.IfExamine,
                examine_date = m.ExamineDate,
                @operator_date = m.OperatorDate
            };
        }


    }
}