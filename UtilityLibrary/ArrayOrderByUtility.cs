using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************
 * 描述：数组排序
 * 作者：mo
 * 创建时间：2015-09-06
 * 修改时间：2015-09-06
 ****************/
namespace UtilityLibrary
{
    public class ArrayOrderByUtility
    {
        /// <summary>
        /// 数组排序
        /// </summary>
        /// <param name="_array">目标数组</param>
        /// <param name="_startIndex">起始下标</param>
        /// <param name="_high">结束下标</param>
        /// <returns></returns>
        public static Array QuickSortFunction(int[] _array, int _startIndex, int _entindex)
        {
            try
            {
                int keyValuePosition;//记录关键的下标

                if (_startIndex < _entindex)//传递的目标数组含有两个以上的元素，进行递归调用。（当传递目标数组只含一个元素，排序结束）
                {
                    keyValuePosition = keyValuePositionFunction(_array, _startIndex, _entindex);  //获取关键值的下标（快排的核心）
                    QuickSortFunction(_array, _startIndex, keyValuePosition - 1);    //递归调用，快排划分出来的左区间
                    QuickSortFunction(_array, keyValuePosition + 1, _entindex);   //递归调用，快排划分出来的右区间
                }
            }
            catch (Exception)
            {

                throw;
            }
            return _array;
        }

        private static int keyValuePositionFunction(int[] array, int low, int high)
        {
            int leftIndex = low;        //记录目标数组的起始位置（后续动态的左侧下标）
            int rightIndex = high;      //记录目标数组的结束位置（后续动态的右侧下标）

            int keyValue = array[low];  //数组的第一个元素作为关键值
            int temp;

            //当 （左侧动态下标 == 右侧动态下标） 时跳出循环
            while (leftIndex < rightIndex)
            {
                while (leftIndex < rightIndex && array[leftIndex] <= keyValue)  //左侧动态下标逐渐增加，直至找到大于keyValue的下标
                {
                    leftIndex++;
                }
                while (leftIndex < rightIndex && array[rightIndex] > keyValue)  //右侧动态下标逐渐减小，直至找到小于或等于keyValue的下标
                {
                    rightIndex--;
                }
                if (leftIndex < rightIndex)  //如果leftIndex < rightIndex，则交换左右动态下标所指定的值；当leftIndex==rightIndex时，跳出整个循环
                {
                    temp = array[leftIndex];
                    array[leftIndex] = array[rightIndex];
                    array[rightIndex] = temp;
                }
            }

            //当左右两个动态下标相等时（即：左右下标指向同一个位置），此时便可以确定keyValue的准确位置
            temp = keyValue;
            if (temp < array[rightIndex])   //当keyValue < 左右下标同时指向的值，将keyValue与rightIndex - 1指向的值交换，并返回rightIndex - 1
            {
                array[low] = array[rightIndex - 1]; array[rightIndex - 1] = temp;
                return rightIndex - 1;
            }
            else //当keyValue >= 左右下标同时指向的值，将keyValue与rightIndex指向的值交换，并返回rightIndex
            {
                array[low] = array[rightIndex];
                array[rightIndex] = temp;
                return rightIndex;
            }
        }

    }
}
