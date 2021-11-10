using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace issRepo.SQLHelper
{
    public class QueryBuilder
    {
        public string BuildQuery(string queryName)
        {
            string query = string.Empty;
            switch (queryName)
            {
                case "getCustomers":
                    query = "select * from customers where isDeleted=0 ";
                    break;
                case "saveCusomter":
                    query = "INSERT INTO [dbo].[customers]" +
                            " ([firstName],[lastName],[doorNo],[buliding],[address1],[address2],[city],[state],[postalCode],[country],[phone]," +
                            " [email],[password],[userName],[isDeleted],[creditCard],[creditCardTypeId],[cardExpMo],[cardExpYr]," +
                            " [billingAddress],[billingCity],[billingRegion],[billingPostalCode],[billingCountry],[shipAddress],[shipCity]," +
                            " [shipRegion],[shipPostalCode],[shipCountry],[dateEntered])" +
                            "VALUES(@firstName,@lastName,@doorNo,@buliding,@address1,@address2,,@city,@state,@postalCode,@country," +
                            "@phone,@email,@password,@userName,@isDeleted" +
                            " @creditCard,@creditCardTypeId,@cardExpMo,@cardExpYr,@billingAddress,@billingCity,,@billingRegion,@billingPostalCode,@billingCountry,@shipAddress," +
                            "@shipCity,@shipRegion,@shipPostalCode,@shipCountry,@dateEntered)";
                    break;
                case "getCustomersBYId":
                    query = "select * from customers where customerID=@ID AND isDeleted=0 ";
                    break;
                case "getSupplier":
                    query = "select * from suppliers where isDeleted=0 ";
                    break;
                case "saveSupplier":
                    query = "INSERT INTO [dbo].[suppliers]" +
                            " ([companyName],[contactFName],[contactLName],[contactTitle],[firstAddress],[secondAddress]," +
                            " [city],[state],[postalCode],[country],[phone],[fax],[email],[URL],[paymentMethods],[discountType]," +
                            " [typeGoods],[notes],[discountAvailable],[currentOrder],[logo],[customerId],[sizeURL],[isDeleted])" +
                            " VALUES(@companyName,@contactFName,@contactLName,@contactTitle,@firstAddress,@secondAddress," +
                            " @city,@state,@postalCode,@country,@phone,@fax,@email,@URL,@paymentMethods,@discountType," +
                            " @typeGoods,@notes,@discountAvailable,@currentOrder,@logo,@customerId,@sizeURL,@isDeleted)";
                   
                    break;
                case "getSuppliersBYId":
                    query = "select * from suppliers where supplierID=@ID AND isDeleted=0 ";
                    break;



                case "getShipper":
                    query = "select * from Shipper where isDeleted=0 ";
                    break;
                case "saveShipper":
                    query = "INSERT INTO [dbo].[Shipper]" +
                            " ([companyName],[phoneNo],[isDeleted])" +
                            "VALUES(@companyName,@phoneNo,@isDeleted)";
                    break;
                case "getShipperBYId":
                    query = "select * from shippers where ShipperID=@ID AND isDeleted=0 ";
                    break;


                case "getOrder":
                    query = "select * from order where isDeleted=0 ";
                    break;
                case "saveOrder":
                    query = "INSERT INTO [dbo].[Order]" +
                            " ([customerId],[customer],[orderNo],[paymentId],[payment],[orderDate]," +
                            " [shipDate],[requiredDate],[shippedId],[shipper],[frieght],[salesTax],[transactStatus],[errLoc],[errMsg],[timestamp]," +
                            " [fullfilled],[deleted],[paid],[paymentDate],[isDeleted])" +
                            " VALUES(@customerId,@customer,@orderNo,@paymentId,@payment,@orderDate," +
                            " @shipDate,@requiredDate,@shippedId,@shipper,@frieght,@salesTax,@transactStatus,@errLoc,@errMsg,@timestamp," +
                            " @fullfilled,@deleted,@paid,@paymentDate,@isDeleted)";

                    break;
                case "getOrdersBYId":
                    query = "select * from orders where orderID=@ID AND isDeleted=0 ";
                    break;


               
                case "getPayment":
                    query = "select * from payments where isDeleted=0 ";
                    break;
                case "savePayment":
                    query = "INSERT INTO [dbo].[Order]" +
                            " ([paymentType],[allowed],[isDeleted])" +
                            " VALUES(@paymentType,@allowed,@isDeleted)";
                    break;
                case "getPaymentBYId":
                    query = "select * from payments where paymentID=@ID AND isDeleted=0 ";
                    break;



                case "getProduct":
                    query = "select * from product where isDeleted=0 ";
                    break;
                case "saveProduct":
                    query = "INSERT INTO [dbo].[Product]" +
                            " ([SKU],[IDSKU],[vendorproductId],[productName],[productDescription],[supplierId]," +
                            " [supplier],[categoryId],[category],[quantityPerUnit],[unitPrice],[MSRP],[availableSize],[availableColors],[size],[color]," +
                            " [discount],[unitWeight],[unitslnstok],[unitdOnOrder],[recorderLevel],[productAvailable],[discountAvailable],[currentOrder],[picture],[ranking],[note],[isDeleted])" +
                            " VALUES(@SKU,@IDSKU,@vendorproductId,@productName,@productDescription,@supplierId," +
                            " @supplier,@categoryId,@category,@quantityPerUnit,@unitPrice,@MSRP,@availableSize,@availableColors,@size,@color," +
                            " @discount,@unitWeight,@unitslnstok,@unitdOnOrder, @recorderLevel,@productAvailable,@discountAvailable,@currentOrder,@picture,@ranking,@note,@isDeleted)";

                    break;
                case "getProductBYId":
                    query = "select * from product where productID=@ID AND isDeleted=0 ";
                    break;



                case "getOrderDetails":
                    query = "select * from OrderDetails where isDeleted=0 ";
                    break;
                case "saveOrderDetails":
                    query = "INSERT INTO [dbo].[OrderDetails]" +
                            " ([orderId],[productId],[product],[orderNo],[price],[quantity]," +
                            " [discount],[total],[IDSKU],[size],[color],[fullFilled],[shipDate],[billDate],[isDeleted])" +
                            " VALUES(@orderId,@productId,@product,@orderNo,@price,@quantity," +
                            " @discount,@total,@IDSKU,@size,@color,@fullFilled,@shipDate,@billDate,@isDeleted)";

                    break;
                case "getOrderDeatilsBYId":
                    query = "select * from OrderDetails where OrderDetailID=@ID AND isDeleted=0 ";
                    break;




                case "getCategory":
                    query = "select * from category where isDeleted=0 ";
                    break;
                case "saveCategory":
                    query = "INSERT INTO [dbo].[Category]" +
                            " ([CategoryName],[description],[picture],[active],[isDeleted])" +
                            " VALUES(@CategoryName,@description,@picture,@active,@isDeleted)";
                    break;
                case "getCategoryBYId":
                    query = "select * from Category where CategoryID=@ID AND isDeleted=0 ";
                    break;
            }
            return query;
        }
    }
}