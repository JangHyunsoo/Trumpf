using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public enum Symbol
{
    CLOVAR,
    HEART,
    DIAMOND,
    SPADE
}


public class Utility
{
 
    public static Transform[] getChildsTransform(Transform parent_)
    {
        Transform[] ret = new Transform[parent_.childCount];
        for (int i = 0; i < parent_.childCount; i++)
        {
            ret[i] = parent_.GetChild(i);
        }
        return ret;
    }

    public static Vector3 getScreenMousePos()
    {
        Vector3 mouse_pos_ = Input.mousePosition;
        Vector3 trans_pos_ = Camera.main.ScreenToWorldPoint(mouse_pos_);
        Vector3 target_pos_ = new Vector3(trans_pos_.x, trans_pos_.y, 0);

        return target_pos_;
    }

  
    public static int randIndex(params float[] percent)
    {
        float[] stack_percent = new float[percent.Length];
        stack_percent[0] = percent[0];
        for (int i = 1; i < stack_percent.Length; i++)
        {
            stack_percent[i] = stack_percent[i - 1] + percent[i];
        }
        float rand = Random.RandomRange(0f, 1f);
        
        for(int i = 0; i < stack_percent.Length; i++)
        {
            if (stack_percent[i] >= rand)
                return i;
        }
        return -1;
    }

    public static int modNumber(int _num, int _max, int _cal)
    {
        int result = (_num + _cal) % _max;
        return result < 0 ? result + _max : result;
    }

    public static Quaternion getDirecitonToRotation(Vector3 _vec)
    {
        return Quaternion.Euler(new Vector3(0f, 0f, getDegreeFromRadian(Mathf.Atan2(_vec.y, _vec.x))));
    }
    
    public static float getDegreeFromRadian(float _radian)
    {
        return _radian * 180 / Mathf.PI;
    }

    public static int[] getShuffleArray(int _size)
    {
        int[] shuffle_arr = Enumerable.Range(0, _size).ToArray();
        System.Random random = new System.Random();
        shuffle_arr = shuffle_arr.OrderBy(x => random.Next()).ToArray();
        return shuffle_arr;
    }

    public static T getRandomValueInArray<T>(T[] _array)
    {
        return _array[Random.Range(0, _array.Length)];
    }
}

