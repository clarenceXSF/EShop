/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for Recommend
-- ----------------------------
DROP TABLE [dbo].[Recommend]
GO
CREATE TABLE [dbo].[Recommend] (
[Id] nvarchar(50) NOT NULL ,
[BookId] nvarchar(50) NOT NULL ,
[ShowImage] nvarchar(200) NOT NULL ,
[ShowTitle] nvarchar(100) NOT NULL ,
[CreateTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'Recommend', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'推荐编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'推荐编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'Recommend', 
'COLUMN', N'BookId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'BookId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'图书编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'BookId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'Recommend', 
'COLUMN', N'ShowImage')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'高亮图片显示'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'ShowImage'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'高亮图片显示'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'ShowImage'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'Recommend', 
'COLUMN', N'ShowTitle')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'高亮标题显示'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'ShowTitle'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'高亮标题显示'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'ShowTitle'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'Recommend', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'Recommend'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO

-- ----------------------------
-- Indexes structure for table Recommend
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Recommend
-- ----------------------------
ALTER TABLE [dbo].[Recommend] ADD PRIMARY KEY ([Id])
GO
