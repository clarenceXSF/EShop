/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for BookType
-- ----------------------------
DROP TABLE [dbo].[BookType]
GO
CREATE TABLE [dbo].[BookType] (
[Id] nvarchar(50) NOT NULL ,
[TypeCode] varchar(10) NOT NULL ,
[TypeName] nvarchar(200) NOT NULL ,
[ImgSrc] nvarchar(200) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookType', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookType', 
'COLUMN', N'TypeCode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'TypeCode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'TypeCode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookType', 
'COLUMN', N'TypeName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'TypeName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'TypeName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'BookType', 
'COLUMN', N'ImgSrc')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型图片'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'ImgSrc'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型图片'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'BookType'
, @level2type = 'COLUMN', @level2name = N'ImgSrc'
GO

-- ----------------------------
-- Indexes structure for table BookType
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table BookType
-- ----------------------------
ALTER TABLE [dbo].[BookType] ADD PRIMARY KEY ([Id])
GO
