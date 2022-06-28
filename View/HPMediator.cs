using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 视图层
/// </summary>
public class HPMediator:Mediator
{
    private Button btn;
    private Image hpBar;
    public static new string NAME = "HPMediator";
    public HPMediator(Transform canvas) : base(NAME) 
    {
        Debug.Log("构建视图层");
        hpBar = canvas.Find("HPBar").GetComponent<Image>();
        btn = canvas.Find("TestBtn").GetComponent<Button>();
        btn.onClick.AddListener(() => {
            Debug.Log("通知控制层执行对应命令");
            SendNotification(AppConst.ClickTestBtnCommand);
            });
    }

    /// <summary>
    /// 添加消息监听
    /// </summary>
    /// <returns></returns>
    public override string[] ListNotificationInterests()
    {
        List<string> msgList = new List<string>();
        //添加消息
        Debug.Log("视图层添加消息监听");
        msgList.Add(AppConst.UpdateHPBarMsg);
        msgList.Add(AppConst.ClickTestBtnCommand);
        
        return msgList.ToArray();
    }

    /// <summary>
    /// 处理消息
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        Debug.Log("接收数据层通知，进行视图更新  " + notification);
        
        switch (notification.Name)
        {
            case AppConst.UpdateHPBarMsg:
                //显示血条比例
                hpBar.transform.Find("Fill").GetComponent<Image>().fillAmount = (float)notification.Body;
                break;
            default:
                break;
        }
    }
}
