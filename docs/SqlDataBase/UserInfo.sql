/*
Navicat SQL Server Data Transfer
Source Database       : EShop
*/


-- ----------------------------
-- Table structure for UserInfo
-- ----------------------------
DROP TABLE [dbo].[UserInfo]
GO
CREATE TABLE [dbo].[UserInfo] (
[Id] nvarchar(50) NOT NULL ,
[LoginId] nvarchar(50) NOT NULL ,
[LoginPwd] nvarchar(50) NOT NULL ,
[Name] nvarchar(50) NULL ,
[Phone] nvarchar(50) NULL ,
[Email] nvarchar(100) NULL ,
[State] int NULL ,
[Role] int NULL ,
[Score] int NULL ,
[CreateTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户编号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'LoginId')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'登录名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'LoginId'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'登录名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'LoginId'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'LoginPwd')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'登录密码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'LoginPwd'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'登录密码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'LoginPwd'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'真实姓名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'真实姓名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'联系电话'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Email')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'邮箱号码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Email'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'邮箱号码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Email'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'State')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'State'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'State'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Role')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户角色'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Role'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户角色'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Role'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'Score')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户积分'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Score'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户积分'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'Score'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'UserInfo', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'UserInfo'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO

-- ----------------------------
-- Indexes structure for table UserInfo
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table UserInfo
-- ----------------------------
ALTER TABLE [dbo].[UserInfo] ADD PRIMARY KEY ([Id])
GO
