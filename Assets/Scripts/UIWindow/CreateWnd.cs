/****************************************************
    文件：CreateWnd.cs
	作者：朱龙飞
    邮箱: 398670608@qq.com
    日期：2019/7/7 9:12:38
	功能：角色创建界面
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class CreateWnd : WindowRoot
{
    public InputField iptName;

    protected override void InitWnd()
    {
        base.InitWnd();
        //显示一个随机名字
        iptName.text = resSvc.GetRDNameData(false);
    }

    public  void ClickRandBtn()
    {
        audioSvc.PlayUIAudio(Constants.UIClickBtn);

        string rdName = resSvc.GetRDNameData();
        iptName.text = rdName;

    }

    public void ClickEnterBtn()
    {
        audioSvc.PlayUIAudio(Constants.UIClickBtn);

        if (iptName.text!="")
        {
            //TODO
            //发送名字数据到服务器，登录主城
            GameRoot.AddTips("功能正在开发中。。。");

        }
        else
        {
            GameRoot.AddTips("当前名字不符合规范");
        }
        
    }
}