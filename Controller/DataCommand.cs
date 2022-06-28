using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCommand : SimpleCommand
{
    /// <summary>
    /// 消息命令处理函数
    /// </summary>
    /// <param name="notification"></param>
    public override void Execute(INotification notification)
    {
        Debug.Log("控制层接受命令，通知数据层进行数据处理");
        DataProxy dataProxy = Facade.RetrieveProxy(DataProxy.NAME) as DataProxy;
        dataProxy.BeDamage(Random.Range(0, 100)); //扣血

    }

}
