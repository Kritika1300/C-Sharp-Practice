using System;

namespace Classes
{

    public class UserArgs : EventArgs 
    {
        public string Name { get; set; }
    }
    public class OnlineAttendance
    {
        public delegate void AttendanceEventHandler(object sender, UserArgs e);
     
        public static event AttendanceEventHandler AttendanceEvent;

        public void MarkAttendance(string name)
        {
            if (AttendanceEvent != null)
                AttendanceEvent(this, new UserArgs() { Name = name });
        }


    }

    public class FireAlarm
    {
        public void FireAlarmRinging(object sender, UserArgs e)
        {
            Console.WriteLine("Ringing the fire alarm... " + e.Name);
        }
    }

    public class MailToAdmin
    {
        public void MailingTheAdmin(object sender, EventArgs e)
        {
            Console.WriteLine("Mailing the administrator......");
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            OnlineAttendance oa = new OnlineAttendance();
            MailToAdmin mail = new MailToAdmin();
            FireAlarm alarm = new FireAlarm();

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            if(name == "Jack" || name == "Steven" || name == "Mathew")
            {
                OnlineAttendance.AttendanceEvent += mail.MailingTheAdmin;
                OnlineAttendance.AttendanceEvent += alarm.FireAlarmRinging;

            }
            else
            {
                Console.WriteLine("Welcome " + name);
            }

            oa.MarkAttendance(name);

        }
    }


}




