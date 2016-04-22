# EShop
风御轩网上书店

###远程仓库 `GitHub`
<https://github.com/clarenceXSF/EShop.git>
编写[markDown](https://github.com/clarenceXSF/EShop/edit/master/README.md)，可以在里面对本项目的reader进行编辑、修改

### myPlan
|步骤   |相关知识点  |完成时间   |
|--------|:-----------:|---------:|
|明确需求|    |    |
|编写设计|设计显示要求|  |
|配置环境|SoruceTree、Git、vs2013、SQL Server2012、Navicat| |
|完成数据库脚本| | |
|搭建项目框架|DAL、BLL、Common、Model、Web| |
|完成项目后台|EF、MVC4  | |
|前端设计开发|html、css、JavaScript、Amaze UI | |
|修复BUG| | |
|发布项目|IIS | |


### 项目的`目录`结构
```
EShop
|-- docs
|  |-- Sql脚本
|  |  |-- Init.sql
|  |  |-- sql2012
|  |  |-- Navicat运行脚本
|-- reader.md
|-- src
|  |-- EShop.Models                // 数据模型层
|  |  |-- ***.cs
|  |-- EShop.DAL                   // 数据访问层
|  |  |--Service              //实现类
|  |  |  |-- ***Service.cs
|  |  |-- I***Service.cs      //接口     
|  |-- EShop.BLL                   // 业务逻辑层
|  |  |-- Manager             //实现类
|  |  |  |-- ***Manager.cs
|  |  |-- I***Manager.cs      //接口
|  |-- EShop.Web
|  |  |--Controller           //控制器
|  |  |--Css                  //前端样式
|  |  |--Images               //图片路径
|  |  |--js                      
|  |  |  |--admin             //后台管理处理js
|  |  |  |--front             //前端界面处理js
|  |  |  |--lib               //js插件/工具
|  |  |--Scripts
|  |  |--Views                //视图
|  |-- EShop.Common                // 共用工具层
|  |-- packages
```
