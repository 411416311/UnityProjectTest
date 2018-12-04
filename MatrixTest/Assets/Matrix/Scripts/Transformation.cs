//=====================================================
// - FileName:      Transformation.cs
// - Created:       wangguoqing
// - UserName:      2018/07/22 17:17:46
// - Email:         wangguoqing@hehegames.cn
// - Description:   
// -  (C) Copyright 2008 - 2015, hehehuyu,Inc.
// -  All Rights Reserved.
//======================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Transformation : MonoBehaviour {
    
    public abstract Matrix4x4 Matrix { get; }

    //��ע��Matrix4x4��MultiplyPoint����һ����άʸ��������������ȱʧ�ĵ��ĸ������ֵ��1�����������������굽ŷ����������ת��������������һ�����������һ���㣬�����ʹ��Matrix4x4.MultiplyVector
    public Vector3 Apply(Vector3 point)
    {
        return Matrix.MultiplyPoint(point);
    } 
}
