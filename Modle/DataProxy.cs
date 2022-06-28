using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Proxy;

/// <summary>
/// ��������
/// </summary>
public class DataProxy:Proxy
{
    //���Ʋ�ͨ�����ֻ��
    public static new string NAME = "DataProxy";

    private Data data;
    public DataProxy() : base(NAME)
    {
        Debug.Log("�������������");
        data = new Data(100); //��ʼ������
    }

    //���ݴ���
    public void BeDamage(int damage)
    {
        data.HP -= damage;
        //������Ϣ����ͼ������Ѫ������
        Debug.Log("���ݴ�����ɣ�֪ͨ��ͼ�����");
        SendNotification(AppConst.UpdateHPBarMsg, data.HP * 1.0f / data.MaxHp); 
    }
}
