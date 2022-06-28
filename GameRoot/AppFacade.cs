using PureMVC.Patterns.Facade;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 框架入口
/// </summary>
public class AppFacade : Facade
{
    public AppFacade()
    {
        Debug.Log("注册PureMVC三层模型");
        //注册数据助理层
        RegisterProxy(new DataProxy());
        //注册视图层
        RegisterMediator(new HPMediator(GameController.instance.Canvas));
        //注册消息命令层 消息指令触发，对应Excute执行
        RegisterCommand(AppConst.ClickTestBtnCommand,() => new DataCommand());
        
    }

}
