/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for BookSale
-- ----------------------------
DROP TABLE [dbo].[BookSale]
GO
CREATE TABLE [dbo].[BookSale] (
[Id] nvarchar(50) NOT NULL ,
[SaleNum] nvarchar(50) NULL ,
[UserId] nvarchar(50) NOT NULL ,
[GoodsNum] int NULL ,
[CountPrice] money NULL ,
[CreateTime] datetime NULL ,
[UpdateBy] nvarchar(50) NULL ,
[UpdateTime] datetime NULL ,
[State] int NULL DEFAULT ((1)) ,
[Address] nvarchar(200) NULL ,
[Evalute] nvarchar(200) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'SaleNum')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'订单号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'SaleNum'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'订单号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'SaleNum'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'UserId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UserId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UserId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'GoodsNum')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'商品数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'GoodsNum'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'商品数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'GoodsNum'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'CountPrice')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'总金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'CountPrice'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'总金额'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'CountPrice'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'UpdateBy')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'处理者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UpdateBy'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'处理者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UpdateBy'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'处理时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'处理时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'Address')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'收货地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Address'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'收货地址'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Address'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookSale', 
'COLUMN', N'Evalute')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'售后评价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Evalute'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'售后评价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookSale'
, @level2type = 'COLUMN', @level2name = N'Evalute'
GO

-- ----------------------------
-- Indexes structure for table BookSale
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table BookSale
-- ----------------------------
ALTER TABLE [dbo].[BookSale] ADD PRIMARY KEY ([Id])
GO
