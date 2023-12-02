using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_01.CustomArrayClass
{
    public class MyArray
    {
        public int Length;
        private Object[] Data;
        //Creating Constructors
        public MyArray()
        {
            this.Length = 0;  //When the class is created, its length will be 0
            this.Data = new object[1]; //When the class is created, an empty array will be created
        }
        public Object Get(int index)  //Returns the array
        {
            return Data[index];
        }

        //pushing items at last index
        public Object[] Push(Object item)
        {
            if (this.Data.Length == this.Length)
            {
                Object[] temp = new Object[this.Length]; // creates a temp array 
                Array.Copy(this.Data, temp, Length); //copies all data to temp array     
                this.Data = new Object[Length + 1]; //increases size of temp array
                Array.Copy(temp, this.Data, Length);
            }

            this.Data[this.Length] = item;  //inserts item into last index
            this.Length++;
            return this.Data;
        }
        public Object Pop() //removes the last element of the array
        {
            Object poped = Data[this.Length - 1];
            this.Data[this.Length - 1] = null;  //nulling out the last item
            this.Length--; //decresing the length by 1 index            
            return poped; //returning the poped array
        }

        public Object Delete(int index)
        {
            Object itemToDelete = Data[index];
            ShiftItems(index); //calling the shiftItems method to shift the items at index
            return itemToDelete;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < Length - 1; i++)
            {
                Data[i] = Data[i + 1];
            }
            Data[Length - 1] = null;
            Length--;
        }

    }
}
