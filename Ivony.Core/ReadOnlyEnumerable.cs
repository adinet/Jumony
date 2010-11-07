﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony
{

  /// <summary>
  /// 该类为可修改的集合提供一份只读的枚举包装，避免用户利用强制类型转换来修改集合。
  /// </summary>
  /// <typeparam name="T">枚举元素类型</typeparam>
  public sealed class ReadOnlyEnumerable<T> : IEnumerable<T>
  {
    private IEnumerable<T> _enumerable;

    public ReadOnlyEnumerable( IEnumerable<T> enumerable )
    {
      _enumerable = enumerable;
    }


    #region IEnumerable<T> 成员

    public IEnumerator<T> GetEnumerator()
    {
      return _enumerable.GetEnumerator();
    }

    #endregion

    #region IEnumerable 成员

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion
  }
}
