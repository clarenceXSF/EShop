--创建一个客户对象 coco 密码：123456
INSERT INTO [EShop].[dbo].[UserInfo] ([Id], [LoginId], [LoginPwd], [Name], [Phone], [Email], [State], [Role], [Score], [CreateTime]) 
VALUES (N'5c3db439-7efb-4920-88a2-b5149797d74c', N'coco', N'123456', N'小克', N'13726216666', N'coco@qq.com', '1', '1', '50', '2016-04-06 19:11:52.000');
GO
--创建一个管理员 chen 密码：123456
INSERT INTO [EShop].[dbo].[UserInfo] ([Id], [LoginId], [LoginPwd], [Name], [Phone], [Email], [State], [Role], [Score], [CreateTime]) 
VALUES (N'ae0c59fb-4cbd-4af7-a955-6454803c9a5e', N'chen', N'123456', N'小陈', N'13726219988', N'123@qq.com', NULL, '98', NULL, '2016-04-14 21:02:02.383');
GO


--图书类型初始化数据
INSERT INTO [dbo].[BookType] ([Id], [TypeCode], [TypeName], [ImgSrc]) VALUES (N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'B00', N'科技/建筑/工业', N'/Images/bookType/keji.jpg')
GO
GO
INSERT INTO [dbo].[BookType] ([Id], [TypeCode], [TypeName], [ImgSrc]) VALUES (N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'C00', N'少儿/童书/儿童文学', N'/Images/bookType/shaoer.jpg')
GO
GO
INSERT INTO [dbo].[BookType] ([Id], [TypeCode], [TypeName], [ImgSrc]) VALUES (N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'D00', N'生活/旅游/休闲', N'/Images/bookType/shenghuo.jpg')
GO
GO
INSERT INTO [dbo].[BookType] ([Id], [TypeCode], [TypeName], [ImgSrc]) VALUES (N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'A00', N'人文社科/哲学', N'/Images/bookType/renwen.jpg')
GO
GO


--图书初始化数据
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'00a37f74-da09-441c-91e9-3169cc08d110', N'明朝那些事儿', N'当年明月', N'2011-12-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'125.5000', N'208.6000', N'/Images/book/mingchaonaxieshi.jpg', N'《明朝那些事儿》这篇文主要讲述的是从1344年到1644年这三百年间关于明朝的一些事情，以史料为基础，以年代和具体人物为主线，并加入了小说的笔法，对明朝十七帝和其他王公权贵和小人物的命运进行全景展示，尤其对官场政治、战争、帝王心术着墨最多，并加入对当时政治经济制度、人伦道德的演义', N'2016-04-17', N'50', N'60')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'1181dbbe-84e7-44c8-ace0-7e89c834ad03', N'王阳明全集', N'马昊宸', N'2014-12-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'140.0000', N'1580.0000', N'/Images/book/wangyangmingquanji.jpg', N'《王阳明全集》是研究王阳明心学思想及王阳明一生最重要的著作，是儒家思想中个性、争议的代表作，同时也是一部现代人成功修身、强大个人内心的励志作品。 王阳明提出的“知行合一”“致良知”“心即理”等命题，受到后人的广泛推崇。严复、梁启超、孙中山、蒋介石等都是“阳明心学”的追随者。其学术思想在日本、朝鲜半岛以及东南亚国家乃至全球都有重要影响。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'11e1e272-d3f2-4406-9847-2abf4dede6f3', N'仙篮奇剑传 ', N'孙幼军', N'2014-03-15', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'33.0000', N'66.0000', N'/Images/book/xianlanqijianzhuan.jpg', N'', N'2016-04-16', N'20', N'50')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'187222b5-50f1-4530-ae61-4f6b1b566e11', N'时间简史', N'史蒂芬·霍金', N'2002-02-15', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'27.0000', N'45.0000', N'/Images/book/shijianjianshi.jpg', N'该书内容是关于宇宙本性的最前沿知识，但是从那以后无论在微观还是宏观宇宙世界的观测技术方面都有了非凡的进展。这些观测证实了霍金教授在该书第一版中的许多理论预言，其中包括宇宙背景探险者卫星（COBE）的最近发现，它在时间上回溯探测到离宇宙创生的30万年之内，并显露了他所计算的在时空结构中的涟漪。', N'2016-04-17', N'0', N'40')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'19b5c737-b959-4413-a9ae-567a2ddeb7a3', N'中国自助游', N'中自编辑部', N'2015-08-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'27.0000', N'45.0000', N'/Images/book/zhongguozizhuyou.jpg', N'伴随着众多忠实读者的支持，《中国自助游》已经走过了十余载春秋。渐渐地我们成为了许多读者不可或缺的亲密游伴，愿我们继续一同走下去，走得更远，走得更深，走遍世间的每一个角落。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'1ff6adea-445b-48a9-b287-d0fad88e73dc', N'你眼中的星光', N'马传思', N'2016-01-01', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'21.3000', N'25.0000', N'/Images/book/niyangzhongdexingguang.jpg', N'在一场台风来临时，六年级女生阮小凡看到一幕怪异的景象：一只硕大的章鱼从街上爬过。此后，一连串怪事接连发生：她的小狗失踪;她的妈妈出现反常举动;她所居住的海滨小城的“市标”——一座大铁锚雕塑，居然也凭空消失了!

　　此后，阮小凡遇到一个研究地外文明的社团。他们联起手来，去探寻这些怪异事件背后的秘密，最终发现了一个惊人的事实……', N'2016-04-16', N'15', N'200')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'2559682f-3116-42d9-bea3-34ac2b041e5f', N'极简宇宙史', N'加尔法德', N'2016-03-10', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'29.7000', N'49.5000', N'/Images/book/jijianyuzhoushi.jpg', N'霍金亲传弟子、物理学博士克里斯托弗·加尔法德带领我们踏上一场关于宇宙的过去、现在和未来的惊奇之旅。不需要图表和方程式，只需凭着奇诡的想象，我们就可走向衰亡的太阳表面，飞越遥远的星系，感受来自黑洞的死亡魅力……你可以轻松读懂时至今日的宇宙神奇，继续探究关于上帝的存在、时间的起源以及人类的未来。', N'2016-04-17', N'0', N'50')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'3739c864-5ef5-4d90-9d32-1d8677c5bd52', N'图解微反应', N'博煜', N'2016-04-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'29.8000', N'35.0000', N'/Images/book/tujieweifangying.jpg', N'世界如此残酷，你要看准人心！识人准到骨子里，准确映射人类本能！', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'46a881a0-445b-48e6-bb15-069b2a148460', N'算法导论', N'Thomas H.Cormen', N'2013-01-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'87.0000', N'128.0000', N'/Images/book/suanfadaolun.jpg', N'在有关算法的书中，有一些叙述非常严谨，但不够全面；另一些涉及了大量的题材，但又缺乏严谨性。本书将严谨性和全面性融为一体，深入讨论各类算法，并着力使这些算法的设计和分析能为各个层次的读者接受。全书各章自成体系，可以作为独立的学习单元；算法以英语和伪代码的形式描述，具备初步程序设计经验的人就能看懂；说明和解释力求浅显易懂，不失深度和数学严谨性', N'2016-04-17', N'0', N'20')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'49de0503-cfe9-4827-aaff-9d2febf2e8de', N'你喜欢哪颗星', N'马翠萝', N'2016-04-01', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'14.3000', N'16.8000', N'/Images/book/nixihuannakexing.jpg', N'', N'2016-04-16', N'20', N'50')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'4a285244-b80d-439a-bff5-ad8a83023da2', N'土木工程专业毕业设计指导', N'梁兴文', N'2014-05-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'43.2000', N'48.0000', N'/Images/book/tumugongchengzybysjzd.jpg', N'《土木工程专业毕业设计指导》可作为高等院校土木工程专业的教学辅导材料，也可供相关专业的设计、施工和科研人员参考。本书由西安建筑科技大学土木工程学院的梁兴文编写。', N'2016-04-17', N'5', N'20')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'54916364-e912-4ba5-a455-81f03ccbcf4f', N'一个人不要怕：完美升级版', N'素黑', N'2013-12-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'19.0000', N'38.0000', N'/Images/book/yigerenbuyaopa.jpg', N'新增一辑素黑个人唯美心语写真，让你从她鲜为公开的多面体中反照自己；教你在生命中如何时刻保持清醒与觉知，如何与自己爱在一起，以及如何与内在本体重新建立深刻的连接。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'688b1dab-0202-40c6-84f1-e81aeca06333', N'耶路撒冷三千年', N'西蒙·蒙蒂菲奥里', N'2015-01-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'44.5000', N'78.0000', N'/Images/book/yelusalengsanqiannian.jpg', N'西蒙·蒙蒂菲奥里以客观、中立的角度，依年代顺序，生动讲述了耶路撒冷的故事。透过士兵与先知、诗人与国王、农民与音乐家的生活，以及创造耶路撒冷的家族来呈现这座城市的三千年瑰丽历史，还原真实的耶路撒冷……', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'6900aa91-2993-47a8-9e1a-92b0bee5f077', N'唐诗三百首', N'顾青', N'2016-01-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'20.3000', N'26.0000', N'/Images/book/tangshisanbaishou.jpg', N'家喻户晓的唐诗选本，学习唐诗的入门书籍', N'2016-04-17', N'2', N'100')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'73768f85-0b6c-44d2-a618-2dbc171a5857', N'笔记大自然', N'（美）莱斯利', N'2008-06-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'40.3000', N'49.8000', N'/Images/book/bijidaziran.jpg', N'这是一本指导如何给大自然书写日记的入门书。
克莱尔和查尔斯是美国著名的自然观察家、艺术家、教育家。他们用两种指尖艺术——书写与绘画，来传递大自然的色彩与神奇。
在日记的字里行间，有流动的色彩，有疑固的字迹；有停驻的脚步，有飞扬的神思……其美感难以言喻，其宇静无以形容……似乎，所有珍贵而不被注意的，都选择隐遁在这朴素的一本书里。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'777b4eae-ddf6-4853-a4fe-752431dedf62', N'通俗天文学', N'西蒙·纽康', N'2012-11-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'23.9000', N'39.8000', N'/Images/book/tongshutianwenxue.jpg', N'本书针对天文爱好者，从宇宙结构讲起，详细介绍了夜空中著名的恒星、行星、星团、星系以及彗星、流星和极光等，并介绍了各种观测方法，既包括目视观测，也包括使用双筒望远镜和天文望远镜观测。本书用流畅的文字、形象的描述、精准的插图将复杂的天文知识直观化、亲切化，让天文学这一名词变得不再高深得触不可及。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'8edeebbe-b1de-43e7-aac3-b9e34fa65dac', N'时尚美食馆--新编家常菜谱2000例', N'朱太治', N'2010-01-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'14.9000', N'29.8000', N'/Images/book/shishangmeishiguan.jpg', N'精选大众最爱吃的经典家常菜，将菜细分为家常凉菜、家常炖补、养生汤、家常小炒、猪肉类、羊肉类、蔬菜类等32大类。更为喜爱寿司、饮品、甜点的时尚人群和重视四季养生的人群编写了专门的食谱。每个菜品均详细介绍了原料、做法和特点，配以彩色成品图，查阅方便，清晰明了，是极好的家庭烹饪指导书。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'90e02b0b-5e26-4b4c-b22d-de687dfe6519', N'重口味心理学书系6册套装', N'姚尧', N'2014-06-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'118.1000', N'196.8000', N'/Images/book/zhongkouweixinlixue.jpg', N'不看小清新，就看重口味。重口味是生活方式，是发泄，也是寄托，是所有人的潜在欲望。《重口味心理学》《欲望心理学》《盲目心理学》《自我疗愈心理学》《怪异性格心理学》《幸运心理学》', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'9980a2c5-3220-4f26-9509-ba06644b96ee', N'和二木一起玩多肉', N'二木', N'2013-06-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'24.0000', N'48.0000', N'/Images/book/heermuyiqiwanduorou.jpg', N'内容涉及了多肉基本知识、选苗购买、日常养护、多肉品种图谱、繁殖技巧、多肉混植、DIY园艺小品等方方面面。实用细致又不失华丽，是一本全面精美的多肉百科全书。字里行间都能感受到二木用心呵护多肉的热情与执着，适合每一个“多肉控”。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'9b0e852a-444c-4105-9728-c834f4ed503f', N'草房子', N'曹文轩', N'2009-06-01', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'10.5000', N'18.0000', N'/Images/book/caofangzi.jpg', N'这本少年长篇小说主要讲述了一个少年男童的小学6年生活，其中有他亲眼目睹或直接参与了一连串看似寻常但又催人泪下、撼动人心的故事：少男少女之间毫无瑕疵的纯情，不幸少年与厄运相拼时的悲怆与优雅，残疾男孩对尊严的执著坚守，垂暮老人在*后一瞬所闪耀的人格光彩，在死亡体验中对生命的深切而优美的领悟，大人们之间扑朔迷离且又充满诗情画意的情感纠葛……', N'2016-04-16', N'0', N'50')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'a24df7fe-7cad-46b6-831b-ee994445927b', N'SAP2000中文版使用指南', N'金土木', N'2012-01-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'74.6000', N'98.0000', N'/Images/book/sap2000zwbsyzn.jpg', N'SAP2000中文版是专门为中国工程设计人员和科研人员开发的具有中文界面和中国最新规范的通用结构分析与设计软件系统。本书配合SAP2000中文版的使用而编写，其内容涵盖了SAP2000基本概念、建模功能、分析功能和设计功能，并且针对SAP2000的高级分析技术和各种类型的结构形式，阐述了SAP2000在工程中的具体应用并进行了相关讨论。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'aacc8128-1a1c-49f1-9070-05d275ed4b8d', N'查理九世：雪山巨魔（26） ', N'雷欧幻像', N'2016-04-01', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'8.9000', N'15.5000', N'/Images/book/chalijiushi26.jpg', N'《查理九世》是一套赞美成长勇气、鼓励科学探索、倡导人文关怀的大型原创精品儿童冒险小说，也是一套游戏故事书。每册书由一个主要故事、几个小案件、结合其他有趣的互动游戏组成。惊险神秘，妙趣横生！挑战头脑，快乐无边！目前已出版26册，销量超过5000万册！第26册将于2016年3月下旬重磅上市，跟随DODO冒险队开始新的旅程吧！', N'2016-04-16', N'0', N'70')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'ae0faa28-02a7-4623-83eb-001a19e7a167', N'为何爱会伤人', N'武志红', N'2012-12-12', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'19.5000', N'39.0000', N'/Images/book/weiheaihuishangren.jpg', N'我们所知道的关于爱情的知识，多数其实是关于迷恋的。 迷恋的爱，是虚假的你与幻想中的对象之恋爱。因而，我们发展出种种爱情的病来。真要走到真爱，就必须活出真实的自己，同时看到并尊重对方的真实存在。本书从全新的视角解读爱情，提出从“认识自己内心”的角度来看待爱情。爱情出现问题，往往不是对方的原因，而是你自己的内心出了偏差。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'b881e9e4-e072-4754-b978-37a584655937', N'一日一花', N'川濑敏郎', N'2014-02-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'70.8000', N'118.0000', N'/Images/book/yiriyihua.jpg', N'在东日本大地震后，川濑敏郎从2011年6月开始的一年，用古老、质朴、布满历史痕迹的器皿当做花器，依据时节到山野里找最当令的花叶，融入花器中，并持续在网上连载“一日一花”专栏，广受好评后汇编成这一册精美的图鉴。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'bbd1fb81-4239-4bfd-b509-8aa1ba59089c', N'我是一只狐狸狗', N'林良', N'2014-08-08', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'16.8000', N'20.6000', N'/Images/book/woshiyizhihuligou.jpg', N'《小太阳》里那只不说话的狐狸狗斯诺眼里的家：一个温馨的家庭：勤劳少言的妈妈，爱看书的爸爸，努力学习的大女儿，安静的二女儿，还有古灵精怪、调皮的小女儿。作品以狐狸狗对家庭成员的印象为开篇，以这只狗来到这个家庭的几件趣事为内容，向我们娓娓道来。作品的主题与其说是怀念与这只狗在一起的日子，不如说是通过这只狗来回忆家里的温馨往事。尤其是描写小狗离开的情节，作者刻意描写得轻松，顺理成章，给人留下深深的回味。', N'2016-04-16', N'10', N'40')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'bc2c8941-b0ca-48ed-b6ae-2cf64f6672a8', N'山海经（白话全译彩图版）', N'徐客', N'2012-03-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'40.8000', N'68.0000', N'/Images/book/shanhaijing.jpg', N'中国创世史诗，上古奇幻巨著！上古人文、自然宝典，充满光怪陆离的想象力，全系列畅销100万册典藏图书。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'c1d86763-83cb-4b86-b8e5-3e3832a37764', N'hello，早餐', N'子瑜妈妈', N'2013-07-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'19.9000', N'39.8000', N'/Images/book/hellozaocan.jpg', N'每天都有丰盛的早餐，是件非常幸福的事情。美美地吃上一顿早餐，可以让早餐带来的满足感唤醒我们慵懒的身体，让身体的每一个细胞都充满着正面的能量，让我们信心百倍地迎接新的一天。', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'cb6b04a4-4227-4f5e-9045-87ed7d5903e0', N'守护者系列（5册/套）', N'（日）上桥菜穗子', N'2011-04-02', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'50.0000', N'100.0000', N'/Images/book/jinglingshouhuzhe.jpg', N'这是一套风靡日本的幻想类儿童文学，其中《精灵守护者》已被改编成电视动画，在多国播出，获选为2007年第十一回日本文部省文化厅媒体艺术祭动画部门推荐的作品。
作品在通过一个幻想的世界，向读者展示了人类非凡的勇气和博大的爱。作品的张力让人读来痛快淋漓，而其中蕴含的深意更启人掩卷沉思。相信对今天的中国青少年乃至成人，能从书中找到非同寻常的生命的力量。', N'2016-04-16', N'0', N'80')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'd6c585dc-df86-4582-ae8a-7b88f4063d21', N'数独游戏技巧——从入门到精通', N'刘玲丽', N'2012-01-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'11.9000', N'19.9000', N'/Images/book/shuduyouxijiqiao.jpg', N'听说数独很好玩，对锻炼脑力也很有帮助，可是不知道怎么入门？
一般的数独题也能解出来，但是往往耗费的时间比较长？
遇到比较难的数独题经常卡死，一卡就是好长时间？', N'2016-04-17', N'16', N'40')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'db984c37-cc01-42a3-818c-aef024ed92e3', N'自卑与超越 ', N'阿德勒', N'2015-08-01', N'bfc7709b-e1d2-412a-8d77-11b1dbf5352b', N'16.0000', N'32.0000', N'/Images/book/zibeiyuchaoyue.jpg', N'西方心理学大师久负盛名之典籍，对于生命存在意义有科学依据的探索总结。精神分析领域重要参考读物，影响了马斯洛、华生、罗杰斯等众多心理学大师。问世以来不断再版，白岩松推荐阅读', N'2016-04-17', N'0', N'0')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'dc921d07-d2f9-4abb-ab16-e95d829c89b3', N' 神奇校车·动画版（全10册） ', N'乔安娜柯尔', N'2011-04-01', N'58d6f6e9-4c0c-462a-bf6f-32962103a213', N'55.2000', N'80.0000', N'/Images/book/shenqixiaoche.jpg', N'', N'2016-04-16', N'0', N'60')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'f1b013b0-3d96-40b0-8eca-8e255d4d9607', N'Revit 20132014建筑设计火星课堂', N'廖小烽', N'2013-08-01', N'46e6bc18-2599-4356-93a0-88244f60fdf8', N'64.8000', N'1.8000', N'/Images/book/revitjianzhushejihxkt.jpg', N'2003年开始从事建筑设计工作，2005年转入Revit系列软件的推广工作，曾参与清华大学《中国建筑信息模型标准框架研究》系列BIM标准研究工作，为华东建筑设计研究院、上海联创设计有限公司、中国水电顾问集团昆明勘测设计研究院等多个行业内领先的客户提供BIM咨询、培训等服务，具备丰富的revit应用和教学经验。', N'2016-04-17', N'0', N'50')
GO
GO
INSERT INTO [dbo].[BookInfo] ([Id], [Name], [Author], [PublishDate], [Type], [Price], [Original], [ISBN], [Describe], [CreateDate], [Sale], [Stock]) VALUES (N'fb547679-8f36-4a69-87d8-991fa431c391', N'玩转魔方', N'陈学思', N'2014-09-01', N'7e46edff-3f8c-4384-bd94-a6ed6dcf0504', N'19.8000', N'39.8000', N'/Images/book/wanzhuanmofang.jpg', N'书中的各种知识点作者都尽量以浅显易懂的叙述方式来展现。而且针对三阶从入门方法到高级方法，作者特意添加了一个“提高篇”来进行过渡，里面针对入门方法中的步骤，介绍了一些新技巧，对于后面继续学习打下基础，使得高级方法的学习更加顺利。
本书由百度魔方吧吧主和四川大学华西魔方协会创始人倾力打造，更有魔方界专业人士倾力推荐，中国第五位大满贯选手、中科大魔方协会创始人专文推荐。', N'2016-04-17', N'0', N'0')
GO
GO