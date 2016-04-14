/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for SaleDetail
-- ----------------------------
DROP TABLE [dbo].[SaleDetail]
GO
CREATE TABLE [dbo].[SaleDetail] (
[Id] nvarchar(50) NOT NULL ,
[BsId] nvarchar(50) NOT NULL ,
[BookId] nvarchar(50) NULL ,
[BookNum] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SaleDetail', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售详细编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售详细编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SaleDetail', 
'COLUMN', N'BsId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BsId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BsId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SaleDetail', 
'COLUMN', N'BookId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BookId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BookId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SaleDetail', 
'COLUMN', N'BookNum')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'购买数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BookNum'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'购买数量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SaleDetail'
, @level2type = 'COLUMN', @level2name = N'BookNum'
GO

-- ----------------------------
-- Indexes structure for table SaleDetail
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SaleDetail
-- ----------------------------
ALTER TABLE [dbo].[SaleDetail] ADD PRIMARY KEY ([Id])
GO
