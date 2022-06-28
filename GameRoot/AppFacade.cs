using PureMVC.Patterns.Facade;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������
/// </summary>
public class AppFacade : Facade
{
    public AppFacade()
    {
        Debug.Log("ע��PureMVC����ģ��");
        //ע�����������
        RegisterProxy(new DataProxy());
        //ע����ͼ��
        RegisterMediator(new HPMediator(GameController.instance.Canvas));
        //ע����Ϣ����� ��Ϣָ�������ӦExcuteִ��
        RegisterCommand(AppConst.ClickTestBtnCommand,() => new DataCommand());
        
    }

}
