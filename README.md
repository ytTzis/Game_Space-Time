# Game_Space-Time

## 项目环境

- Unity 版本：`2022.3.62f3`
- 推荐分支：`main`
- 当前使用平台：`Windows`

## 主要依赖包版本

项目最近一次打开和更新时使用的关键包版本如下：

- `com.unity.inputsystem`：`1.14.0`
- `com.unity.cinemachine`：`2.10.3`
- `com.unity.textmeshpro`：`3.0.7`
- `com.unity.timeline`：`1.7.7`
- `com.unity.postprocessing`：`3.4.0`

当前包管理源为：

- `https://packages.unity.com`

项目打开时出现缺少包或包版本错误的话，确认：

1. Unity Editor 版本是否为 `2022.3.62f3`
2. Package Manager 是否能够访问 `packages.unity.com`
3. `Packages/manifest.json` 和 `Packages/packages-lock.json` 是否已正确拉取

## 项目打开步骤

1. Clone 或 Pull 最新的 `main` 分支
2. 使用 Unity Hub 通过 `2022.3.62f3` 打开项目
3. 等待包恢复和脚本编译完成
4. 如果 Input System 提示重新导入或重新生成，请允许 Unity 执行完成
5. 确认 `Assets/Scripts/Config/Input/InputController.cs` 没有报错

## 当前重点内容

- `Assets/1_GameScene.unity`
  - 心率可视化原型
- `Assets/3_GameScene.unity`
  - 赛博朋克灯光调整
  - 心率可视化迁移与参数调整
- `Assets/2_Game Scene.unity`
  - 环境与地图结构仍在继续完善

## 同步说明

- `Scene 3` 当前已经包含心率可视化相关对象和灯光调整内容
- 本次同步同时更新了项目设置和包版本
- 如果项目打开时报版本不一致，请先以本 README 中记录的 Unity 版本和包环境为准，再排查场景或脚本问题
