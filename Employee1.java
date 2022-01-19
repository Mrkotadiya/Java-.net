class Employee
{
	String empName;
	String design;
	int basic;
	
	Employee(String ename,String d,int b)
	{
		empName=ename;
		design=d;
		basic=b;
		
	}
	float calculateSalary()
	{
		float da,hra,media,pf,insurance,gross;
		da=basic*0.15f;
		hra=basic*01f;
		media=basic*0.04f;
		gross = basic + da + hra + medical;
		insurance=gross*0.07f;
		float net=gross-pf-insurance;
		return net;
	}
	class Salary
	{
		public static void main(String args[])
		{
			Scanner sc=new Scanner(System.in);
			System.out.println("Enter the Employee");
			String name=sc.nextLine();
			System.out.println("Enter Designation of Employee");
			
			String design=sc.nextLine();
			System.out.println("Enter Basic Salary of Employee");
			
			int basic=sc.nextLine();
			Employee emp1=new Employee(name,design,basic);
			
			System.out.println("Salary of Employee1="+emp1.calculateSalary());
			
			
		}
	}	
}