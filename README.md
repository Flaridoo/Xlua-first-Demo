# Xlua-first-Demo
Tencent Xlua in Unity Project

* 项目下载下来可以直接运行。
* 可以看出来很简单，直接写两个运行脚本Mains.cs和Cubes.cs文件挂载到场景里。在运行时Main脚本里会执行读取hotfix.lua文件里的lua命令。hotfix里就是覆写Cubes里的Update方法，打印消息。
* 有的童鞋在官方Github上下载了安装文件之后，打静态Hotfix标签不起作用，这是因为官方提供的Xlua安装文件有问题。有问题的文件是Tools文件里面的XLuaHotfixInject.exe文件和Assets->Xlua->Src里的文件。这里我提供的是正常的，放心使用。
