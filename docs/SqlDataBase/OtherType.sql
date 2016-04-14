/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for OtherType
-- ----------------------------
DROP TABLE [dbo].[OtherType]
GO
CREATE TABLE [dbo].[OtherType] (
[Id] nvarchar(50) NOT NULL ,
[TypeName] nvarchar(50) NOT NULL ,
[TypeCode] int NOT NULL ,
[TypeContent] nvarchar(200) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'OtherType', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'OtherType', 
'COLUMN', N'TypeName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'OtherType', 
'COLUMN', N'TypeCode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型代号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeCode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型代号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeCode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'OtherType', 
'COLUMN', N'TypeContent')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'代号内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeContent'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'代号内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'OtherType'
, @level2type = 'COLUMN', @level2name = N'TypeContent'
GO

-- ----------------------------
-- Indexes structure for table OtherType
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table OtherType
-- ----------------------------
ALTER TABLE [dbo].[OtherType] ADD PRIMARY KEY ([Id])
GO
