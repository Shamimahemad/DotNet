namespace PRSN;
public class Person{
    private int pid;
    private string pname;
    private string email;
    private string city;
    private DateTime bdate;

 public Person(){
    this.pid=0;
    this.pname=null;
    this.email=null;
    this.city=null;
    this.bdate=new DateTime(1999,07,11);
 }
 public Person(int pid,string pname,string email,string city,DateTime bdate){
    this.pid=pid;
    this.pname=pname;
    this.email=email;
    this.city=city;
    this.bdate=bdate;
 }
 public int Pid{
    get{return this.pid;}
    set{this.pid=value;}
 }
 public string Pname{
    get{return this.pname;}
    set{this.pname=value;}
 }
 public string Email{
    get{return this.email;}
    set{this.email=value;}
 }
  public string City{
    get{return this.city;}
    set{this.city=value;}
 }
  public DateTime Bdate{
    get{return this.bdate;}
    set{this.bdate=value;}
 }

    public override string ToString()
    {
        return base.ToString()+" pid: " +this.pid+" ,pname: "+this.pname+" ,email: "+this.email+",city: "+this.city+
       " ,bdate: "+this.bdate ;
    }

 }
