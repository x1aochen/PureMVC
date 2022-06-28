using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��ͼ��
/// </summary>
public class HPMediator:Mediator
{
    private Button btn;
    private Image hpBar;
    public static new string NAME = "HPMediator";
    public HPMediator(Transform canvas) : base(NAME) 
    {
        Debug.Log("������ͼ��");
        hpBar = canvas.Find("HPBar").GetComponent<Image>();
        btn = canvas.Find("TestBtn").GetComponent<Button>();
        btn.onClick.AddListener(() => {
            Debug.Log("֪ͨ���Ʋ�ִ�ж�Ӧ����");
            SendNotification(AppConst.ClickTestBtnCommand);
            });
    }

    /// <summary>
    /// �����Ϣ����
    /// </summary>
    /// <returns></returns>
    public override string[] ListNotificationInterests()
    {
        List<string> msgList = new List<string>();
        //�����Ϣ
        Debug.Log("��ͼ�������Ϣ����");
        msgList.Add(AppConst.UpdateHPBarMsg);
        msgList.Add(AppConst.ClickTestBtnCommand);
        
        return msgList.ToArray();
    }

    /// <summary>
    /// ������Ϣ
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        Debug.Log("�������ݲ�֪ͨ��������ͼ����  " + notification);
        
        switch (notification.Name)
        {
            case AppConst.UpdateHPBarMsg:
                //��ʾѪ������
                hpBar.transform.Find("Fill").GetComponent<Image>().fillAmount = (float)notification.Body;
                break;
            default:
                break;
        }
    }
}
