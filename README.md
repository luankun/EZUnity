# EZUnity

## 常用组件

- [EZPhysicsBone](Assets/EZUnity/Demo/EZPhysicsBone/README.md): 动态骨骼，效果参考来源于AssetStore上的DynamicBone。优势: 支持所有碰撞体（包括MeshCollider，但效果一般）；独立的材质"EZPhysicsBoneMaterial"存放参数，通用性强；代码可读性高，碰撞体可通过继承EZPhysicsBoneColliderBase进行自定义扩展
- [EZAnimation](Assets/EZUnity/Demo/EZAnimation/README.md): 插值动画组件，有一个可以可视化编辑移动轨迹的EZTransformAnimation（支持贝塞尔曲线移动）

## 功能菜单（EZUnity/..）

- Save Assets: Editor下部分资源的修改不会立马写入到磁盘，使用该菜单强制存档资源
- Renamer: 批量重命名工具窗口，支持正则式匹配，整理资源目录很方便
- Guid Generator: 生成Guid的工具窗口
- Asset Bundle Manager: [Obsolete]老的Bundle管理工具
- PlayerPrefs Editor: PlayerPrefs编辑工具，目前只有Win下可以用

## 附加设置 ([Edit/ProjectSettings/EZUnity/..](Assets/EZUnity/Demo/EZProjectSettings/README.md))

- EZEditorSettings: 开启某些选项能提高工作效率
- EZGraphicsSettings: 提供更加方便的界面来管理AlwaysIncludedShaders，其他功能开发中
- EZScriptSettings: 提供脚本模板的管理功能

## 附加资源 ([Asset/Create/EZUnity/...](Assets/EZUnity/Demo/CustomAssets/README.md))

- EZImageCapture: 截图工具
- EZPlayerBuilder: Build Player Pipeline，打包工具。
- EZBundleBuilder: Build Bundle Pipeline，AssetBundle构建工具。两种模式：  
  - EZMode: 偏向目录结构管理，设置bundle名称、路径和文件搜索条件去进行build。
  - Manager Mode: 偏向单个资源设置，会读取当前项目中Inspector中对单个资源的bundle设置。
- EZScriptStatistics: 用来统计代码量的工具，可以通过正则式来对代码文件进行分类统计，需要预先对代码模板进行设置。通过指定IncludePaths、ExcludePaths和正则式匹配来统计代码

## 资源生成器 ([Asset/Create/EZUnity/EZAssetGenerator/...](Assets/EZUnity/Demo/EZAssetGenerator/README.md))

- EZMeshGenerator:
  - EZPlaneGenerator: 用来生成自定义平面网格的工具
- EZTextureGenerator:
  - EZTextureChannelModifier: 用来调整图片通道的工具
  - EZGradientGenerator: 使用渐变和坐标曲线生成图片的工具

## 一些比较有意思的Shader ([Materials](Assets/EZUnity/Demo/Materials/README.md))

- Reflection: 反射
- Fur: 毛发
- Matcap: Material Capture
- ColorFilter: RGB转灰阶，HSV校色
- StripeCutoff: 条纹渐隐/渐出
- MultiTexture3x: 多贴图叠加
- Pattern: 坐标花纹
- DynamicFlame: 动态火焰
- DynamicLiquid: 动态液体效果（折射，色散）

## 基于XLua的逻辑热更方案（需要加宏'XLUA'启用）

- [XLuaExtension](Assets/EZUnity/XLuaExtension/README.md)
- [Example](Assets/Example/README.md)

-----

东西较杂，但所有代码都尽可能保证可读性，方便大家作为逻辑参考根据自己的需求简化代码或者重新实现  
QQ：361994819 欢迎留言

2019-04-18:

- 参考[Unity Package Layout](https://docs.unity3d.com/2019.1/Documentation/Manual/cus-layout.html)调整了整个项目的文件布局，代码也做了相应的调整

2019-02-22:

- 示例中使用了Nested Prefab，请使用2018.3以上打开，RuntimeVersion使用.Net4xEquivalent
- Shader的名称重新规划

2019-01-26:

- 优化了一些命名空间
- XLua的配置文件放到了XLuaExample下面
- **`EZLuaInjector`(`EZPropertyList`)做了List和Map两种表现形式的整合，之前使用'#'来指定List编号的方式废弃**
- 编辑器扩展放到了统一的Editor目录下
- 动态骨骼`EZPhysicsBone`的实现完成

2018-10-16:

- 本次提交有**相当大的改动**
- 测试使用的版本是**2018.2.7f1，旧版本可能无法打开**
- 目录结构优化，移除了部分第三方插件的依赖；XLua的扩展部分放到了一个目录，不需要的可以删除；如果使用`EZUnity.Framework`，文件存放位置放到了"工程目录/EZPersistent"下（以前在"工程目录/Assets/EZUnity"下）
- 取消了一些在固定目录下生成自定义Asset并打开自定义Window的选项，所有自定义Asset都需要通过`Assets/Create/EZUnity`菜单(同Project视图下的右键)进行创建，并在Inspector视图下编辑
- 命名空间统一以`EZUnity`开头
  - `EZUnity.Famework`（以前的`EZFramework`，优化了很多东西）
  - `EZUnity.XLuaExtension`（这部分需要加宏`XLUA`启用）

2018-04-04:

- 补了一些之前可能误删的文件
- Unity升级到2017.4.0f1，代码没有任何变动
- EZScript添加模板报错的问题，请在使用前手动为Unity的安装目录添加访问权限：Users-Write

2018-03-28:

- Unity升级到2017.3.0f3
- 目录重新整理了一下
- 把一些由于历史原因不能更改的东西改掉了

2018-02-11:

- 加了一些说明文档，直接导入项目中使用的同学可以参考

2017-09-19（重构）:

- EZFramework升级了xLua，比较重要的是dictionary的索引方式把setter也去掉了，需要自己实现方法代替
- EZUnityTools分成几个部分，命名空间和目录结构都有变化，自定义编辑器扩展的命名空间和菜单栏改成了"EZUnityEditor"
- meta文件我是尽量没有做过删除动作，但有可能有过误操作造成meta文件重新生成的情况，不建议直接更新

2017-08-17:

- 放于github的目的只是方便自己工作，个人能力不足精力有限，暂时不会有demo。。。需要完整解决方案的，github可以搜到很多优秀的开源项目