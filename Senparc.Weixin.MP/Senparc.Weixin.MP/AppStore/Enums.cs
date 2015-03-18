﻿namespace Senparc.Weixin.MP.AppStore
{
    /// <summary>
    /// P2P返回结果类型
    /// </summary>
    public enum AppResultKind
    {
        成功 = 0,
        账户验证失败 = -1000,

        账户被停用 = -2000,
        账户被停用_尚未通过审核 = -2001,
        账户被停用_已关闭 = -2002,
        账户被停用_状态异常 = -2003,

        包含违法信息 = -3000,

        执行过程发生异常 = -4000,
        执行过程发生异常_API地址错误 = -4001,
        执行过程发生异常_积分不足 = -4002,

        操作用户信息失败 = -5000,
        操作用户信息失败_用户不存在 = -5001,
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum WeixinSex
    {
        未设置 = 0,
        男 = 1,
        女 = 2,
    }
}
