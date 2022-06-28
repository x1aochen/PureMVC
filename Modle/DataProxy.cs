using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Proxy;

/// <summary>
/// 数据助理
/// </summary>
public class DataProxy:Proxy
{
    //控制层通过名字获得
    public static new string NAME = "DataProxy";

    private Data data;
    public DataProxy() : base(NAME)
    {
        Debug.Log("构建数据助理层");
        data = new Data(100); //初始化数据
    }

    //数据处理
    public void BeDamage(int damage)
    {
        data.HP -= damage;
        //发送消息到视图，更新血条比例
        Debug.Log("数据处理完成，通知视图层更新");
        SendNotification(AppConst.UpdateHPBarMsg, data.HP * 1.0f / data.MaxHp); 
    }
}
