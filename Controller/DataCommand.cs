using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCommand : SimpleCommand
{
    /// <summary>
    /// ��Ϣ�������
    /// </summary>
    /// <param name="notification"></param>
    public override void Execute(INotification notification)
    {
        Debug.Log("���Ʋ�������֪ͨ���ݲ�������ݴ���");
        DataProxy dataProxy = Facade.RetrieveProxy(DataProxy.NAME) as DataProxy;
        dataProxy.BeDamage(Random.Range(0, 100)); //��Ѫ

    }

}
