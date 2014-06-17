﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MagentoAccess.MagentoSoapServiceReference;

namespace MagentoAccess.Services
{
	internal interface IMagentoServiceLowLevelSoap
	{
		string ApiUser { get; set; }
		string ApiKey { get; set; }
		string Store { get; set; }
		Task< salesOrderListResponse > GetOrdersAsync( DateTime modifiedFrom, DateTime modifiedTo );
		Task< salesOrderListResponse > GetOrdersAsync( IEnumerable< string > ordersIds );
		Task< catalogProductListResponse > GetProductsAsync();
		Task< catalogInventoryStockItemListResponse > GetStockItemsAsync( List< string > skusOrIds );
		Task< salesOrderInfoResponse > GetOrderAsync( string incrementId );
		Task< bool > PutStockItemsAsync( List< PutStockItem > stockItems );
	}
}