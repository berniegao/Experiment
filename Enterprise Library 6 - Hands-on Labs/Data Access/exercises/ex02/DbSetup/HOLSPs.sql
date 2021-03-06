USE [EntLibQuickStarts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HOLAddProduct]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[HOLAddProduct]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HOLUpdateProduct]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[HOLUpdateProduct]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HOLDeleteProduct]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[HOLDeleteProduct]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE HOLAddProduct
(
    @ProductName nvarchar(50),
    @CategoryID int,
    @UnitPrice money
)
AS

INSERT INTO  
  Products (ProductName, CategoryID, UnitPrice)
VALUES 
  (@ProductName, @CategoryID, @UnitPrice)

SELECT 
    ProductID, ProductName, CategoryID, UnitPrice, LastUpdate
FROM 
    Products
WHERE 
    ProductID = SCOPE_IDENTITY()
GO

CREATE PROCEDURE HOLDeleteProduct 
(
	@ProductID int,
	@LastUpdate datetime
)
AS

DELETE 
	Products 
WHERE 
	ProductID = @ProductID AND LastUpdate = @LastUpdate 
GO

CREATE PROCEDURE HOLUpdateProduct 
(
    @ProductID int,
    @ProductName nvarchar(50),
    @CategoryID int,
    @unitPrice money,
    @LastUpdate datetime
)
AS

UPDATE
  Products 
SET
  ProductName = @ProductName, CategoryID = @CategoryID, UnitPrice = @UnitPrice
WHERE
  ProductID = @ProductID AND
  LastUpdate = @LastUpdate
 
IF @@ROWCOUNT > 0
  -- This statement is used to update the DataSet if changes are done on the updated record (identities, timestamps or triggers )
  SELECT 
	ProductID, ProductName, CategoryID, UnitPrice, LastUpdate
  FROM 
	Products
  WHERE 
	ProductID = @ProductID
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF