namespace STD;
using PRSN;
public class Student:Person{
  
    private string course;
    private DateTime admDate;

 public Student():base(){
    
    this.course=null;
    this.admDate=new DateTime(1999,07,11);
 }
 public Student(int pid,string pname,string email,string city,DateTime bdate,string course,DateTime admDate):base(pid,pname,email,city,bdate){
   
    this.course=course;
    this.admDate=admDate;
 }
 
  public string Course{
    get{return this.course;}
    set{this.course=value;}
 }
  public DateTime AdmDate{
    get{return this.admDate;}
    set{this.admDate=value;}
 }

    public override string ToString()
    {
        return base.ToString()+" ,course: " +this.course+" ,Admdate : "+this.admDate;
    }

 }
