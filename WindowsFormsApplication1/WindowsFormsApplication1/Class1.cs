using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   public class Class1
   {
     private int [,] _array;
     private int _aX;
     private int _aY;

     public Class1(int aY,int aX)
     {
        _aY = aY;
        _aX = aX;
        _array= new int[aY,aX];
        RandomInitialize();

     }

      public int Rank()
      {
         _array.Initialize();
         return _array.Length ;
         // return _array.Rank();
      }

      private void RandomInitialize()
      {
         Random _tempRandom = new Random();

         for(int i =0 ;i<_aY;i++)
         {
            for(int j = 0 ;j<_aX;j++)
            {
               _array[i, j] = i + j;
            }
         }
      }
      public int[,] Array()
      {
         return _array;
      }

      public int Length()
      {
         return _array.Length;
      }

      public int X()
      {
         return _aX;
      }
      public int Y()
      {
         return _aY;
      }

      public void Populate(DataGridView aGrid)
      {
         for (int i = 0; i < aGrid.RowCount; i++)
         {
            for (int j = 0; j < aGrid.ColumnCount; j++)
            {
               //  Messa
               // Object tempValue = newClass.Array().GetValue(i,j);
               aGrid.Rows[i].Cells[j].Value = _array.GetValue(i, j);
            }
         }
      }
   }
}
