using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_BS_19011519_006
{
        public class Student
        {
            private int student_id;
            private string student_name;
            private string student_email;
            private DateTime student_dob;
            private string student_phone_number;
            private string student_image;
            private bool student_gender;
            private string address;
            

            public override string ToString()
            {
                return $"{ID}, {Name}, {Email}, {DOB}, {Phone_Number}, {Gender}, {Address}, {Image}";
            }

            public Student()
            {
                ID = 0;
                Name = "";
                Email = "";
                DOB = DateTime.Now;
                Gender = true;
                Phone_Number = "";
                Address = "";
                
            }

            public bool Gender
            {
                get { return student_gender; }
                set { student_gender = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public String Image
            {
                get { return student_image; }
                set { student_image = value; }
            }

            public string Phone_Number
            {
                get { return student_phone_number; }
                set { student_phone_number = value; }
            }

            public DateTime DOB
            {
                get { return student_dob; }
                set { student_dob = value; }
            }


            public string Email
            {
                get { return student_email; }
                set { student_email = value; }
            }


            public string Name
            {
                get { return student_name; }
                set { student_name = value; }
            }


            public int ID
            {
                get { return student_id; }
                set { student_id = value; }
            }

        }
    }