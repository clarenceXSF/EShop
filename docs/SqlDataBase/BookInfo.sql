/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for BookInfo
-- ----------------------------
DROP TABLE [dbo].[BookInfo]
GO
CREATE TABLE [dbo].[BookInfo] (
[Id] nvarchar(50) NOT NULL ,
[Name] nvarchar(50) NOT NULL ,
[Author] nvarchar(50) NULL ,
[PublishDate] date NULL ,
[Type] int NULL ,
[Price] money NULL ,
[Original] money NULL ,
[ISBN] nvarchar(50) NULL ,
[Describe] nvarchar(200) NULL ,
[CreateDate] date NULL ,
[Sale] int NULL DEFAULT ((0)) ,
[Stock] int NULL DEFAULT ((0)) 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Author')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书作者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Author'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书作者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Author'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'PublishDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'出版日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'PublishDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'出版日期'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'PublishDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Price')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'售价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Price'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'售价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Price'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Original')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'原价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Original'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'原价'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Original'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'ISBN')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图片链接'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'ISBN'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图片链接'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'ISBN'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Describe')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'描述信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Describe'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'描述信息'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Describe'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'CreateDate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'上架时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'CreateDate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'上架时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'CreateDate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Sale')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'销售量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Sale'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'销售量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Sale'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookInfo', 
'COLUMN', N'Stock')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'货存量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Stock'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'货存量'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookInfo'
, @level2type = 'COLUMN', @level2name = N'Stock'
GO

-- ----------------------------
-- Indexes structure for table BookInfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table BookInfo
-- ----------------------------
ALTER TABLE [dbo].[BookInfo] ADD PRIMARY KEY ([Id])
GO
