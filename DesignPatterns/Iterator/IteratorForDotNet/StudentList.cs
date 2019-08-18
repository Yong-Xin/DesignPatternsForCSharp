using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.IteratorForDotNet
{
    public class StudentList : IEnumerable
    {
        //public IEnumerator<Student> GetEnumerator()
        //{
        //    yield return new Student() { Name = "Kevin", Sex = "男" };
        //    yield return new Student("东旭", "女");
        //}

        public Student[] students;

        public StudentList(Student[] sts)

        {

            this.students = sts;

        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < this.students.Length; index++)
            {
                yield return students[index];
            }

            //return students.GetEnumerator();
        }


        [Obsolete("Don't use OldMethod, use NewMethod instead", false)]
        public class Student1 : IEnumerator
        {
            public Student[] pers;
            public Student1(Student[] per)
            {
                this.pers = per;
            }
            int position = -1;

            public bool MoveNext()
            {
                position++;
                return position < pers.Length;
            }
            public void Reset()
            {
                position = -1;
            }
            public object Current
            {
                get
                {
                    try
                    {
                        return pers[position];
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
