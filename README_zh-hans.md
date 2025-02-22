<img height="128" align="left" src="assets/logo.png" alt="Logo">

# 拯救者工具箱 Lenovo Legion Toolkit

[![Build](https://github.com/BartoszCichecki/LenovoLegionToolkit/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/BartoszCichecki/LenovoLegionToolkit/actions/workflows/build.yml)
[![Crowdin](https://badges.crowdin.net/llt/localized.svg)](https://crowdin.com/project/llt)
[![Join Discord](https://img.shields.io/discord/761178912230473768?label=Legion%20Series%20Discord)](https://discord.com/invite/legionseries)

---

联想拯救者工具箱 Lenovo Legion Toolkit (LLT) 是为联想拯救者系列笔记本打造的轻量化工具箱。可实现原来联想软件如 Lenovo Vantage、Legion Zone、联想电脑管家才可实现的功能。

**本软件仅适配拯救者系列，如果你不是拯救者系列笔记本则这个软件不适合你，请不要提出兼容 Issue ，如果提出将被直接关闭不作受理。**

本软件不运行后台服务，使用较少的内存，几乎不使用 CPU ，并且不收集用户信息。本程序仅适用于 Windows 。

**中文用户可加入[拯救者工具箱 QQ 频道](https://pd.qq.com/s/jj0737)，频道内推送正式版/测试版更新并附带国内镜像加速下载链接。**

加入 Legion Series Discord: https://discord.com/invite/legionseries!

<img src="assets/screenshot_zh_hans.png" width="700" alt="PayPal QR code" />


# 目录
  - [免责声明](#免责声明)
  - [下载](#下载)
  - [兼容性](#兼容性)
  - [功能介绍](#功能介绍)
  - [赞助](#赞助)
  - [贡献者](#贡献者)
  - [FAQ](#faq)
  - [如何开启记录Log](#如何开启记录Log)
  - [贡献此项目](#贡献此项目)

## 免责声明

**本软件非联想官方出品软件，使用需要自担风险。**

请仔细耐心地阅读本文档，以便了解关于本软件的一些重要信息。

## 下载

你可以在这里下载最新版本：[发行版页面 Releases page](https://github.com/BartoszCichecki/LenovoLegionToolkit/releases/latest)。或者使用 [winget](https://github.com/microsoft/winget-cli)：

`winget install BartoszCichecki.LenovoLegionToolkit`

#### 接下来的步骤

拯救者工具箱在后台运行时效果最好，所以去设置中启用_开机启动_和_关闭时最小化_。接下载就是在设置中禁用 Lenovo Vantage, Legion Zone 与 Lenovo Hotkeys，或者你也可以直接卸载他们。之后，拯救者工具箱将会在开机后自启并在后台一直保持运行，并接管 Lenovo Vantage, Legion Zone 与 Lenovo Hotkeys 的功能。

另，如果你完全关闭拯救者工具箱，一些功能将无法正常工作。例如同步不同的性能模式（Fn + Q）与电源计划，自动化功能的运行。

另外，请查看下方的 [兼容性](#兼容性) 部分。

#### 在安装 .NET 依赖时出现问题？

如果拯救者工具箱安装程序没有正确安装 .NET 依赖，则请按照以下步骤手动安装：

1. 打开 https://dotnet.microsoft.com/zh-cn/download/dotnet/6.0
2. 找到 “.NET 桌面运行时” 一栏；
3. 点击安装程序下的“X64”一栏下载安装程序；
4. 运行安装程序并按照指引进行安装。


在完成这些步骤后，你可以打开终端并输入： `dotnet --info`。在输出中寻找 "已安装的.NET运行时 "部分，你应该能看到类似的内容：

`Microsoft.NETCore.App 6.0.15 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]`

和

`Microsoft.WindowsDesktop.App 6.0.15 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]`

确切的版本号可能不同，但只要是`6.x.x`就应该没问题。如果经过上述步骤确认后，拯救者工具箱在启动时仍然报错提示找不到.NET之类的信息，那么就是你的机器或系统的问题，而不是拯救者工具箱的问题。

#### 想要帮助我们测试？

加入 [Legion Series Discord](https://discord.com/invite/legionseries) 并前往 `#legion-toolkit` 子频道，Beta 测试版与未来更新将会在那里频繁更新。

中文用户可加入 [拯救者工具箱 QQ 频道](https://pd.qq.com/s/jj0737) 并前往 `#测试版更新💻` 子频道，Beta 测试版将会经常在那里同步发布。

## 兼容性

拯救者工具箱适配 2020 款及其之后的拯救者机型。

一些功能在 2020 款之前发布的机型和 Ideapad Gaming 3 笔记本可以正常工作（或者说大部分工作），但可能会遇到一些小问题。这里是测试过支持的型号列表 [Compatibility.cs](https://github.com/BartoszCichecki/LenovoLegionToolkit/blob/master/LenovoLegionToolkit.Lib/Utils/Compatibility.cs)。

如果你在启动时看到不兼容弹窗，你可以查看底部的*贡献*部分，查看你能否帮助我适配你的机型。谨记我没有那么多的笔记本型号，所以一些功能我无法适配。

**拯救者系列与 Ideapad Gaming 系列之外的笔记本暂不考虑适配**

### 联想软件兼容

总的来说，建议在使用拯救者工具箱时禁用或卸载 Lenovo Vantage、Hotkeys 和 Legion Zone。当拯救者工具箱与其他联想应用程序一起工作时，可能会导致部分功能冲突或可能无法正常工作。

### 备注

拯救者工具箱目前不支持多用户安装，所以如果你的笔记本电脑上有多个用户，你可能会遇到兼容性问题，即使是没有管理员权限的账户。拯救者工具箱需要一个有管理员权限的账户，拯救者工具箱无法在普通账户上正常运行。

## 功能介绍

拯救者工具箱可以做到：

- 改变诸如性能模式、充电模式等只有通过 Lenovo Vantage、联想电脑管家才能更改的设置。
- 使用并修改自定义模式，包括 2022 款及更新的机型的调节风扇曲线功能。
- 支持调节 Spectrum RGB 键盘、4 分区 RGB键盘和白色背光的键盘。
- 强制休眠独立显卡（仅限英伟达显卡）。
- 查看电池统计数据。
- 下载、更新驱动。
- 通过自动化实现插入/拔出充电器的自动操作。
- 无需卸载即可禁用 Lenovo Vantage、Legion Zone 和 Lenovo Hotkeys 服务。

##### 自定义模式

以下版本的 BIOS 支持自定义模式：
* GKCN49WW 和更高
* H1CN49WW 和更高
* HACN31WW 和更高
* HHCN23WW 和更高
* K1CN31WW 和更高
* K9CN34WW 和更高
* KFCN32WW 和更高
* KWCN28WW 和更高
* J2CN40WW 和更高
* JUCN51WW 和更高
* JYCN39WW 和更高
* M3CN32WW 和更高
* M0CN27WW 和更高 

并非所有设备都支持自定义模式的所有功能。

##### 强制休眠英伟达显卡

有时独立显卡会一直保持活动状态。例如在你插上外接显示器并断开后，一些进程会继续使用独显上运行，导致续航骤减。

在拯救者工具箱中有两种办法强制休眠显卡。

1. 强制关闭所有在独显上运行的进程。（这种方式貌似更有效）,
2. 短暂强制禁用独立显卡，使在独显上运行的进程全部切换到核显。

当独显处于活动状态，并使用混合模式且没有外接显示器到独显上时，强制休眠显卡才会亮起。如果你将鼠标悬停在右侧的问号标志上，将会看到独显的状态与正在使用独显的进程。

注意，强制休眠显卡可能会导致一些应用崩溃。

#### 超频英伟达独立显卡
此超频选项用于简单的超频，类似于 Legion Zone 与 Vantage 中的超频。它并不打算取代微星小飞机（Afterburner）等工具。同时以下有几点你需要注意：
* 确保在 BIOS 中开启了 GPU 超频选项（如果你的电脑有的话）。
* 当 Vantage 或 Legion Zone 运行时，超频无法生效。
* 不建议在使用微星小飞机（Afterburner）等超频工具时使用此选项。
* 如果你之前修改过控制台，那么你需要点击“自定义”按钮并添加此选项才能看到此选项。

##### Windows电源计划

当切换性能模式时，拯救者工具箱会在 Lenovo Vantage 禁用的情况下自动切换 Windows 的电源计划。

但在一些笔记本上，Lenovo Vantage 不会切换电源计划。如果你的电脑不会自动切换电源计划，你可以在设置中设置不同性能模式对应的电源计划。这会让拯救者工具箱总是切换Windows电源计划即使 Lenovo Vantage 在后台运行。

##### CPU 睿频模式

启用了 S0 低功率模式（又名现代待机）的笔记本电脑，在多个电源计划的情况下会导致许多小问题，特别是性能电源计划。

## 赞助

开发不易，如果你觉得拯救者工具箱不错的话，可以考虑赞助以支持开发。

[使用PayPal赞助](https://www.paypal.com/donate/?hosted_button_id=22AZE2NBP3HTL)

<img src="LenovoLegionToolkit.WPF/Assets/Donate/paypal_qr.png" width="200" alt="PayPal QR code" />

## 贡献者

特别感谢：

* [ViRb3](https://github.com/ViRb3) 创建了 [Lenovo Controller](https://github.com/ViRb3/LenovoController)，这是拯救者工具箱的基础。
* [falahati](https://github.com/falahati) 创建了 [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper) 和 [WindowsDisplayAPI](https://github.com/falahati/WindowsDisplayAPI)
* [SmokelessCPU](https://github.com/SmokelessCPU) 帮助我适配了四分区 RGB 键盘背光。
* [Mario Bălănică](https://github.com/mariobalanica) 的所有贡献。

翻译贡献者：
* 保加利亚语 - [Ekscentricitet](https://github.com/Ekscentricitet)
* 中文 - [凌卡Karl](https://github.com/KarlLee830)
* 捷克语 - J0sef
* 荷兰语 - Melm, [JarneStaalPXL](https://github.com/JarneStaalPXL)
* 法语 - EliotAku, [Georges de Massol](https://github.com/jojo2massol), Rigbone, ZeroDegree
* 德语 - Sko-Inductor, Running_Dead89
* 希腊语 - GreatApo
* 意大利语 - [Lampadina17](https://github.com/Lampadina17)
* 卡拉卡尔帕克语 - KarLin, Gulnaz, Niyazbek Tolibaev, Shingis Joldasbaev
* 罗马尼亚语 - [Mario Bălănică](https://github.com/mariobalanica)
* 斯洛伐克语 - Mitschud, Newbie414
* 西班牙语 - M.A.G.
* 葡萄牙语 - dvsilva
* 葡萄牙语（巴西） - Vernon
* 俄语 - [Edward Johan](https://github.com/younyokel)
* 土耳其语 - Undervolt
* 乌克兰语 -  [Владислав «vaidee» Придатько](https://github.com/va1dee)
* 越南语 - Not_Nhan

## FAQ

#### 为什么我的杀毒软件报告安装程序含有病毒/木马/恶意软件？

拯救者工具箱使用了许多底层的 Windows API，杀毒软件可能会识别这些 API 的调用为可疑的，从而造成误报。拯救者工具箱本身是开源的，任何感觉此软件有问题的人可以很简单的审查此软件源代码。同时所有安装包都是直接在 Github 上使用 Github Actions 构建的，所以你也不需要担心安装包含有恶意内容。此问题可以通过对程序签名来解决，但此项目只是我业余时间来制作的开源项目，我无法负担每年花几百美元买一个证书。

简而言之，如果你从这个项目的网站上下载了安装程序，不需要担心杀毒软件的报毒，这只是一个误报。同时如果你有能力帮助解决杀毒软件的误报问题，欢迎联系我。

#### 更换主板后提示不兼容？

有时新主板内的机型和序列号信息出错，你可以尝试 [这篇教程](https://laptopwiki.eu/laptopwiki/guides/lenovo/legion_bios_lvarrecovery) 来恢复。如果这不起作用你可以尝试打开 `%LOCALAPPDATA%\LenovoLegionToolkit` 并创建一个名为 `args.txt` 的文件并打开文件后呼入 `--skip-compat-check` ，这会禁用拯救者工具箱的兼容性检查。我们建议你在无法正确恢复型号、序列号等信息的情况下再使用这个办法。


#### 为什么我无法在使用电池供电时切换到野兽与自定义模式？

在 2.11.0 版本后，拯救者工具箱与 Lenovo Vantage 与 Legion Zone 的行为保持一致，将不再允许在没有插入适当电源适配器的情况下启用野兽与自定义模式。

如果出于某种原因，你想在电池供电的情况下使用这些模式，你可以使用`--allow-all-power-modes-on-battery`参数来启用。请注意，当笔记本电脑没有连接到全功率的电源适配器时，功耗限制与其他设置在大多数设备上无法正常应用，同时可能会出现一些未知的问题。

我已经警告过你了，这是在无需全功率电源适配器便可强制启用全部性能模式的步骤：

1. 打开 `%LOCALAPPDATA%\LenovoLegionToolkit`；
2. 创建名为 `args.txt` 的文件（如果已经有了则编辑它）；
3. 在文件内粘贴 `--allow-all-power-modes-on-battery`；
4. 重启拯救者工具箱。

#### 支持 iCue RGB 键盘吗？

不支持，我推荐你看看 [OpenRGB](https://openrgb.org/) 这个项目。

#### 能不能多整一些 RGB 效果？

只有硬件支持的选项可用，不计划支持自定义效果。如果你想要自定义效果可以看看 [L5P-Keyboard-RGB](https://github.com/4JX/L5P-Keyboard-RGB) 或 [OpenRGB](https://openrgb.org/)。

#### 我可以在使用拯救者工具箱时使用其他RGB软件吗？

总的来说，可以。 当 Lenovo Vantage 运行时，拯救者工具箱将禁用 RGB 控制，以避免冲突。如果你想使用其他 RGB 软件，如 [L5P-Keyboard-RGB](https://github.com/4JX/L5P-Keyboard-RGB) 或 [OpenRGB](https://openrgb.org/)，你可以在拯救者工具箱中禁用 RGB 以避免冲突。

禁用 RGB 方法：
1. 打开 `%LOCALAPPDATA%\LenovoLegionToolkit`；
2. 在此处创建名为 `args.txt` 的文件。（如果已有，请编辑此文件。）；
3. 根据你的键盘型号，在文件夹内粘贴 `--force-disable-rgbkb` 或 `--force-disable-spectrumkb`。（如果此文件夹内已被添加了启动参数，请另起一行，保证每行一个参数。）；
4. 启动拯救者工具箱，

#### 2022 款之前的机器能否自定义调节风扇曲线？

如果你是 2022 款与更新的机型的拯救者，但不支持自定义风扇曲线的话，请提交 Issue，我们会尝试适配。2022 款之前的机型由于技术原因无法支持。

#### 为什么我锁定 Fn 键后的效果是反的？

一些设备确实有这个问题，坦率地讲，我也不知道。但如果你知道解决欢迎贡献代码！

#### 为啥在启用 Legion AI 引擎后切换性能模式看起来似乎有些问题？

貌似有些 BIOS 版本在使用 Fn+Q 快捷键时有一个奇怪的问题，你可以试试更新 BIOS，除此之外只能等联想修复它了。

#### 为何即使自动化配置正确，游戏检测仍无法正常触发？

拯救者工具箱的游戏检测功能是基于 Windows 游戏检测的。这意味着游戏检测功能仅能被 Windows 认为是游戏的 EXE 文件触发。同时如果你删除了 Xbox Game Bar，此功能大概率将无法正常工作。

Windows 可能无法正确识别所有的游戏，但你可以在 Xbox Game Bar (Win + G) 设置中将任何程序标记为游戏。你可以在注册表中找到可识别的游戏列表：`HKEY_CURRENT_USER\System\GameConfigStore\Children`。

#### 为什么将鼠标悬停在拯救者工具箱托盘图标上却看不到自定义工具提示？

在 Windows 10 和 11 中，微软对托盘做了大量的修改，修改导致了很多东西产生了变化，从而导致许多东西无法正常工作。因此，自定义工具提示有时会无法正常工作。你可以试试更新你的 Windows，除此之外没什么好办法了。

#### 我在哪里可以找到 CPU 睿频模式的设置？

简而言之，在 Windows 控制面板中。此选项因很难维护已经从拯救者工具箱中删除了。在拯救者工具箱的设置中，你可以找到一个直接跳转到控制面板中电源计划设置页面的按钮，在那里你可以轻松地编辑 CPU 睿频模式设置以及 Windows 电源计划的其他设置。

默认情况下，这个设置是隐藏的，但你也可以通过在终端运行`powercfg.exe -attributes sub_processor perfboostmode -attrib_hide`来重新打开这个选项。
另外我还推荐其他一些应用程序可以轻松地管理多个电源计划设置：[PowerSettingsExplorer](https://forums.guru3d.com/threads/windows-power-plan-settings-explorer-utility.416058/) 与 [QuickCPU](https://coderbag.com/product/quickcpu)。

#### 我可以自定义快捷键吗？

你可以在拯救者工具箱设置中自定义 Fn + F9（星星键，又名 Lenovo Smart 键） 热键。其他快捷键无法自定义。

#### 如果我超频 GPU 超多了怎么办？

如果你超频到 GPU 无法稳定运行，甚至无法启动 Windows 的情况，你可以通过以下两种方法尝试解决：

1. 进入 BIOS，尝试找到类似于 “Enabled GPU Overclocking” 与 “显卡超频”的选项并将其禁用，启动 Windows，修改拯救者工具箱中的超频参数，并将此选项再次启用。
2. 在安全模式下启动Windows，删除拯救者工具箱设置下的`gpu_oc.json`文件，该文件位于`"%LOCALAPPDATA%\LenovoLegionToolkit`。

## 如何开启记录Log

在一些情况下如果你能提交应用记录的日志信息，将会对我调试和解决问题十分十分有用。

记录 Log 日志的步骤：

1. 确保拯救者工具箱已关闭（后台也记得关掉）；
2. 打开 `运行` （使用 Win + R 打开）然后输入 `"%LOCALAPPDATA%\Programs\LenovoLegionToolkit\Lenovo Legion Toolkit.exe" --trace` 然后点击确定；
3. 拯救者工具箱将会启动并且可以在左上角能看到 `[LOGGING ENABLED]` ；
4. 复现你遇到的问题；
5. 关闭拯救者工具箱 （同样记得关掉后台）；
6. 然后打开 `运行` （使用 Win + R 打开）然后输入 `"%LOCALAPPDATA%\LenovoLegionToolkit\log"` ；
7. 这里就是存放日志文件的地方了，提 Issue 时记得一并提交。

## 贡献此项目

我感谢你们提交的任何反馈！不要犹豫，直接提交 Issue。我们也欢迎提交 PR，但提交 PR 前务必查看 [CONTRIBUTING.md](CONTRIBUTING.md) 文件！

#### 翻译

我们已选择 Crowdin 为翻译平台。如果你想提交翻译请访问 https://crowdin.com/project/llt 并申请权限。

#### Bugs

如果你发现了软件中的任何Bug和问题，请报告。如果你附上日志将会对我们发现问题的根本原因十分有帮助。 你可以在 `%LOCALAPPDATA%\LenovoLegionToolkit\log` 找到日志文件。提交issue时记得附上最新的日志文件！

#### 适配

如果能适配更多设备就更好了！但要做到这点，我真的很需要你的帮助！

如果你愿意在未适配的机型上试试这个软件，请在启动时点击弹窗的继续按钮，拯救者工具箱会自动打开日志记录，这样你就可以在提交issue时提交了！

*注意一些功能可能无法正常运行*

如果你在 Github 上提交 Issue 并附上你的测试结果和日志我将十分感谢你！

请确保在你提交的 Issue 中包含以下信息：

1. 完整的设备型号 (Legion Y9000X 2022款 IAH7)
2. 正常工作的功能
3. 出错的功能
4. 会导致崩溃闪退的功能

你提交的信息越多，随着时间的推进，拯救者工具箱就会变得越来越好！如果有什么出错的地方请准确写下问题并附上日志。(日志保存地址 `%LOCALAPPDATA%\LenovoLegionToolkit\log`). 



万分感谢！
