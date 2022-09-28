using BusinessAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
    public class Member1
    {
        public int member_id
        {
            get;
            set;
        }
        public string member_name
        {
            get;
            set;

        }
        public DateTime? Accopen
        {
            get;
            set;
        }
        public int? maxbooks
        {
            get;
            set;
        }
        public double? penalty
        {
            get;
            set;
        }
    }
    public class MemberOperations
    {
        public void insertmember(Member1 c)
        {
            libraryEntities context = new libraryEntities();
            List<member> m = context.members.ToList();
            member m1 = new member();
            m1.member_id = c.member_id;
            m1.member_name = c.member_name;
            m1.Acc_open_date = c.Accopen;
            m1.maxbooksallowed = c.maxbooks;
            m1.penaltyamount =(int)c.penalty;
            context.members.Add(m1);
            context.SaveChanges();
        }
        public void updatemember(int no,Member1 c)
        {
            libraryEntities context = new libraryEntities();
            List<member> m = context.members.ToList();
            member m1 = m.Find(member=>member.member_id==no);
               
            m1.member_id = c.member_id;
            m1.member_name = c.member_name;
            m1.Acc_open_date = c.Accopen;
            m1.maxbooksallowed = c.maxbooks;
            m1.penaltyamount = (int)c.penalty;
           
            context.SaveChanges();
        }
        public void deletemember(int no)
        {
            libraryEntities context = new libraryEntities();
            List<member> m1 = context.members.ToList();
            member m = m1.Find(member => member.member_id == no);
            context.members.Remove(m);
            context.SaveChanges();
        }
        public Member1 findmember(int no)
        {
            libraryEntities context = new libraryEntities();
            List<member> m1 = context.members.ToList();
            member m = m1.Find(member => member.member_id == no);
            Member1 m2 = new Member1();
            m2.member_id =(int) m.member_id;
            m2.member_name = m.member_name;
            m2.Accopen = m.Acc_open_date;
            m2.maxbooks =(int) m.maxbooksallowed;
            m2.penalty = (int)m.penaltyamount;
            return m2;


        }
        public int membercount()
        {
            List<Member1> list=new List<Member1>();
            list=Showall();
            return list.Count;
        }
        public List<Member1> Showall()
        {
            libraryEntities context = new libraryEntities();
            List<member> list =context.members.ToList();
            List<Member1> list1 = new List<Member1>();
            foreach(var item in list)
            {
                Member1 member = new Member1();
                member.member_id =Convert.ToInt32(item.member_id);
                member.member_name = item.member_name;

                if (!item.Acc_open_date.HasValue)
                {
                    member.Accopen = null;
                }
                else
                {
                    member.Accopen = item.Acc_open_date;
                }
                if (item.maxbooksallowed.HasValue)
                {
                    member.maxbooks = Convert.ToInt32(item.maxbooksallowed);
                }
                else
                {
                    member.maxbooks = null;
                }
                if (item.penaltyamount.HasValue)
                {
                    member.penalty = Convert.ToInt32(item.penaltyamount);
                }
                else
                {
                    member.penalty = null;
                }


                list1.Add(member);
               


            }
            return list1;
        }
    }
}
